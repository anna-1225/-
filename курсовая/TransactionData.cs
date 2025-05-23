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
    public static class TransactionData
    {
        public static List<Transaction> Transactions { get; private set; } = new List<Transaction>();
        private static readonly string DataFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Data",
            "transactions.json");

        static TransactionData()
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
                    Transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных о транзакциях: {ex.Message}");
                Transactions = new List<Transaction>();
            }
        }
        public static void CalculateFines()
        {
            foreach (var transaction in Transactions)
            {
                if (transaction.ReturnDate == null && DateTime.Now > transaction.DueDate)
                {
                    int overdueDays = (DateTime.Now - transaction.DueDate).Days;
                    transaction.FineAmount = overdueDays * 5; // 5 руб. в день
                }
            }
        }
        public static void SaveData()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Transactions, Formatting.Indented);
                File.WriteAllText(DataFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных о транзакциях: {ex.Message}");
            }
        }

        public static void IssueBook(Book book, string readerTicketNumber, string librarianId, int loanDays, string notes = "")
        {
            try
            {
                if (book.AvailableCopies <= 0)
                {
                    MessageBox.Show("Нет доступных экземпляров для выдачи");
                    return;
                }

                var transaction = new Transaction
                {
                    BookLibraryCode = book.LibraryCode,
                    ReaderTicketNumber = readerTicketNumber,
                    IssueDate = DateTime.Today,
                    DueDate = DateTime.Today.AddDays(loanDays),
                    ReturnDate = null,
                };

                Transactions.Add(transaction);
                SaveData();

                // Обновляем количество доступных книг
                book.AvailableCopies--;
                book.IsAvailable = book.AvailableCopies > 0;
                BookData.AddOrUpdateBook(book);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выдаче книги: {ex.Message}");
            }
        }

        public static void ReturnBook(string transactionId)
        {
            try
            {
                var transaction = Transactions.FirstOrDefault(t => t.Id == transactionId);
                if (transaction == null) return;

                transaction.ReturnDate = DateTime.Today;
                SaveData();

                // Обновляем количество доступных книг
                var book = BookData.GetBookByCode(transaction.BookLibraryCode);
                if (book != null)
                {
                    book.AvailableCopies++;
                    book.IsAvailable = true;
                    BookData.AddOrUpdateBook(book);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при возврате книги: {ex.Message}");
            }
        }

        public static List<Transaction> GetActiveTransactionsByReader(string readerTicketNumber)
        {
            return Transactions
                .Where(t => t.ReaderTicketNumber == readerTicketNumber && t.ReturnDate == null)
                .OrderBy(t => t.DueDate)
                .ToList();
        }

        public static List<Book> GetBorrowedBooksByReader(string readerTicketNumber)
        {
            var activeTransactions = GetActiveTransactionsByReader(readerTicketNumber);
            return activeTransactions
                .Select(t => BookData.GetBookByCode(t.BookLibraryCode))
                .Where(b => b != null)
                .ToList();
        }
    }
}
