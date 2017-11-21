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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=E:\3 курс\1 Симестр\kursova\databases\database_autorize.mdb");
            groupBox1.Hide();
            groupBox2.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                label1.Text = "З'єднання з базою даних успішно встановлено !";
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        public string user = "";
        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    string comand = string.Format("Select * From login WHERE user_login=\"" + textBox1.Text + "\""
                        + "AND user_pas=\"" + textBox2.Text + "\"");
                    OleDbCommand check = new OleDbCommand(comand, connection);
                    connection.Open();
                    if (check.ExecuteScalar() != null)
                    {
                        this.Hide();
                        Form3 form3 = new Form3();
                        form3.Show(); 
                    }
                    else
                    {
                        MessageBox.Show("Невірний логін або пороль");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
          }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user = "user";
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog(this); 
        }
      }
 }

