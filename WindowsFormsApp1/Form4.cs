using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // звкрытие окна
            Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // добавление данных
            if ((guna2TextBox1.Text == "") || (guna2TextBox2.Text == "") || (guna2TextBox3.Text == ""))
            {
                MessageBox.Show("Заполните ВСЕ поля");
            }
            else
            {
                DataTable data = DbConnection.select(@"INSERT INTO book_info (`book_name`, `book_author`,`book_price`) VALUES ('" + guna2TextBox1.Text + "', '" + guna2TextBox2.Text + "', '" + guna2TextBox3.Text + "');");
                data = DbConnection.select(@"SELECT * FROM book_info");

                guna2TextBox1.Clear();
                guna2TextBox2.Clear();
                guna2TextBox3.Clear();
                data.Columns["id_book"].ColumnName = "Идентификатор";
                data.Columns["book_name"].ColumnName = "Название";
                data.Columns["book_author"].ColumnName = "Автор";
                data.Columns["book_price"].ColumnName = "Цена";
                guna2DataGridView1.DataSource = data;


            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // заполнение данными datagridview
            DataTable data = DbConnection.select("SELECT * FROM `book_info`");
            data.Columns["id_book"].ColumnName = "Идентификатор";
            data.Columns["book_name"].ColumnName = "Название";
            data.Columns["book_author"].ColumnName = "Автор";
            data.Columns["book_price"].ColumnName = "Цена";
            guna2DataGridView1.DataSource = data;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            // сворачивание окна
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            // фильтр
            if (guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Выберите колонку поиска");
            }
            else
            {
                if (guna2ComboBox1.Text == "Идентификатор")
                {
                    string combo_value = "id_book";
                    DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                    data.Columns["id_book"].ColumnName = "Идентификатор";
                    data.Columns["book_name"].ColumnName = "Название";
                    data.Columns["book_author"].ColumnName = "Автор";
                    data.Columns["book_price"].ColumnName = "Цена";
                    guna2DataGridView1.DataSource = data;
                }
                if (guna2ComboBox1.Text == "Название")
                {
                    string combo_value = "book_name";
                    DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                    data.Columns["id_book"].ColumnName = "Идентификатор";
                    data.Columns["book_name"].ColumnName = "Название";
                    data.Columns["book_author"].ColumnName = "Автор";
                    data.Columns["book_price"].ColumnName = "Цена";
                    guna2DataGridView1.DataSource = data;
                }
                if (guna2ComboBox1.Text == "Автор")
                {
                    string combo_value = "book_author";
                    DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                    data.Columns["id_book"].ColumnName = "Идентификатор";
                    data.Columns["book_name"].ColumnName = "Название";
                    data.Columns["book_author"].ColumnName = "Автор";
                    data.Columns["book_price"].ColumnName = "Цена";
                    guna2DataGridView1.DataSource = data;
                }
                if (guna2ComboBox1.Text == "Цена")
                {
                    string combo_value = "book_price";
                    DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                    data.Columns["id_book"].ColumnName = "Идентификатор";
                    data.Columns["book_name"].ColumnName = "Название";
                    data.Columns["book_author"].ColumnName = "Автор";
                    data.Columns["book_price"].ColumnName = "Цена";
                    guna2DataGridView1.DataSource = data;
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // фильтр
            if (guna2ComboBox1.Text == "Идентификатор")
            {
                string combo_value = "id_book";
                DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                data.Columns["id_book"].ColumnName = "Идентификатор";
                data.Columns["book_name"].ColumnName = "Название";
                data.Columns["book_author"].ColumnName = "Автор";
                data.Columns["book_price"].ColumnName = "Цена";
                guna2DataGridView1.DataSource = data;
            }
            if (guna2ComboBox1.Text == "Название")
            {
                string combo_value = "book_name";
                DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                data.Columns["id_book"].ColumnName = "Идентификатор";
                data.Columns["book_name"].ColumnName = "Название";
                data.Columns["book_author"].ColumnName = "Автор";
                data.Columns["book_price"].ColumnName = "Цена";
                guna2DataGridView1.DataSource = data;
            }
            if (guna2ComboBox1.Text == "Автор")
            {
                string combo_value = "book_author";
                DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                data.Columns["id_book"].ColumnName = "Идентификатор";
                data.Columns["book_name"].ColumnName = "Название";
                data.Columns["book_author"].ColumnName = "Автор";
                data.Columns["book_price"].ColumnName = "Цена";
                guna2DataGridView1.DataSource = data;
            }
            if (guna2ComboBox1.Text == "Цена")
            {
                string combo_value = "book_price";
                DataTable data = DbConnection.select(@"SELECT * FROM book_info WHERE " + combo_value + " LIKE '" + "%" + guna2TextBox4.Text + "%" + "';");
                data.Columns["id_book"].ColumnName = "Идентификатор";
                data.Columns["book_name"].ColumnName = "Название";
                data.Columns["book_author"].ColumnName = "Автор";
                data.Columns["book_price"].ColumnName = "Цена";
                guna2DataGridView1.DataSource = data;
            }
        }
    }
}
