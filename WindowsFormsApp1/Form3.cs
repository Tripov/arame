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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // заполнение datagridview
            DataTable data = DbConnection.select("SELECT * FROM `sallers`");
            guna2DataGridView1.DataSource = data;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // закрытие окна
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // сворачивание окна
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
