using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая
{
    public class ReadingHallLocation
    {
        public string HallNumber { get; set; }
        public string RackNumber { get; set; }
        public string ShelfNumber { get; set; }

        public override string ToString()
        {
            return $"Зал: {HallNumber}, Стеллаж: {RackNumber}, Полка: {ShelfNumber}";
        }
    }
}
