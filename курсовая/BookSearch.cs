using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace курсовая
{
    public partial class BookSearch : Form
    {
        public Book SelectedBook { get; private set; }
        public Reader SelectedReader { get; set; }

        public BookSearch()
        {
            InitializeComponent();
            SetupControls();
            ControlHelper.CenterControl(panelSearch);
        }
        public void UpdateButtonStates()
        {
            bool isInIssuanceMode = SelectedReader != null;

            EditBook.Enabled = !isInIssuanceMode;
            DeleteBook.Enabled = !isInIssuanceMode;
        }
        private void ShowReaderFines()
        {
            var readerTransactions = TransactionData.Transactions
                .Where(t => t.ReaderTicketNumber == SelectedReader.LibraryCardNumber && t.ReturnDate == null)
                .ToList();

            decimal totalFine = 0;
            foreach (var transaction in readerTransactions)
            {
                if (DateTime.Now > transaction.DueDate)
                {
                    int overdueDays = (DateTime.Now - transaction.DueDate).Days;
                    totalFine += overdueDays * 5;
                }
            }

            MessageBox.Show($"Текущий штраф читателя {SelectedReader.tName}: {totalFine} руб.",
                            "Информация о штрафах", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SetupControls()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false; // Запрещаем множественный выбор
            dgvBooks.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
        }
        private void DisplayAllBooks()
        {
            try
            {
                dgvBooks.Rows.Clear();
                foreach (var book in BookData.Books)
                {
                    string location = "Выдача на дом";
                    if (book.IsForReadingHallOnly && book.ReadingHallLocation != null)
                    {
                        location = $"Зал: {book.ReadingHallLocation.HallNumber ?? "н/д"}, " +
                                  $"Стеллаж: {book.ReadingHallLocation.RackNumber ?? "н/д"}";
                    }

                    dgvBooks.Rows.Add(
                        book.Title ?? "Без названия",
                        book.LibraryCode ?? "н/д",
                        book.Authors != null ? string.Join(", ", book.Authors) : "н/д",
                        book.Publisher ?? "н/д",
                        book.Year,
                        location);
                }
                dgvBooks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отображении книг: {ex.Message}");
            }
        }


        private void SearchBook_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = FindBook.Text.Trim();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    DisplayAllBooks();
                    return;
                }

                bool searchByCode = SearchByCode.Checked;
                var results = BookData.Books
                    .Where(b => searchByCode
                        ? b.LibraryCode?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                        : b.Title?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                dgvBooks.Rows.Clear();
                foreach (var book in results)
                {
                    string location = "Выдача на дом";
                    if (book.IsForReadingHallOnly && book.ReadingHallLocation != null)
                    {
                        location = $"Зал: {book.ReadingHallLocation.HallNumber ?? "н/д"}, " +
                                  $"Стеллаж: {book.ReadingHallLocation.RackNumber ?? "н/д"}";
                    }

                    dgvBooks.Rows.Add(
                        book.Title ?? "Без названия",
                        book.LibraryCode ?? "н/д",
                        book.Authors != null ? string.Join(", ", book.Authors) : "н/д",
                        book.Publisher ?? "н/д",
                        book.Year,
                        location);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска: {ex.Message}");
            }
        }

        private void EditBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count == 0 || dgvBooks.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("Выберите книгу для редактирования!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string libraryCode = dgvBooks.SelectedRows[0].Cells["LibraryCode"].Value?.ToString();
                if (string.IsNullOrEmpty(libraryCode))
                {
                    MessageBox.Show("Не удалось получить код выбранной книги!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var book = BookData.Books.FirstOrDefault(b => b.LibraryCode == libraryCode);
                if (book == null)
                {
                    MessageBox.Show("Выбранная книга не найдена в базе данных!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var editForm = new EditBook(book))
                {
                    editForm.WindowState = FormWindowState.Maximized;
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        SearchBook_Click(null, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании книги: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count == 0 || dgvBooks.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("Выберите книгу для удаления!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string libraryCode = dgvBooks.SelectedRows[0].Cells["LibraryCode"].Value?.ToString();
                if (string.IsNullOrEmpty(libraryCode))
                {
                    MessageBox.Show("Не удалось получить код выбранной книги!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var book = BookData.Books.FirstOrDefault(b => b.LibraryCode == libraryCode);
                if (book == null)
                {
                    MessageBox.Show("Выбранная книга не найдена в базе данных!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show($"Удалить книгу '{book.Title}'?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BookData.RemoveBook(libraryCode);
                    SearchBook_Click(null, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении книги: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void TakeBook_Click(object sender, EventArgs e)

        {
            try
            {
                if (dgvBooks.SelectedRows.Count == 0 || dgvBooks.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("Выберите книгу для выдачи!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string libraryCode = dgvBooks.SelectedRows[0].Cells["LibraryCode"].Value?.ToString();
                var book = BookData.Books.FirstOrDefault(b => b.LibraryCode == libraryCode);

                if (book == null)
                {
                    MessageBox.Show("Книга не найдена!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (book.AvailableCopies <= 0)
                {
                    MessageBox.Show("Нет доступных экземпляров этой книги!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (book.IsForReadingHallOnly)
                {
                    MessageBox.Show("Эта книга только для чтения в зале!", "Ограничение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (SelectedReader == null)
                {
                    MessageBox.Show("Читатель не выбран!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SelectedReader is StudentReader student && student.IsListener && !book.IsForReadingHallOnly)
                {
                    MessageBox.Show("Слушатели могут пользоваться только читальными залами!\n" +
                                    "Эта книга предназначена для чтения в зале.",
                                    "Ограничение для слушателя",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ShowReaderFines();

                TransactionData.IssueBook(
                    book: book,
                    readerTicketNumber: SelectedReader.LibraryCardNumber,
                    librarianId: "system",
                    loanDays: book.MaxLoanDays,
                    notes: $"Выдано через интерфейс {DateTime.Now:dd.MM.yyyy HH:mm}"
                );

                string issueInfo = $"Книга: {book.Title}\n" +
                                 $"Читатель: {SelectedReader.tName}\n" +
                                 $"Дата выдачи: {DateTime.Today:dd.MM.yyyy}\n" +
                                 $"Срок возврата: {DateTime.Today.AddDays(book.MaxLoanDays):dd.MM.yyyy}\n" +
                                 $"Штраф за просрочку: 5 руб./день";

                MessageBox.Show(issueInfo, "Книга выдана",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SearchBook_Click(null, EventArgs.Empty);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выдаче книги: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BookSearch_Load(object sender, EventArgs e)
        {
            DisplayAllBooks();
        }
    }
}