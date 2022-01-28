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
    public partial class FormMain : Form
    {
        FormAddNewGood formadd;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAddNewGood_Click(object sender, EventArgs e)
        {
            formadd = new FormAddNewGood(this);
            this.Hide();
            formadd.Show();
        }

        public void AddGood(Good g)
        {
            int row = dataGridView1.Rows.Add();
            dataGridView1.Rows[row].Cells["GoodName1"].Value = g.name;
            dataGridView1.Rows[row].Cells["Present"].Value = g.present;
        }
    }
}
