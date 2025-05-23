using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace курсовая
{
    public partial class FindReaderForm : Form
    {
        public enum FormMode
        {
            IssueBook,
            ReturnBook,
            EditReader
        }

        public Reader SelectedReader { get; private set; }
        public FormMode Mode { get; private set; }

        public FindReaderForm(FormMode mode = FormMode.ReturnBook)
        {
            InitializeComponent();
            Mode = mode;
            ControlHelper.CenterControl(panelFind);
        }

        private bool FindReader()
        {
            string cardNumber = LibraryCardNumber.Text.Trim();

            if (string.IsNullOrEmpty(cardNumber))
            {
                MessageBox.Show("Введите номер читательского билета!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SelectedReader = LibraryData.Readers.FirstOrDefault(r =>
                           r.LibraryCardNumber == cardNumber);

            if (SelectedReader == null)
            {
                MessageBox.Show("Читатель с таким номером билета не найден!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ReaderHasBooks()
        {
            return TransactionData.Transactions
                .Any(t => t.ReaderTicketNumber == SelectedReader.LibraryCardNumber &&
                         t.ReturnDate == null);
        }


        private void SelectReader_Click(object sender, EventArgs e)
        {
            if (SelectedReader == null && !FindReader())
            {
                return;
            }

            if (Mode != FormMode.EditReader && !IsReaderValid(SelectedReader))
            {
                MessageBox.Show("Читатель не может получить книги!\nПричина: регистрация просрочена или заблокирована",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            // Для возврата проверяем наличие книг
            if (Mode == FormMode.ReturnBook && !ReaderHasBooks())
            {
                MessageBox.Show("У этого читателя нет книг на руках", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private bool IsReaderValid(Reader reader)
        {
            return reader != null && reader.Reestablish >= DateTime.Today;
        }

        private void LibraryCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectReader_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (FindReader())
            {
                string message;
                MessageBoxIcon icon = MessageBoxIcon.Information;

                if (Mode == FormMode.IssueBook)
                {
                    message = $"Читатель найден: {SelectedReader.tName}";
                }
                else if (Mode == FormMode.ReturnBook)
                {
                    if (ReaderHasBooks())
                    {
                        message = $"Читатель найден: {SelectedReader.tName}";
                    }
                    else
                    {
                        message = "У этого читателя нет книг на руках";
                    }
                }
                else
                {
                    message = $"Читатель найден: {SelectedReader.tName}";
                }

                MessageBox.Show(message, "Успех", MessageBoxButtons.OK, icon);
            }
        }
    }
}