using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace курсовая
{
    public class Book
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; } = new List<string>();
        public string LibraryCode { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public string Place { get; set; }
        public int AvailableCopies { get; set; }
        public string Category { get; set; }
        public bool IsForReadingHallOnly { get; set; }
        public int MaxLoanDays { get; set; }
        public ReadingHallLocation ReadingHallLocation { get; set; }
        public bool IsAvailable { get; set; } = true;

        public string AuthorsString => string.Join(", ", Authors);
        public string LocationString => IsForReadingHallOnly ? ReadingHallLocation?.ToString() : "Выдача на дом";
      
        public int GetLoanDaysByCategory(string category)
        {
            switch (category.ToLower())
            {
                case "учебник":
                    return 182;
                case "повесть":
                case "роман":
                case "статья":
                case "стих":
                    return 14;
                case "диссертация":
                case "реферат":
                    return 30;
                default:
                    return 14; // Значение по умолчанию
            }
        }

    }
}