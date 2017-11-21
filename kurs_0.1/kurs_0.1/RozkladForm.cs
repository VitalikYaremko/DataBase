using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace kurs_0._1
{
    public partial class RozkladForm : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public RozkladForm()
        {
            InitializeComponent();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;" +
          @"Data Source=E:\3 курс\1 Симестр\kursova\databases\database_autorize.mdb");
        }

        private void RozkladForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select Код,Лікар,Спеціаліст,Кабінет,Пн,Вт,Ср,Чт,Пт,Сб,Нд from Розклад";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
