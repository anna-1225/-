using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая
{
    public class Transaction
    {
        [DisplayName("ID транзакции")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [DisplayName("Библиотечный шифр")]
        public string BookLibraryCode { get; set; }

        [DisplayName("Номер билета читателя")]
        public string ReaderTicketNumber { get; set; }

        [DisplayName("Дата выдачи")]
        public DateTime IssueDate { get; set; }

        [DisplayName("Срок возврата")]
        public DateTime DueDate { get; set; }

        [DisplayName("Фактическая дата возврата")]
        public DateTime? ReturnDate { get; set; }

        [DisplayName("Статус книги")]
        public string Status => ReturnDate.HasValue ? "Возвращена" : "На руках";

        [DisplayName("Штраф")]

        public decimal FineAmount { get; set; }
    }
}