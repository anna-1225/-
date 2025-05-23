using System;
using System.Drawing;
using System.Windows.Forms;

namespace курсовая
{
    public partial class ForUsers : Form
    {
        public ForUsers()
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelUsers);
        }

        private void IssuanceBook_Click(object sender, EventArgs e)
        {
            var findReaderForm = new FindReaderForm(FindReaderForm.FormMode.IssueBook);
            findReaderForm.WindowState = FormWindowState.Maximized;

            if (findReaderForm.ShowDialog() == DialogResult.OK)
            {
                var searchBookForm = new BookSearch();
                searchBookForm.WindowState = FormWindowState.Maximized;

                searchBookForm.SelectedReader = findReaderForm.SelectedReader;
                searchBookForm.UpdateButtonStates();
                searchBookForm.ShowDialog();
            }
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            using (var findReaderForm = new FindReaderForm(FindReaderForm.FormMode.ReturnBook))
            {
                findReaderForm.WindowState = FormWindowState.Maximized;
                if (findReaderForm.ShowDialog() == DialogResult.OK && findReaderForm.SelectedReader != null)
                {
                    using (var returnForm = new BookReturn(findReaderForm.SelectedReader.LibraryCardNumber))
                    {
                        returnForm.WindowState = FormWindowState.Maximized;
                        returnForm.ShowDialog();
                    }
                }
            }
        }

        private bool ReaderHasBooks(string libraryCardNumber)
        {
            try
            {
                var activeTransactions = TransactionData.GetActiveTransactionsByReader(libraryCardNumber);
                return activeTransactions?.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке книг: {ex.Message}",
                             "Ошибка",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}