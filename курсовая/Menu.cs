using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace курсовая
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelMenu);
        }

        private void ReadersButton_Click(object sender, EventArgs e)
        {
            RegistrationDate readers = new RegistrationDate();
            readers.WindowState = FormWindowState.Maximized; // Принудительно развернуть

            readers.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip settingsMenu = new ContextMenuStrip();

            // 1. Пункт "Показать читателей"
            ToolStripMenuItem showReadersItem = new ToolStripMenuItem("Показать всех читателей");
            showReadersItem.Click += (s, args) =>
            {
                Form readersForm = new Form()

                {
                    Text = "Список читателей",
                    WindowState = FormWindowState.Maximized
                };

                DataGridView dgv = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    DataSource = LibraryData.Readers,
                    Font = new Font("Microsoft Sans Serif", 16), 
                    RowTemplate = { Height = 35 }, 
                    ColumnHeadersHeight = 50,
                    AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    BackgroundColor = SystemColors.Window
                };

                readersForm.Controls.Add(dgv);
                readersForm.ShowDialog();
            };

            // 2. Пункт "Редактировать читателей"

            ToolStripMenuItem editReadersItem = new ToolStripMenuItem("Редактировать читателей");
            editReadersItem.Click += (s, args) =>
            {
                var findForm = new FindReaderForm(FindReaderForm.FormMode.EditReader)
                {
                    WindowState = FormWindowState.Maximized
                };

                if (findForm.ShowDialog() == DialogResult.OK && findForm.SelectedReader != null)
                {
                    var editForm = new EditReaderForm(findForm.SelectedReader)
                    {
                        WindowState = FormWindowState.Maximized
                    };

                    editForm.ShowDialog();
                }

            };

            settingsMenu.Items.Add(showReadersItem);
            settingsMenu.Items.Add(editReadersItem);

            settingsMenu.Show(SettingsButton, new Point(0, SettingsButton.Height));
        }

        private void catalogButton_Click(object sender, EventArgs e)
        {
            Library catalogForm = new Library();
            catalogForm.WindowState = FormWindowState.Maximized; 
            catalogForm.ShowDialog();
        }

        private void IssueAndReturnButton_Click(object sender, EventArgs e)
        {
            ForUsers catalogForm = new ForUsers();
            catalogForm.WindowState = FormWindowState.Maximized;
            catalogForm.Show();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine("Data", "transactions.json");

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл transactions.json не найден!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonData = File.ReadAllText(filePath);
                var transactions = JsonConvert.DeserializeObject<List<Transaction>>(jsonData);

                Form reportForm = new Form
                {
                    Text = "Отчет по транзакциям",
                    WindowState = FormWindowState.Maximized
                };

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = transactions,
                    Font = new Font("Microsoft Sans Serif", 16), 
                    RowTemplate = { Height = 35 }, 
                    ColumnHeadersHeight = 40,
                    AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells 
                };

                reportForm.Controls.Add(dgv);

                reportForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке отчета: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
   
