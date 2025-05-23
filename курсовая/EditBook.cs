using System;
using System.Drawing;
using System.Windows.Forms;

namespace курсовая
{
    public partial class EditBook : Form
    {
        public Book Book { get; private set; }

        public EditBook(Book book)
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelEditBook);
            Book = book;
            LoadBookData();
            SetupControls();
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

            listBoxAuthors.Items.AddRange(Book.Authors.ToArray());

            if (Book.ReadingHallLocation != null)
            {
                HallNumber.Text = Book.ReadingHallLocation.HallNumber;
                RackNumber.Text = Book.ReadingHallLocation.RackNumber;
                ShelfNumber.Text = Book.ReadingHallLocation.ShelfNumber;
            }
            readingHallPanel.Visible = ReadingHallOnly.Checked;
        }

        private void SetupControls()
        {
            LibraryCode.ReadOnly = true;
            ReadingHallOnly.CheckedChanged += (s, e) =>
                readingHallPanel.Visible = ReadingHallOnly.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveBookData();
                DialogResult = DialogResult.OK;
                Close();
            }
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

            if (AvailableCopies.Value < 0)
            {
                MessageBox.Show("Доступное количество не может быть отрицательным!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AvailableCopies.Focus();
                return false;
            }

            if (MaxLoanDays.Value < 1)
            {
                MessageBox.Show("Максимальный срок выдачи должен быть не менее 1 дня!", "Ошибка",
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
                MessageBox.Show("Укажите издателя!", "Ошибка",
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

        private void SaveBookData()
        {
            Book.Title = Title.Text;
            Book.Year = (int)Year.Value;
            Book.Publisher = Publisher.Text;
            Book.Place = Place.Text;
            Book.AvailableCopies = (int)AvailableCopies.Value;
            Book.Category = Category.Text;
            Book.IsForReadingHallOnly = ReadingHallOnly.Checked;
            Book.MaxLoanDays = (int)MaxLoanDays.Value;

            Book.Authors.Clear();
            foreach (var item in listBoxAuthors.Items)
            {
                Book.Authors.Add(item.ToString());
            }

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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
            MessageBox.Show("Книга успешно отредактирована", "Успех",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }


        private void BCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void AddAuthor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AuthorName.Text))
            {
                listBoxAuthors.Items.Add(AuthorName.Text.Trim());
                AuthorName.Clear();
            }
        }

        private void RemoveAuthor_Click_1(object sender, EventArgs e)
        {
            if (listBoxAuthors.SelectedIndex != -1)
            {
                listBoxAuthors.Items.RemoveAt(listBoxAuthors.SelectedIndex);
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