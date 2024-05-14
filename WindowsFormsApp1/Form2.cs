using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using db;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // показ формы клиентов
            Form3 f3 = new Form3();
            f3.Show();
            //Hide();
            DataTable data = DbConnection.select("SELECT * FROM `sallers`");

        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // показ формы с книгами
            Form4 f4 = new Form4();
            f4.Show();
            //Hide();
            DataTable data = DbConnection.select("SELECT * FROM `book_info`");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // выход из программы
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // сворачивание окна
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
