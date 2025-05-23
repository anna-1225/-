using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая
{
    public class StaffReader : Reader
    {
        [DisplayName("Отдел")]
        public string Division { get; set; }

        [DisplayName("Должность")]
        public string EmployeePosition { get; set; }
    }
}
