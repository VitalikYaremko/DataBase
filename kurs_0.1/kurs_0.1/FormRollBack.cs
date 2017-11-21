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
    public partial class FormRollBack : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public FormRollBack()
        {
            InitializeComponent();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;" +
          @"Data Source=E:\3 курс\1 Симестр\kursova\databases\database_autorize.mdb");
        }
        private void FormRollBack_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select LikarName from Doctor", connection);
            try
            {
                connection.Open();
                da.Fill(dt);
                if (dt != null)
                {
                    string[] mass = new string[dt.Rows.Count];
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        mass[i] = dt.Rows[i]["LikarName"].ToString();
                        comboBox1.Items.Add(mass[i]);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_rb_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Дибас Галина Іванівна")
            {
                try{
                    string user=txt_FName.Text;
                    string user1=txt_LName.Text;
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "delete from Дибас where Прізвище='"+txt_FName.Text+"' and Імя='"+txt_LName.Text+"'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запис користувача "+user+" "+user1+" видалено ");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  
            else if (comboBox1.Text == "Зеляк Роман Ігорович")
            {
               try{
                    string user=txt_FName.Text;
                    string user1=txt_LName.Text;
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "delete from Зеляк where Прізвище='"+txt_FName.Text+"' and Імя='"+txt_LName.Text+"'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запис користувача "+user+" "+user1+" видалено ");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.Text == "Пеля Андріана Романівна")
            {
                try{
                    string user=txt_FName.Text;
                    string user1=txt_LName.Text;
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "delete from Пеля where Прізвище='"+txt_FName.Text+"' and Імя='"+txt_LName.Text+"'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запис користувача "+user+" "+user1+" видалено ");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.Text == "Столяр Петро Миколайович")
            {
                try{
                    string user=txt_FName.Text;
                    string user1=txt_LName.Text;
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "delete from Столяр where Прізвище='"+txt_FName.Text+"' and Імя='"+txt_LName.Text+"'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запис користувача "+user+" "+user1+" видалено ");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.Text == "Рибак Ігор Володимирович")
            {
               try{
                    string user=txt_FName.Text;
                    string user1=txt_LName.Text;
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "delete from Рибак where Прізвище='"+txt_FName.Text+"' and Імя='"+txt_LName.Text+"'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запис користувача "+user+" "+user1+" видалено ");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.Text == "Гук Галина Василівна")
            {
                try{
                    string user=txt_FName.Text;
                    string user1=txt_LName.Text;
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "delete from Гук where Прізвище='"+txt_FName.Text+"' and Імя='"+txt_LName.Text+"'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запис користувача "+user+" "+user1+" видалено ");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
