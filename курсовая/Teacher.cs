using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая
{
    public class TeacherReader : Reader
    {
        [DisplayName("Кафедра")]
        public string Department { get; set; }

        [DisplayName("Должность")]
        public string Position { get; set; }

        [DisplayName("Степень")]
        public string Degree { get; set; }

        [DisplayName("Звание")]
        public string Rank { get; set; }
    }
}

