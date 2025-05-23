using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace курсовая
{
    public class Reader
    {
        [DisplayName("Имя")]
        public string tName { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Отчество")]
        public string Surname { get; set; }

        [DisplayName("Дата регистрации")]
        public DateTime Registration { get; set; }

        [DisplayName("Дата перерегистрации")]
        public DateTime Reestablish { get; set; }

        [DisplayName("Номер билета")]
        public string LibraryCardNumber { get; set; }

        [DisplayName("Категория")]
        public string Category { get; set; }
    }
}