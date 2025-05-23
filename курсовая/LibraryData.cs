using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая
{
    public static class LibraryData
    {
        public static List<Reader> Readers { get; set; } = new List<Reader>();


        // Путь к файлу в папке с программой
        private static readonly string DataFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Data",
            "readers.json");

        static LibraryData()
        {
            // Создаем папку Data, если ее нет
            Directory.CreateDirectory(Path.GetDirectoryName(DataFilePath));
            LoadData();
        }

        public static void LoadData()
        {
            if (File.Exists(DataFilePath))
            {
                string json = File.ReadAllText(DataFilePath);
                Readers = JsonConvert.DeserializeObject<List<Reader>>(json, jsonSettings) ?? new List<Reader>();
            }
        }
        private static readonly JsonSerializerSettings jsonSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto
        };
        public static void SaveData()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Readers, Formatting.Indented, jsonSettings);
                File.WriteAllText(DataFilePath, json);

                // Обновляем файл в Обозревателе решений
                UpdateSolutionExplorerFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private static void UpdateSolutionExplorerFile()
        {
            // Этот метод нужен для обновления отображения файла в Visual Studio
        }

        public static void AddReader(Reader reader)
        {
            Readers.Add(reader);
            SaveData();
        }

        public static bool RemoveReader(string libraryCardNumber)
        {
            var readerToRemove = Readers.FirstOrDefault(r => r.LibraryCardNumber == libraryCardNumber);
            if (readerToRemove != null)
            {
                Readers.Remove(readerToRemove);
                SaveData();
                return true;
            }
            return false;
        }
    }
}
