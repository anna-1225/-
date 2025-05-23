using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace курсовая
{
    public partial class RegistrationDate : Form
    {
        public RegistrationDate()
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelReadersAdd);

            // Инициализация категорий при загрузке формы
            Category.Items.AddRange(new string[] { "Студент", "ППС", "Сотрудник" });
            Category.SelectedIndex = 0;

            // Скрытие всех панелей при запуске
            panelStudent.Visible = true;
            panelPPS.Visible = false;
            panelEmployee.Visible = false;

            // Установка даты перерегистрации автоматически при изменении даты регистрации
            Registration.ValueChanged += (sender, e) =>
            {
                Reestablish.Value = Registration.Value.AddYears(1);
            };

            Reestablish.Value = Registration.Value.AddYears(1);

            GenerateLibraryCardNumber();
        }

        private void GenerateLibraryCardNumber()
        {
            // Генерация нового уникального номера
            string newNumber;
            do
            {
                Random random = new Random();
                newNumber = $"{DateTime.Now:yyMMdd}-{random.Next(1000, 9999)}";
            }
            while (LibraryData.Readers.Any(r => r.LibraryCardNumber == newNumber));

            LibraryCardNumber.Text = newNumber;
            LibraryCardNumber.ReadOnly = true; 
        }

        private void AddReadersButton_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Номер читательского билета не сгенерирован!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string category = Category.SelectedItem?.ToString() ?? "Студент";

                // Проверка на дубликаты
                bool isDuplicate = LibraryData.Readers.Any(r =>
                    r.tName.Equals(tName.Text, StringComparison.OrdinalIgnoreCase) &&
                    r.LastName.Equals(LastName.Text, StringComparison.OrdinalIgnoreCase) &&
                    r.Surname.Equals(Surname.Text, StringComparison.OrdinalIgnoreCase) &&
                    r.Category == category);

                if (isDuplicate)
                {
                    MessageBox.Show("Такой читатель уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reader newReader;

                switch (category)
                {
                    case "Студент":
                        if (string.IsNullOrWhiteSpace(txtFaculty.Text) || string.IsNullOrWhiteSpace(txtGroup.Text))
                        {
                            MessageBox.Show("Заполните все поля для студента!", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        newReader = new StudentReader
                        {
                            Faculty = txtFaculty.Text,
                            GroupNumber = txtGroup.Text,
                            IsListener = chkListener.Checked
                        };
                        break;

                    case "ППС":
                        if (string.IsNullOrWhiteSpace(txtDepartment.Text) || string.IsNullOrWhiteSpace(txtPosition.Text))
                        {
                            MessageBox.Show("Заполните обязательные поля для ППС!", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        newReader = new TeacherReader
                        {
                            Department = txtDepartment.Text,
                            Position = txtPosition.Text,
                            Degree = txtDegree.Text,
                            Rank = txtRank.Text
                        };
                        break;

                    case "Сотрудник":
                        if (string.IsNullOrWhiteSpace(txtDivision.Text) || string.IsNullOrWhiteSpace(txtEmployeePosition.Text))
                        {
                            MessageBox.Show("Заполните все поля для сотрудника!", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        newReader = new StaffReader
                        {
                            Division = txtDivision.Text,
                            EmployeePosition = txtEmployeePosition.Text
                        };
                        break;

                    default:
                        MessageBox.Show("Неизвестная категория!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                newReader.tName = tName.Text;
                newReader.LastName = LastName.Text;
                newReader.Surname = Surname.Text;
                newReader.Registration = Registration.Value;
                newReader.Reestablish = Registration.Value.AddYears(1);
                newReader.LibraryCardNumber = LibraryCardNumber.Text;
                newReader.Category = category;

                LibraryData.AddReader(newReader);

                MessageBox.Show("Читатель успешно добавлен!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении читателя: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category.SelectedItem == null) return;

            // Сначала скрываем все панели
            panelStudent.Visible = false;
            panelPPS.Visible = false;
            panelEmployee.Visible = false;

            // Показываем нужную панель в зависимости от категории
            switch (Category.SelectedItem.ToString())
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            tName.Text = string.Empty;
            LastName.Text = string.Empty;
            Surname.Text = string.Empty;

            Registration.Value = DateTime.Now;
            Reestablish.Value = DateTime.Now;

            GenerateLibraryCardNumber();

            Category.SelectedIndex = 0;

            if (panelStudent.Visible)
            {
                txtFaculty.Text = string.Empty;
                txtGroup.Text = string.Empty;
                chkListener.Checked = false;
            }
            else if (panelPPS.Visible)
            {
                txtDepartment.Text = string.Empty;
                txtPosition.Text = string.Empty;
                txtDegree.Text = string.Empty;
                txtRank.Text = string.Empty;
            }
            else if (panelEmployee.Visible)
            {
                txtDivision.Text = string.Empty;
                txtEmployeePosition.Text = string.Empty;
            }

            tName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}