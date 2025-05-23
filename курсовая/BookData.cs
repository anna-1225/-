using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая
{
    public static class BookData
    {
        public static List<Book> Books { get; private set; } = new List<Book>();
        // Путь к файлу хранения данных (в подпапке Data текущей директории)
        private static readonly string DataFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Data",
            "books.json");

        static BookData()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DataFilePath));
            LoadData();
        }

        public static void LoadData()
        {
            try
            {
                if (File.Exists(DataFilePath))
                {
                    string json = File.ReadAllText(DataFilePath);
                    // Десериализуем JSON в список книг, если null - создаем новый список
                    Books = JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
                Books = new List<Book>();
            }
        }

        public static void SaveData()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Books, Formatting.Indented);
                File.WriteAllText(DataFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        public static void AddOrUpdateBook(Book book)
        {
            try
            {
                var existingBook = Books.FirstOrDefault(b => b.LibraryCode == book.LibraryCode);
                if (existingBook != null)
                {
                    Books.Remove(existingBook);
                }
                Books.Add(book);
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления книги: {ex.Message}");
            }
        }

        public static bool RemoveBook(string libraryCode)
        {
            try
            {
                var bookToRemove = Books.FirstOrDefault(b => b.LibraryCode == libraryCode);
                if (bookToRemove != null)
                {
                    Books.Remove(bookToRemove);
                    SaveData();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления книги: {ex.Message}");
                return false;
            }
        }

        public static Book GetBookByCode(string libraryCode)
        {
            return Books.FirstOrDefault(b => b.LibraryCode == libraryCode);
        }

        //Список найденных книг, отсортированных по названию
        public static List<Book> SearchBooks(string searchTerm, bool searchByCode = false)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return new List<Book>(Books);

            return Books.Where(b =>
                searchByCode
                    ? b.LibraryCode.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                    : b.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                      b.Authors.Any(a => a.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0))
                .OrderBy(b => b.Title)
                .ToList();
        }

        public static List<string> GetAllCategories()
        {
            return Books.Select(b => b.Category)
                       .Where(c => !string.IsNullOrEmpty(c))
                       .Distinct()
                       .OrderBy(c => c)
                       .ToList();
        }
    }
}
