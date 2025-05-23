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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
            ControlHelper.CenterControl(panelLibrary);
        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            AddEditBookForm catalogForm = new AddEditBookForm();
            catalogForm.WindowState = FormWindowState.Maximized;
            catalogForm.Show();
        }

        private void EditBooks_Click(object sender, EventArgs e)
        {
            BookSearch catalogForm = new BookSearch();
            catalogForm.WindowState = FormWindowState.Maximized;

            catalogForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
