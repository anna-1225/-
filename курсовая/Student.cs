using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая
{
    public class StudentReader : Reader
    {
        [DisplayName("Факультет")]
        public string Faculty { get; set; }

        [DisplayName("Группа")]
        public string GroupNumber { get; set; }

        [DisplayName("Слушатель ПО/ФПК")]
        public bool IsListener { get; set; }
    }
}
