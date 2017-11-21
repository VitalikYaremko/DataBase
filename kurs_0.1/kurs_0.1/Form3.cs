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
    public partial class Form3 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;" +
           @"Data Source=E:\3 курс\1 Симестр\kursova\databases\database_autorize.mdb");
            dateTimePicker1.MinDate = DateTime.Today;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            
        }

        public string user="";

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 frm = this.Owner as Form1;

            if (frm!= null)
            {
                user = frm.user;
            }
            if (user =="user")
            {
                btn_rollback.Enabled = false;
            }
            else if (user == "")
            {
                btn_rollback.Enabled = true;
            }

            button1.Enabled = false;
            groupBox1.Hide();
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
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


        public string date = "";
        public string doctor = "";
        public string time = "";
        public string timebtn = "";
     

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            if (comboBox1.Text == "Таран Інна Мирославівна")
            {
                doctor = "Таран";
                DataTable dtDoc = new DataTable();
                OleDbDataAdapter daDoc = new OleDbDataAdapter("select РікНародження,Спеціальність,Стаж,НомерТелефону from Doctor", connection);
                try 
                {
                    connection.Open();
                    daDoc.Fill(dtDoc);
                    if (dtDoc != null)
                    {
                        txt_year.Text = dtDoc.Rows[0]["РікНародження"].ToString();
                        txt_spec.Text = dtDoc.Rows[0]["Спеціальність"].ToString();
                        txt_stag.Text = dtDoc.Rows[0]["Стаж"].ToString();
                        txt_nubertel.Text = dtDoc.Rows[0]["НомерТелефону"].ToString();
                    }
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select Дата,Час from Таран", connection);
                int count = 10;
                try
                {
                   
                    connection.Open();
                    da.Fill(dt);
                    string[] TimeMass = new string[dt.Rows.Count];
                    if (dt != null)
                    {
                        
                        string[] mass = new string[dt.Rows.Count];
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            mass[i] = dt.Rows[i]["Дата"].ToString();
                            if(mass[i]==date)
                            {
                                count--;
                                TimeMass[i] = dt.Rows[i]["Час"].ToString();
                            }
                        }
                    }    
                    connection.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (TimeMass[i] == "08:00") { button_0800.Enabled = false; }
                        else if (TimeMass[i] == "08:30") { button_0830.Enabled = false; }
                        else if (TimeMass[i] == "09:00") { button_0900.Enabled = false; }
                        else if (TimeMass[i] == "09:30") { button_0930.Enabled = false; }
                        else if (TimeMass[i] == "10:00") { button1000.Enabled = false; }
                        else if (TimeMass[i] == "10:30") { button1030.Enabled = false; }
                        else if (TimeMass[i] == "11:00") { button1100.Enabled = false; }
                        else if (TimeMass[i] == "11:30") { button1130.Enabled = false; }
                        else if (TimeMass[i] == "12:00") { button1200.Enabled = false; }
                        else if (TimeMass[i] == "12:30") { button1230.Enabled = false; }
                        else if (TimeMass[i] == "13:00") { button1300.Enabled = false; }
                        else if (TimeMass[i] == "13:30") { button1330.Enabled = false; }
                        else if (TimeMass[i] == "14:00") { button1400.Enabled = false; }
                        else if (TimeMass[i] == "14:30") { button1430.Enabled = false; }
                        else if (TimeMass[i] == "15:00") { button_1500.Enabled = false; }
                        else if (TimeMass[i] == "15:30") { button_1530.Enabled = false; }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }

            else if (comboBox1.Text == "Чернявська Ольга Петрівна")
            {
                doctor = "Чернявська";

                DataTable dtDoc = new DataTable();
                OleDbDataAdapter daDoc = new OleDbDataAdapter("select РікНародження,Спеціальність,Стаж,НомерТелефону from Doctor", connection);
                try
                {
                    connection.Open();
                    daDoc.Fill(dtDoc);
                    if (dtDoc != null)
                    {
                        txt_year.Text = dtDoc.Rows[1]["РікНародження"].ToString();
                        txt_spec.Text = dtDoc.Rows[1]["Спеціальність"].ToString();
                        txt_stag.Text = dtDoc.Rows[1]["Стаж"].ToString();
                        txt_nubertel.Text = dtDoc.Rows[1]["НомерТелефону"].ToString();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select Дата,Час from Чернявська", connection);
                int count = 10;
                try
                {
                    
                    connection.Open();
                    da.Fill(dt);
                    string[] TimeMass = new string[dt.Rows.Count];
                    if (dt != null)
                    {
                        
                        string[] mass = new string[dt.Rows.Count];
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            mass[i] = dt.Rows[i]["Дата"].ToString();
                            if (mass[i] == date)
                            {
                                count--;
                                TimeMass[i] = dt.Rows[i]["Час"].ToString();
                            }
                        }
                    }
                    connection.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (TimeMass[i] == "08:00") { button_0800.Enabled = false; }
                        else if (TimeMass[i] == "08:30") { button_0830.Enabled = false; }
                        else if (TimeMass[i] == "09:00") { button_0900.Enabled = false; }
                        else if (TimeMass[i] == "09:30") { button_0930.Enabled = false; }
                        else if (TimeMass[i] == "10:00") { button1000.Enabled = false; }
                        else if (TimeMass[i] == "10:30") { button1030.Enabled = false; }
                        else if (TimeMass[i] == "11:00") { button1100.Enabled = false; }
                        else if (TimeMass[i] == "11:30") { button1130.Enabled = false; }
                        else if (TimeMass[i] == "12:00") { button1200.Enabled = false; }
                        else if (TimeMass[i] == "12:30") { button1230.Enabled = false; }
                        else if (TimeMass[i] == "13:00") { button1300.Enabled = false; }
                        else if (TimeMass[i] == "13:30") { button1330.Enabled = false; }
                        else if (TimeMass[i] == "14:00") { button1400.Enabled = false; }
                        else if (TimeMass[i] == "14:30") { button1430.Enabled = false; }
                        else if (TimeMass[i] == "15:00") { button_1500.Enabled = false; }
                        else if (TimeMass[i] == "15:30") { button_1530.Enabled = false; }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (comboBox1.Text == "Шникарук Лариса Георгіївна")
            {
                doctor = "Шникарук";
                DataTable dtDoc = new DataTable();
                OleDbDataAdapter daDoc = new OleDbDataAdapter("select РікНародження,Спеціальність,Стаж,НомерТелефону from Doctor", connection);
                try
                {
                    connection.Open();
                    daDoc.Fill(dtDoc);
                    if (dtDoc != null)
                    {
                        txt_year.Text = dtDoc.Rows[2]["РікНародження"].ToString();
                        txt_spec.Text = dtDoc.Rows[2]["Спеціальність"].ToString();
                        txt_stag.Text = dtDoc.Rows[2]["Стаж"].ToString();
                        txt_nubertel.Text = dtDoc.Rows[2]["НомерТелефону"].ToString();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select Дата,Час from Шникарук", connection);
                int count = 10;
                try
                {
                  
                    connection.Open();
                    da.Fill(dt);
                    string[] TimeMass = new string[dt.Rows.Count];
                    if (dt != null)
                    {
                        string[] mass = new string[dt.Rows.Count];
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            mass[i] = dt.Rows[i]["Дата"].ToString();
                            if (mass[i] == date)
                            {
                                count--;
                                TimeMass[i] = dt.Rows[i]["Час"].ToString();
                            }
                        }
                    }
                    connection.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (TimeMass[i] == "08:00") { button_0800.Enabled = false; }
                        else if (TimeMass[i] == "08:30") { button_0830.Enabled = false; }
                        else if (TimeMass[i] == "09:00") { button_0900.Enabled = false; }
                        else if (TimeMass[i] == "09:30") { button_0930.Enabled = false; }
                        else if (TimeMass[i] == "10:00") { button1000.Enabled = false; }
                        else if (TimeMass[i] == "10:30") { button1030.Enabled = false; }
                        else if (TimeMass[i] == "11:00") { button1100.Enabled = false; }
                        else if (TimeMass[i] == "11:30") { button1130.Enabled = false; }
                        else if (TimeMass[i] == "12:00") { button1200.Enabled = false; }
                        else if (TimeMass[i] == "12:30") { button1230.Enabled = false; }
                        else if (TimeMass[i] == "13:00") { button1300.Enabled = false; }
                        else if (TimeMass[i] == "13:30") { button1330.Enabled = false; }
                        else if (TimeMass[i] == "14:00") { button1400.Enabled = false; }
                        else if (TimeMass[i] == "14:30") { button1430.Enabled = false; }
                        else if (TimeMass[i] == "15:00") { button_1500.Enabled = false; }
                        else if (TimeMass[i] == "15:30") { button_1530.Enabled = false; }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (comboBox1.Text == "Лавкай Тетяна Іванівна")
            {
                doctor = "Лавкай";
                DataTable dtDoc = new DataTable();
                OleDbDataAdapter daDoc = new OleDbDataAdapter("select РікНародження,Спеціальність,Стаж,НомерТелефону from Doctor", connection);
                try
                {
                    connection.Open();
                    daDoc.Fill(dtDoc);
                    if (dtDoc != null)
                    {
                        txt_year.Text = dtDoc.Rows[3]["РікНародження"].ToString();
                        txt_spec.Text = dtDoc.Rows[3]["Спеціальність"].ToString();
                        txt_stag.Text = dtDoc.Rows[3]["Стаж"].ToString();
                        txt_nubertel.Text = dtDoc.Rows[3]["НомерТелефону"].ToString();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select Дата,Час from Лавкай", connection);
                int count = 10;
                try
                {
                    connection.Open();
                    da.Fill(dt);
                    string[] TimeMass = new string[dt.Rows.Count];
                    if (dt != null)
                    {
                        string[] mass = new string[dt.Rows.Count];
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            mass[i] = dt.Rows[i]["Дата"].ToString();
                            if (mass[i] == date)
                            {
                                count--;
                                TimeMass[i] = dt.Rows[i]["Час"].ToString();
                            }
                        }
                    }
                    connection.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (TimeMass[i] == "08:00") { button_0800.Enabled = false; }
                        else if (TimeMass[i] == "08:30") { button_0830.Enabled = false; }
                        else if (TimeMass[i] == "09:00") { button_0900.Enabled = false; }
                        else if (TimeMass[i] == "09:30") { button_0930.Enabled = false; }
                        else if (TimeMass[i] == "10:00") { button1000.Enabled = false; }
                        else if (TimeMass[i] == "10:30") { button1030.Enabled = false; }
                        else if (TimeMass[i] == "11:00") { button1100.Enabled = false; }
                        else if (TimeMass[i] == "11:30") { button1130.Enabled = false; }
                        else if (TimeMass[i] == "12:00") { button1200.Enabled = false; }
                        else if (TimeMass[i] == "12:30") { button1230.Enabled = false; }
                        else if (TimeMass[i] == "13:00") { button1300.Enabled = false; }
                        else if (TimeMass[i] == "13:30") { button1330.Enabled = false; }
                        else if (TimeMass[i] == "14:00") { button1400.Enabled = false; }
                        else if (TimeMass[i] == "14:30") { button1430.Enabled = false; }
                        else if (TimeMass[i] == "15:00") { button_1500.Enabled = false; }
                        else if (TimeMass[i] == "15:30") { button_1530.Enabled = false; }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            else if (comboBox1.Text == "Какуріна Маріанна Михайлівна")
            {
                doctor = "Какуріна";
                DataTable dtDoc = new DataTable();
                OleDbDataAdapter daDoc = new OleDbDataAdapter("select РікНародження,Спеціальність,Стаж,НомерТелефону from Doctor", connection);
                try
                {
                    connection.Open();
                    daDoc.Fill(dtDoc);
                    if (dtDoc != null)
                    {
                        txt_year.Text = dtDoc.Rows[4]["РікНародження"].ToString();
                        txt_spec.Text = dtDoc.Rows[4]["Спеціальність"].ToString();
                        txt_stag.Text = dtDoc.Rows[4]["Стаж"].ToString();
                        txt_nubertel.Text = dtDoc.Rows[4]["НомерТелефону"].ToString();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select Дата,Час from Какуріна", connection);
                int count = 10;
                try
                {
                    connection.Open();
                    da.Fill(dt);
                    string[] TimeMass = new string[dt.Rows.Count];
                    if (dt != null)
                    {
                        string[] mass = new string[dt.Rows.Count];
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            mass[i] = dt.Rows[i]["Дата"].ToString();
                            if (mass[i] == date)
                            {
                                count--;
                                TimeMass[i] = dt.Rows[i]["Час"].ToString();
                            }
                        }
                    }
                    connection.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (TimeMass[i] == "08:00") { button_0800.Enabled = false; }
                        else if (TimeMass[i] == "08:30") { button_0830.Enabled = false; }
                        else if (TimeMass[i] == "09:00") { button_0900.Enabled = false; }
                        else if (TimeMass[i] == "09:30") { button_0930.Enabled = false; }
                        else if (TimeMass[i] == "10:00") { button1000.Enabled = false; }
                        else if (TimeMass[i] == "10:30") { button1030.Enabled = false; }
                        else if (TimeMass[i] == "11:00") { button1100.Enabled = false; }
                        else if (TimeMass[i] == "11:30") { button1130.Enabled = false; }
                        else if (TimeMass[i] == "12:00") { button1200.Enabled = false; }
                        else if (TimeMass[i] == "12:30") { button1230.Enabled = false; }
                        else if (TimeMass[i] == "13:00") { button1300.Enabled = false; }
                        else if (TimeMass[i] == "13:30") { button1330.Enabled = false; }
                        else if (TimeMass[i] == "14:00") { button1400.Enabled = false; }
                        else if (TimeMass[i] == "14:30") { button1430.Enabled = false; }
                        else if (TimeMass[i] == "15:00") { button_1500.Enabled = false; }
                        else if (TimeMass[i] == "15:30") { button_1530.Enabled = false; }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.Text == "Шеверя Світлана Юріївна")
            {
                doctor = "Шеверя";
                DataTable dtDoc = new DataTable();
                OleDbDataAdapter daDoc = new OleDbDataAdapter("select РікНародження,Спеціальність,Стаж,НомерТелефону from Doctor", connection);
                try
                {
                    connection.Open();
                    daDoc.Fill(dtDoc);
                    if (dtDoc != null)
                    {
                        txt_year.Text = dtDoc.Rows[5]["РікНародження"].ToString();
                        txt_spec.Text = dtDoc.Rows[5]["Спеціальність"].ToString();
                        txt_stag.Text = dtDoc.Rows[5]["Стаж"].ToString();
                        txt_nubertel.Text = dtDoc.Rows[5]["НомерТелефону"].ToString();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select Дата,Час from Шеверя", connection);
                int count = 10;
                try
                {
                    connection.Open();
                    da.Fill(dt);
                    string[] TimeMass = new string[dt.Rows.Count];
                    if (dt != null)
                    {
                        string[] mass = new string[dt.Rows.Count];
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            mass[i] = dt.Rows[i]["Дата"].ToString();
                            if (mass[i] == date)
                            {
                                count--;
                                TimeMass[i] = dt.Rows[i]["Час"].ToString();
                            }
                        }
                    }
                    connection.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                             if (TimeMass[i] == "08:00") {  button_0800.Enabled = false; }
                        else if (TimeMass[i] == "08:30") {  button_0830.Enabled = false; }
                        else if (TimeMass[i] == "09:00") {  button_0900.Enabled = false; }
                        else if (TimeMass[i] == "09:30") {  button_0930.Enabled = false; }
                        else if (TimeMass[i] == "10:00") {  button1000.Enabled = false; }
                        else if (TimeMass[i] == "10:30") {  button1030.Enabled = false; }
                        else if (TimeMass[i] == "11:00") {  button1100.Enabled = false; }
                        else if (TimeMass[i] == "11:30") {  button1130.Enabled = false; }
                        else if (TimeMass[i] == "12:00") {  button1200.Enabled = false; }
                        else if (TimeMass[i] == "12:30") {  button1230.Enabled = false; }
                        else if (TimeMass[i] == "13:00") {  button1300.Enabled = false; }
                        else if (TimeMass[i] == "13:30") {  button1330.Enabled = false; }
                        else if (TimeMass[i] == "14:00") {  button1400.Enabled = false; }
                        else if (TimeMass[i] == "14:30") {  button1430.Enabled = false; }
                        else if (TimeMass[i] == "15:00") {  button_1500.Enabled = false; }
                        else if (TimeMass[i] == "15:30") {  button_1530.Enabled = false; }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            if (comboBox1.Text == "Таран Інна Мирославівна")
            {
                 if(day=="Monday")
                 {
                      button_0800.Enabled = true;
                      button_0830.Enabled = true;
                      button_0900.Enabled = true;
                      button_0930.Enabled = true;
                      button1000.Enabled = true;
                      button1030.Enabled = true;
                      button1100.Enabled = true;
                      button1130.Enabled = true;
                      button1200.Enabled = true;
                      button1230.Enabled = true;
                      button1300.Enabled = true;
                      button1330.Enabled = true;
 
                      button1400.Enabled = false; 
                      button1430.Enabled = false; 
                      button_1500.Enabled = false; 
                      button_1530.Enabled = false; 
                 }            //понеділок
                 else if(day=="Tuesday")
                 {
                     button_0800.Enabled = true;
                     button_0830.Enabled = true;
                     button_0900.Enabled = true;
                     button_0930.Enabled = true;
                     button1000.Enabled = true;
                     button1030.Enabled = true;
                     button1100.Enabled = true;
                     button1130.Enabled = true;
                     button1200.Enabled = true;
                     button1230.Enabled = true;
                     button1300.Enabled = true;
                     button1330.Enabled = true;

                     button1400.Enabled = false;
                     button1430.Enabled = false;
                     button_1500.Enabled = false;
                     button_1530.Enabled = false; 
                 }      //вівторок
                 else if(day=="Wednesday")
                 {
                     button_0800.Enabled = true;
                     button_0830.Enabled = true;
                     button_0900.Enabled = true;
                     button_0930.Enabled = true;
                     button1000.Enabled = true;
                     button1030.Enabled = true;
                     button1100.Enabled = true;
                     button1130.Enabled = true;
                     button1200.Enabled = true;
                     button1230.Enabled = true;
                     button1300.Enabled = true;
                     button1330.Enabled = true;

                     button1400.Enabled = false;
                     button1430.Enabled = false;
                     button_1500.Enabled = false;
                     button_1530.Enabled = false; 
                 }        //середа
                 else if(day=="Thursday")
                 {
                     button_0800.Enabled = true;
                     button_0830.Enabled = true;
                     button_0900.Enabled = true;
                     button_0930.Enabled = true;
                     button1000.Enabled = true;
                     button1030.Enabled = true;
                     button1100.Enabled = true;
                     button1130.Enabled = true;
                     button1200.Enabled = true;
                     button1230.Enabled = true;
                     button1300.Enabled = true;
                     button1330.Enabled = true;

                     button1400.Enabled = false;
                     button1430.Enabled = false;
                     button_1500.Enabled = false;
                     button_1530.Enabled = false; 

                 }     //четвер
                 else if (day == "Friday") 
                 {
                     button_0800.Enabled = true;
                     button_0830.Enabled = true;
                     button_0900.Enabled = true;
                     button_0930.Enabled = true;
                     button1000.Enabled = true;
                     button1030.Enabled = true;
                     button1100.Enabled = true;
                     button1130.Enabled = true;
                     button1200.Enabled = true;
                     button1230.Enabled = true;
                     button1300.Enabled = true;
                     button1330.Enabled = true;

                     button1400.Enabled = false;
                     button1430.Enabled = false;
                     button_1500.Enabled = false;
                     button_1530.Enabled = false; 
                 }      //пятниця
                 else if (day == "Saturday")
                 {
                     button_0800.Enabled = false;
                     button_0830.Enabled = false;
                     button_0900.Enabled = false;
                     button_0930.Enabled = false;
                     button1000.Enabled = false;
                     button1030.Enabled = false;
                     button1100.Enabled = false;
                     button1130.Enabled = false;
                     button1200.Enabled = false;
                     button1230.Enabled = false;
                     button1300.Enabled = false;
                     button1330.Enabled = false;
                     button1400.Enabled = false;
                     button1430.Enabled = false;
                     button_1500.Enabled = false;
                     button_1530.Enabled = false; 
                 } //субота 
                 else if (day == "Sunday")
                 {
                     button_0800.Enabled = false;
                     button_0830.Enabled = false;
                     button_0900.Enabled = false;
                     button_0930.Enabled = false;
                     button1000.Enabled = false;
                     button1030.Enabled = false;
                     button1100.Enabled = false;
                     button1130.Enabled = false;
                     button1200.Enabled = false;
                     button1230.Enabled = false;
                     button1300.Enabled = false;
                     button1330.Enabled = false;
                     button1400.Enabled = false;
                     button1430.Enabled = false;
                     button_1500.Enabled = false;
                     button_1530.Enabled = false; 
                 }      //неділя
                                            
            }
            else if (comboBox1.Text == "Чернявська Ольга Петрівна") 
            {
                if (day == "Monday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;

                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }            //понеділок
                else if (day == "Tuesday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //вівторок
                else if (day == "Wednesday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;

                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }        //середа
                else if (day == "Thursday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;

                }     //четвер
                else if (day == "Friday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;

                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //пятниця
                else if (day == "Saturday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } //субота 
                else if (day == "Sunday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } 
            }
            else if (comboBox1.Text == "Шникарук Лариса Георгіївна")
            {
                if (day == "Monday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }            //понеділок
                else if (day == "Tuesday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //вівторок
                else if (day == "Wednesday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }        //середа
                else if (day == "Thursday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;

                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;
                    button1400.Enabled = true;
                    button1430.Enabled = true;
                    button_1500.Enabled = true;
                    button_1530.Enabled = true;

                }     //четвер
                else if (day == "Friday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;

                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //пятниця
                else if (day == "Saturday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } //субота 
                else if (day == "Sunday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } 
            }
            else if (comboBox1.Text == "Лавкай Тетяна Іванівна")
            {
                if (day == "Monday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;

                    button1000.Enabled = true; 
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;
                    button1400.Enabled = true;
                    button1430.Enabled = true;
                    button_1500.Enabled = true;
                    button_1530.Enabled = true;
                }            //понеділок
                else if (day == "Tuesday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //вівторок
                else if (day == "Wednesday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;

                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;
                    button1400.Enabled = true;
                    button1430.Enabled = true;
                    button_1500.Enabled = true;
                    button_1530.Enabled = true;
                }        //середа
                else if (day == "Thursday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;

                }     //четвер
                else if (day == "Friday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;

                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;
                    button1400.Enabled = true;
                    button1430.Enabled = true;
                    button_1500.Enabled = true;
                    button_1530.Enabled = true;
                }      //пятниця
                else if (day == "Saturday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } //субота 
                else if (day == "Sunday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } 
            }
            else if (comboBox1.Text == "Какуріна Маріанна Михайлівна") 
            {
                if (day == "Monday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }            //понеділок
                else if (day == "Tuesday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //вівторок
                else if (day == "Wednesday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }        //середа
                else if (day == "Thursday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;

                }     //четвер
                else if (day == "Friday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //пятниця
                else if (day == "Saturday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } //субота 
                else if (day == "Sunday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } 
            }
            else if (comboBox1.Text == "Шеверя Світлана Юріївна")
            {
                if (day == "Monday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;

                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }            //понеділок
                else if (day == "Tuesday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;

                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //вівторок
                else if (day == "Wednesday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;
                    button1300.Enabled = true;
                    button1330.Enabled = true;

                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }        //середа
                else if (day == "Thursday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;

                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;

                }     //четвер
                else if (day == "Friday")
                {
                    button_0800.Enabled = true;
                    button_0830.Enabled = true;
                    button_0900.Enabled = true;
                    button_0930.Enabled = true;
                    button1000.Enabled = true;
                    button1030.Enabled = true;
                    button1100.Enabled = true;
                    button1130.Enabled = true;
                    button1200.Enabled = true;
                    button1230.Enabled = true;

                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                }      //пятниця
                else if (day == "Saturday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } //субота 
                else if (day == "Sunday")
                {
                    button_0800.Enabled = false;
                    button_0830.Enabled = false;
                    button_0900.Enabled = false;
                    button_0930.Enabled = false;
                    button1000.Enabled = false;
                    button1030.Enabled = false;
                    button1100.Enabled = false;
                    button1130.Enabled = false;
                    button1200.Enabled = false;
                    button1230.Enabled = false;
                    button1300.Enabled = false;
                    button1330.Enabled = false;
                    button1400.Enabled = false;
                    button1430.Enabled = false;
                    button_1500.Enabled = false;
                    button_1530.Enabled = false;
                } 
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Видалення запису
        private void btn_rollback_Click(object sender, EventArgs e)
        {
           
            FormRollBack Frb = new FormRollBack();
            Frb.Show();
        }
        public string day;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             date = dateTimePicker1.Value.ToString("dd.MM.yyyy");
             txt_Calendar.Text = date;
             button1.Enabled = true;
             day = dateTimePicker1.Value.DayOfWeek.ToString();
        }
        
        private void button1000_Click(object sender, EventArgs e)
        {
            timebtn = "10:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }
    
        private void button1030_Click(object sender, EventArgs e)
        {
            timebtn = "10:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1100_Click(object sender, EventArgs e)
        {
            timebtn = "11:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1130_Click(object sender, EventArgs e)
        {
            timebtn = "11:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1200_Click(object sender, EventArgs e)
        {
            timebtn = "12:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1230_Click(object sender, EventArgs e)
        {
            timebtn = "12:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1300_Click(object sender, EventArgs e)
        {
            timebtn = "13:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1330_Click(object sender, EventArgs e)
        {
            timebtn = "13:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1400_Click(object sender, EventArgs e)
        {
            timebtn = "14:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button1430_Click(object sender, EventArgs e)
        {
            timebtn = "14:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button_0800_Click(object sender, EventArgs e)
        {
            timebtn = "08:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button_0830_Click(object sender, EventArgs e)
        {
            timebtn = "08:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button_0900_Click(object sender, EventArgs e)
        {
            timebtn = "09:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button_0930_Click(object sender, EventArgs e)
        {
            timebtn = "09:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button_1500_Click(object sender, EventArgs e)
        {
            timebtn = "15:00";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        private void button_1530_Click(object sender, EventArgs e)
        {
            timebtn = "15:30";
            Form2_Register form2_reg = new Form2_Register();
            form2_reg.Show(this);
        }

        //*****************************
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RozkladForm rzf = new RozkladForm();
            rzf.Show();
        }
    }
}
