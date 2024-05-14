using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{

    class DbConnection
    {
        public static DataTable select(string sql)
        {
            // создание соединения с БД
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "cfif31.ru";
            builder.Port = 3306;
            builder.Database = "ISPr24-40_GabrielanAA_pz";
            builder.UserID = "ISPr24-40_GabrielyanAA";
            builder.Password = "ISPr24-40_GabrielyanAA";
            // соединение
            MySqlConnection connect = new MySqlConnection(builder.ConnectionString);
            // создание запроса
            try
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand(sql, connect);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;

            }
            catch (Exception e)
            {
                MessageBox.Show("При выполнении запроса произошла ошибка! " + e.Message);
                return null;
            }
        }
    }
}
