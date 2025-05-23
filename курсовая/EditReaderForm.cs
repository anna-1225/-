using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая
{
    public partial class EditReaderForm : Form
    {
        private Reader _reader;

        public EditReaderForm(Reader reader)
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelEditReaders);
            _reader = reader;

            // Инициализация категорий
            Category.Items.AddRange(new string[] { "Студент", "ППС", "Сотрудник" });
            FillFormFields();
            ShowCategoryPanel(_reader.Category);
            Category.SelectedIndexChanged += Category_SelectedIndexChanged;
        }

        private void FillFormFields()
        {
            tName.Text = _reader.tName;
            LastName.Text = _reader.LastName;
            Surname.Text = _reader.Surname;
            Registration.Value = _reader.Registration;
            Reestablish.Value = _reader.Reestablish;
            LibraryCardNumber.Text = _reader.LibraryCardNumber;
            Category.SelectedItem = _reader.Category;

            // Заполнение данных в зависимости от категории
            switch (_reader.Category)
            {
                case "Студент":
                    if (_reader is StudentReader student)
                    {
                        txtFaculty.Text = student.Faculty;
                        txtGroup.Text = student.GroupNumber;
                        chkListener.Checked = student.IsListener;
                    }
                    break;

                case "ППС":
                    if (_reader is TeacherReader teacher)
                    {
                        txtDepartment.Text = teacher.Department;
                        txtPosition.Text = teacher.Position;
                        txtDegree.Text = teacher.Degree;
                        txtRank.Text = teacher.Rank;
                    }
                    break;

                case "Сотрудник":
                    if (_reader is StaffReader staff)
                    {
                        txtDivision.Text = staff.Division;
                        txtEmployeePosition.Text = staff.EmployeePosition;
                    }
                    break;
            }
        }

        private void ShowCategoryPanel(string category)
        {
            panelStudent.Visible = false;
            panelPPS.Visible = false;
            panelEmployee.Visible = false;

            switch (category)
            {
                case "Студент":
                    panelStudent.Visible = true;
                    break;
                case "ППС":
                    panelPPS.Visible = true;
                    break;
                case "Сотрудник":
                    panelEmployee.Visible = true;
                    break;
            }
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category.SelectedItem == null) return;
            ShowCategoryPanel(Category.SelectedItem.ToString());
        }
        private void ReturnAllBorrowedBooks(string libraryCardNumber)
        {
            try
            {
                var activeTransactions = TransactionData.GetActiveTransactionsByReader(libraryCardNumber);

                foreach (var transaction in activeTransactions)
                {
                    var book = BookData.GetBookByCode(transaction.BookLibraryCode);
                    if (book != null)
                    {
                        book.AvailableCopies++;
                        book.IsAvailable = book.AvailableCopies > 0;
                        BookData.AddOrUpdateBook(book);
                    }
                    transaction.ReturnDate = DateTime.Today;
                }

                TransactionData.SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при возврате книг: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_reader.LibraryCardNumber))
                {
                    MessageBox.Show("Нельзя удалить читателя без номера билета!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var borrowedBooks = TransactionData.GetBorrowedBooksByReader(_reader.LibraryCardNumber);
                bool hasBooks = borrowedBooks.Any();

                var result = MessageBox.Show($"Вы уверены, что хотите удалить читателя с номером билета {_reader.LibraryCardNumber}?" +
                                           (hasBooks ? "\nВсе взятые им книги будут возвращены в библиотеку." : ""),
                                           "Подтверждение удаления",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Возвращаем все книги перед удалением
                    if (hasBooks)
                    {
                        ReturnAllBorrowedBooks(_reader.LibraryCardNumber);
                    }

                    bool deleted = LibraryData.RemoveReader(_reader.LibraryCardNumber);
                    if (deleted)
                    {
                        MessageBox.Show("Читатель успешно удален!" +
                                       (hasBooks ? "\nВсе взятые книги были возвращены в библиотеку." : ""),
                                       "Успех",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Читатель с указанным номером билета не найден!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении читателя: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tName.Text) ||
                    string.IsNullOrWhiteSpace(LastName.Text) ||
                    string.IsNullOrWhiteSpace(Surname.Text))
                {
                    MessageBox.Show("Заполните все поля ФИО читателя!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(LibraryCardNumber.Text))
                {
                    MessageBox.Show("Номер читательского билета отсутствует!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Category.SelectedItem == null)
                {
                    MessageBox.Show("Выберите категорию читателя!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string category = Category.SelectedItem.ToString();

                switch (category)
                {
                    case "Студент":
                        if (string.IsNullOrWhiteSpace(txtFaculty.Text) ||
                            string.IsNullOrWhiteSpace(txtGroup.Text))
                        {
                            MessageBox.Show("Заполните все поля для студента!", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;

                    case "ППС":
                        if (string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                            string.IsNullOrWhiteSpace(txtPosition.Text))
                        {
                            MessageBox.Show("Заполните обязательные поля для ППС!", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;

                    case "Сотрудник":
                        if (string.IsNullOrWhiteSpace(txtDivision.Text) ||
                            string.IsNullOrWhiteSpace(txtEmployeePosition.Text))
                        {
                            MessageBox.Show("Заполните все поля для сотрудника!", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                }

                _reader.tName = tName.Text;
                _reader.LastName = LastName.Text;
                _reader.Surname = Surname.Text;
                _reader.Registration = Registration.Value;
                _reader.Reestablish = Reestablish.Value;
                _reader.LibraryCardNumber = LibraryCardNumber.Text;
                _reader.Category = category;

                switch (category)
                {
                    case "Студент":
                        if (_reader is StudentReader student)
                        {
                            txtFaculty.Text = student.Faculty;
                            txtGroup.Text = student.GroupNumber;
                            chkListener.Checked = student.IsListener;
                        }
                        break;

                    case "ППС":
                        if (_reader is TeacherReader teacher)
                        {
                            txtDepartment.Text = teacher.Department;
                            txtPosition.Text = teacher.Position;
                            txtDegree.Text = teacher.Degree;
                            txtRank.Text = teacher.Rank;
                        }
                        break;

                    case "Сотрудник":
                        if (_reader is StaffReader staff)
                        {
                            txtDivision.Text = staff.Division;
                            txtEmployeePosition.Text = staff.EmployeePosition;
                        }
                        break;
                }

                LibraryData.SaveData();

                MessageBox.Show("Данные читателя успешно обновлены!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}