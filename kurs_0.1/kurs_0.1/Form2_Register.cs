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
    public partial class Form2_Register : Form
    {
        
        OleDbConnection connection = new OleDbConnection();
        public Form2_Register()
        {
            InitializeComponent();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;" +
           @"Data Source=E:\3 курс\1 Симестр\kursova\databases\database_autorize.mdb");
            ComboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            
        }

        public string doctor="";
        public string timebtn = "";
        public string date = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 frmFirst = this.Owner as Form3;
            if (frmFirst != null) {
                doctor = frmFirst.doctor;
                timebtn = frmFirst.timebtn;
                date = frmFirst.date;
            }

            for (int i = 2000; i <= 2016; i++)
            {
                ComboYear.Items.Add(i);
            }  
        }
        
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (doctor == "Таран")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    if (txt_LName.Text != "" && txt_FName.Text != "" && txt_Batkovi.Text != "" && ComboYear.Text != "" && txt_Number.Text!="")
                    {

                        command.CommandText = "insert into Таран (Дата,Час,Прізвище,Імя,ПоБатькові,РікНародження,НомерТелефону) values('" + date +
             "','" + timebtn + "','" + txt_LName.Text + "','" + txt_FName.Text + "','" + txt_Batkovi.Text
             + "','" + ComboYear.Text + "','" + txt_Number.Text + "')";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration OK!");
                        this.Hide();
                        MessageBox.Show("Дата " + date + "\nЧас " + timebtn + "\nЛікар: Таран Інна Мирославівна \nНомер телефону: 3806545986 \nКабінет №4", "Талон");
                        Form1 frm1 = new Form1();
                        frm1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Заповніть будь-ласка всі поля! ");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
            else if (doctor == "Чернявська")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    if (txt_LName.Text != "" && txt_FName.Text != "" && txt_Batkovi.Text != "" && ComboYear.Text != "" && txt_Number.Text != "")
                    {

                        command.CommandText = "insert into Чернявська (Дата,Час,Прізвище,Імя,ПоБатькові,РікНародження,НомерТелефону) values('" + date +
             "','" + timebtn + "','" + txt_LName.Text + "','" + txt_FName.Text + "','" + txt_Batkovi.Text
             + "','" + ComboYear.Text + "','" + txt_Number.Text + "')";

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration OK!");

                        this.Hide();

                        MessageBox.Show("Дата " + date + "\nЧас " + timebtn + "\nЛікар: Чернявська Ольга Петрівна \nНомер телефону: 3806548795 \nКабінет №5 ", "Талон");
                        Form1 frm1 = new Form1();
                        frm1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Заповніть будь-ласка всі поля! ");
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
            else if (doctor == "Шникарук")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    if (txt_LName.Text != "" && txt_FName.Text != "" && txt_Batkovi.Text != "" && ComboYear.Text != "" && txt_Number.Text != "")
                    {

                        command.CommandText = "insert into Шникарук (Дата,Час,Прізвище,Імя,ПоБатькові,РікНародження,НомерТелефону) values('" + date +
             "','" + timebtn + "','" + txt_LName.Text + "','" + txt_FName.Text + "','" + txt_Batkovi.Text
             + "','" + ComboYear.Text + "','" + txt_Number.Text + "')";

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration OK!");

                        this.Hide();

                        MessageBox.Show("Дата " + date + "\nЧас " + timebtn + "\nЛікар: Шникарук Лариса Георгіївна \nНомер телефону: 3805052365\nКабінет №6 ", "Талон");
                        Form1 frm1 = new Form1();
                        frm1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Заповніть будь-ласка всі поля! ");
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
            else if (doctor == "Лавкай")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    if (txt_LName.Text != "" && txt_FName.Text != "" && txt_Batkovi.Text != "" && ComboYear.Text != "" && txt_Number.Text != "")
                    {

                        command.CommandText = "insert into Лавкай (Дата,Час,Прізвище,Імя,ПоБатькові,РікНародження,НомерТелефону) values('" + date +
             "','" + timebtn + "','" + txt_LName.Text + "','" + txt_FName.Text + "','" + txt_Batkovi.Text
             + "','" + ComboYear.Text + "','" + txt_Number.Text + "')";

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration OK!");

                        this.Hide();

                        MessageBox.Show("Дата " + date + "\nЧас " + timebtn + "\nЛікар: Лавкай Тетяна Іванівна\nНомер телефону: 3809523654\nКабінет №6 ", "Талон");
                        Form1 frm1 = new Form1();
                        frm1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Заповніть будь-ласка всі поля! ");
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
            else if (doctor == "Какуріна")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    if (txt_LName.Text != "" && txt_FName.Text != "" && txt_Batkovi.Text != "" && ComboYear.Text != "" && txt_Number.Text != "")
                    {

                        command.CommandText = "insert into Какуріна Маріанна Михайлівна (Дата,Час,Прізвище,Імя,ПоБатькові,РікНародження,НомерТелефону) values('" + date +
             "','" + timebtn + "','" + txt_LName.Text + "','" + txt_FName.Text + "','" + txt_Batkovi.Text
             + "','" + ComboYear.Text + "','" + txt_Number.Text + "')";

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration OK!");

                        this.Hide();

                        MessageBox.Show("Дата " + date + "\nЧас " + timebtn + "\nЛікар: Какуріна Маріанна Михайлівна\nНомер телефону: 3809547852\nКабінет №7 ", "Талон");
                        Form1 frm1 = new Form1();
                        frm1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Заповніть будь-ласка всі поля! ");
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }

            else if (doctor == "Шеверя")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    if (txt_LName.Text != "" && txt_FName.Text != "" && txt_Batkovi.Text != "" && ComboYear.Text != "" && txt_Number.Text != "")
                    {

                        command.CommandText = "insert into Столяр (Дата,Час,Прізвище,Імя,ПоБатькові,РікНародження,НомерТелефону) values('" + date +
             "','" + timebtn + "','" + txt_LName.Text + "','" + txt_FName.Text + "','" + txt_Batkovi.Text
             + "','" + ComboYear.Text + "','" + txt_Number.Text + "')";

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration OK!");

                        this.Hide();

                        MessageBox.Show("Дата " + date + "\nЧас " + timebtn + "\nЛікар: Шеверя Світлана Юріївна\nНомер телефону: 3802006547\nКабінет №12 ", "Талон");
                        Form1 frm1 = new Form1();
                        frm1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Заповніть будь-ласка всі поля! ");
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
        }
        private void Form2_Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
