using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace курсовая
{
    public partial class AddEditBookForm : Form
    {
        private static readonly Random _random = new Random();
        private static readonly HashSet<string> _usedCodes = new HashSet<string>();
        private static readonly object _lock = new object();

        public Book Book { get; private set; }

        public AddEditBookForm(Book book = null)
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelAddBook);

            // Устанавливаем допустимые границы года
            Year.Minimum = 1900;
            Year.Maximum = DateTime.Now.Year;


            Book = book ?? new Book
            {
                Year = DateTime.Now.Year,
                LibraryCode = GenerateUniqueLibraryCode(),
                ReadingHallLocation = new ReadingHallLocation(),
                AvailableCopies = 1
            };

            if (book != null)
            {
                Book.AvailableCopies = book.AvailableCopies;
            }

            readingHallPanel.Visible = false;
            ReadingHallOnly.CheckedChanged += ReadingHallOnly_CheckedChanged;
            LoadBookData();
        }

        private void ReadingHallOnly_CheckedChanged(object sender, EventArgs e)
        {
            readingHallPanel.Visible = ReadingHallOnly.Checked;

            if (!ReadingHallOnly.Checked)
            {
                Book.ReadingHallLocation = null;
            }
            else if (Book.ReadingHallLocation == null)
            {
                Book.ReadingHallLocation = new ReadingHallLocation();
            }
        }

        private string GenerateUniqueLibraryCode()
        {
            lock (_lock)
            {
                string code;
                do
                {
                    int part1 = _random.Next(0, 10000);
                    int part2 = _random.Next(0, 10000);
                    code = $"{part1:D4}-{part2:D4}";
                }
                while (_usedCodes.Contains(code));

                _usedCodes.Add(code);
                return code;
            }
        }

        private void LoadBookData()
        {
            Title.Text = Book.Title;
            LibraryCode.Text = Book.LibraryCode;
            Year.Value = Book.Year;
            Publisher.Text = Book.Publisher;
            Place.Text = Book.Place;
            AvailableCopies.Value = Book.AvailableCopies;
            Category.Text = Book.Category;
            ReadingHallOnly.Checked = Book.IsForReadingHallOnly;
            MaxLoanDays.Value = Book.MaxLoanDays;
            RefreshAuthorsList();


            // Загрузка данных о местоположении
            if (Book.ReadingHallLocation != null)
            {
                HallNumber.Text = Book.ReadingHallLocation.HallNumber;
                RackNumber.Text = Book.ReadingHallLocation.RackNumber;
                ShelfNumber.Text = Book.ReadingHallLocation.ShelfNumber;
            }

            readingHallPanel.Visible = ReadingHallOnly.Checked;
            LibraryCode.ReadOnly = true;
        }


        private void RefreshAuthorsList()
        {
            listBoxAuthors.DataSource = null;
            listBoxAuthors.DataSource = Book.Authors;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(Title.Text))
            {
                MessageBox.Show("Введите название книги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Title.Focus();
                return false;
            }

            if (listBoxAuthors.Items.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одного автора!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AuthorName.Focus();
                return false;
            }

            if (AvailableCopies.Value < 1)
            {
                MessageBox.Show("Доступное количество не может быть отрицательным!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AvailableCopies.Focus();
                return false;
            }

            if (MaxLoanDays.Value < 1)
            {
                MessageBox.Show("Минимальный срок выдачи должен быть не менее 1 дня!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaxLoanDays.Focus();
                return false;
            }

            if (ReadingHallOnly.Checked)
            {
                if (string.IsNullOrWhiteSpace(HallNumber.Text))
                {
                    MessageBox.Show("Укажите номер зала для книг читального зала!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HallNumber.Focus();
                    return false;
                }

                if (!int.TryParse(HallNumber.Text, out int hall) || hall < 1 || hall > 5)
                {
                    MessageBox.Show("Номер читального зала должен быть числом от 1 до 5!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HallNumber.Focus();
                    return false;
                }

                if (!int.TryParse(RackNumber.Text, out int rack) || rack < 1 || rack > 40)
                {
                    MessageBox.Show("Номер стеллажа должен быть числом от 1 до 40!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RackNumber.Focus();
                    return false;
                }

                if (!int.TryParse(ShelfNumber.Text, out int shelf) || shelf < 1 || shelf > 8)
                {
                    MessageBox.Show("Номер полки должен быть числом от 1 до 8!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShelfNumber.Focus();
                    return false;
                }
            }
            

            if (string.IsNullOrWhiteSpace(Publisher.Text))
            {
                MessageBox.Show("Укажите издательство!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Publisher.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Category.Text))
            {
                MessageBox.Show("Укажите категорию книги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Category.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            string name = AuthorName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя автора!");
                return;
            }

            Book.Authors.Add(name);
            AuthorName.Clear();
            RefreshAuthorsList();
        }

        private void SaveBook_Click(object sender, EventArgs e)
        {

            if (!ValidateForm()) return;

            Book.Title = Title.Text;
            Book.Year = (int)Year.Value;
            Book.Publisher = Publisher.Text;
            Book.Place = Place.Text;
            Book.AvailableCopies = (int)AvailableCopies.Value;
            Book.Category = Category.Text;
            Book.IsForReadingHallOnly = ReadingHallOnly.Checked;
            Book.MaxLoanDays = (int)MaxLoanDays.Value;

            if (Book.IsForReadingHallOnly)
            {
                Book.ReadingHallLocation = new ReadingHallLocation
                {
                    HallNumber = HallNumber.Text,
                    RackNumber = RackNumber.Text,
                    ShelfNumber = ShelfNumber.Text
                };
            }
            else
            {
                Book.ReadingHallLocation = null;
            }
            BookData.AddOrUpdateBook(Book);
            BookData.SaveData();
            MessageBox.Show("Книга успешно добавлена", "Успех",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void RemoveAuthor_Click_1(object sender, EventArgs e)
        {
            if (listBoxAuthors.SelectedItem is string selectedAuthor)
            {
                Book.Authors.Remove(selectedAuthor);
                RefreshAuthorsList();
            }
            else
            {
                MessageBox.Show("Выберите автора для удаления!");
            }
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Category.Text))
            {
                MaxLoanDays.Value = Book.GetLoanDaysByCategory(Category.Text);
            }
        }
    }
}
