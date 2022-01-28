using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Senya
{
    public partial class FormAddNewGood : Form
    {
        FormMain formmain;
        public FormAddNewGood(FormMain form)
        {
            InitializeComponent();
            formmain = form;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы не указали название товара!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Good g = new Good();
            g.name = textBoxName.Text;
            g.present = checkBoxPresent.Checked;

            formmain.AddGood(g);

            formmain.Show();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            formmain.Show();
            this.Close();
        }
    }
}
