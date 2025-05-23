using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace курсовая
{
    public partial class BookReturn : Form
    {
        private readonly string _readerCardNumber;
        private readonly Reader _reader;

        public BookReturn(string readerCardNumber)
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelReturn);

            _readerCardNumber = readerCardNumber;
            _reader = LibraryData.Readers.FirstOrDefault(r => r.LibraryCardNumber == readerCardNumber);
            dgvBorrowedBooks.SelectionChanged += dgvBorrowedBooks_SelectionChanged;

            this.Text = "Возврат книг";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            dgvBorrowedBooks.AutoGenerateColumns = false;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.MultiSelect = false;
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBorrowedBooks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            btnReturn.Enabled = false;
            btnReturn.Click += BtnReturn_Click;
            btnClose.Click += (s, e) => this.Close();

            LoadReaderInfo();
            LoadBorrowedBooks();
        }

        private void LoadReaderInfo()
        {
            if (_reader != null)
            {
                lblReaderInfo.Text = $"Читатель: {_reader.tName} (№ билета: {_reader.LibraryCardNumber})";
            }
        }

        private void LoadBorrowedBooks()
        {
            dgvBorrowedBooks.Rows.Clear();

            var borrowedBooks = TransactionData.Transactions
                .Where(t => t.ReaderTicketNumber == _readerCardNumber && t.ReturnDate == null)
                .Select(t => new
                {
                    t.Id,
                    Book = BookData.Books.FirstOrDefault(b => b.LibraryCode == t.BookLibraryCode),
                    t.IssueDate,
                    t.DueDate
                })
                .Where(x => x.Book != null)
                .ToList();

            foreach (var item in borrowedBooks)
            {
                dgvBorrowedBooks.Rows.Add(
                    item.Book.Title,
                    item.Book.LibraryCode,
                    item.IssueDate.ToShortDateString(),
                    item.DueDate.ToShortDateString(),
                    item.Id
                );
            }

            // Автоподбор ширины колонок
            foreach (DataGridViewColumn column in dgvBorrowedBooks.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count == 0) return;

            var selectedRow = dgvBorrowedBooks.SelectedRows[0];
            var bookCode = selectedRow.Cells["BookCode"].Value?.ToString();

            if (string.IsNullOrEmpty(bookCode))
            {
                MessageBox.Show("Не удалось определить код книги", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var transaction = TransactionData.Transactions
                    .FirstOrDefault(t => t.BookLibraryCode == bookCode &&
                                        t.ReaderTicketNumber == _readerCardNumber &&
                                        t.ReturnDate == null);

                if (transaction == null)
                {
                    MessageBox.Show("Не найдена активная выдача этой книги", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                transaction.ReturnDate = DateTime.Today;
                var book = BookData.Books.FirstOrDefault(b => b.LibraryCode == bookCode);
                if (book != null)
                {
                    book.AvailableCopies++;
                }

                BookData.SaveData();
                TransactionData.SaveData();

                MessageBox.Show("Книга успешно возвращена", "Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBorrowedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при возврате книги: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvBorrowedBooks_SelectionChanged(object sender, EventArgs e)
        {
            btnReturn.Enabled = dgvBorrowedBooks.SelectedRows.Count > 0
                                && dgvBorrowedBooks.SelectedRows[0].Cells.Count > 1
                                && dgvBorrowedBooks.SelectedRows[0].Cells[1].Value != null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}