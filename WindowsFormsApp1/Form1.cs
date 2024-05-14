using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using db;
using funcs;
using Org.BouncyCastle.Asn1.IsisMtt.Ocsp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // вход в систему
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // проверочный запрос
            DataTable data = DbConnection.select("select * from `sallers` where login = '" + guna2TextBox1.Text + "' and password = '" + guna2TextBox2.Text + "'");
            // проверка на наличие пользователя в бд
            if (data.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли в аккаунт");
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // фокус всех полей
            guna2TextBox1.Focus();
            guna2TextBox2.Focus();
            guna2TextBox1.Focus();
            
        }
    }
}
