namespace kurs_0._1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Calendar = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_rollback = new System.Windows.Forms.Button();
            this.txt_spec = new System.Windows.Forms.TextBox();
            this.txt_stag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nubertel = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1430 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1200 = new System.Windows.Forms.Button();
            this.button1400 = new System.Windows.Forms.Button();
            this.button1330 = new System.Windows.Forms.Button();
            this.button1300 = new System.Windows.Forms.Button();
            this.button1230 = new System.Windows.Forms.Button();
            this.button1130 = new System.Windows.Forms.Button();
            this.button1100 = new System.Windows.Forms.Button();
            this.button1030 = new System.Windows.Forms.Button();
            this.button1000 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_1530 = new System.Windows.Forms.Button();
            this.button_1500 = new System.Windows.Forms.Button();
            this.button_0930 = new System.Windows.Forms.Button();
            this.button_0900 = new System.Windows.Forms.Button();
            this.button_0830 = new System.Windows.Forms.Button();
            this.button_0800 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // txt_Calendar
            // 
            this.txt_Calendar.Enabled = false;
            this.txt_Calendar.Location = new System.Drawing.Point(147, 12);
            this.txt_Calendar.Name = "txt_Calendar";
            this.txt_Calendar.Size = new System.Drawing.Size(83, 20);
            this.txt_Calendar.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 12, 16, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_rollback
            // 
            this.btn_rollback.Location = new System.Drawing.Point(768, 330);
            this.btn_rollback.Name = "btn_rollback";
            this.btn_rollback.Size = new System.Drawing.Size(135, 53);
            this.btn_rollback.TabIndex = 12;
            this.btn_rollback.Text = "Відмініти запис на прийом";
            this.btn_rollback.UseVisualStyleBackColor = true;
            this.btn_rollback.Click += new System.EventHandler(this.btn_rollback_Click);
            // 
            // txt_spec
            // 
            this.txt_spec.Location = new System.Drawing.Point(465, 12);
            this.txt_spec.Name = "txt_spec";
            this.txt_spec.ReadOnly = true;
            this.txt_spec.Size = new System.Drawing.Size(124, 20);
            this.txt_spec.TabIndex = 13;
            // 
            // txt_stag
            // 
            this.txt_stag.Location = new System.Drawing.Point(465, 38);
            this.txt_stag.Name = "txt_stag";
            this.txt_stag.ReadOnly = true;
            this.txt_stag.Size = new System.Drawing.Size(23, 20);
            this.txt_stag.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Спеціалізація";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Стаж (роки)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Номер телефону";
            // 
            // txt_nubertel
            // 
            this.txt_nubertel.Location = new System.Drawing.Point(465, 64);
            this.txt_nubertel.Name = "txt_nubertel";
            this.txt_nubertel.ReadOnly = true;
            this.txt_nubertel.Size = new System.Drawing.Size(124, 20);
            this.txt_nubertel.TabIndex = 18;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(465, 90);
            this.txt_year.Name = "txt_year";
            this.txt_year.ReadOnly = true;
            this.txt_year.Size = new System.Drawing.Size(123, 20);
            this.txt_year.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Рік народження";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "380 68 010 0370";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(531, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Номер адміністратора";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "Розклад всіх лікарів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::kurs_0._1.Properties.Resources._81_big;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button_0800);
            this.groupBox1.Controls.Add(this.button_0830);
            this.groupBox1.Controls.Add(this.button_0900);
            this.groupBox1.Controls.Add(this.button_0930);
            this.groupBox1.Controls.Add(this.button_1500);
            this.groupBox1.Controls.Add(this.button_1530);
            this.groupBox1.Controls.Add(this.button1430);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1200);
            this.groupBox1.Controls.Add(this.button1400);
            this.groupBox1.Controls.Add(this.button1330);
            this.groupBox1.Controls.Add(this.button1300);
            this.groupBox1.Controls.Add(this.button1230);
            this.groupBox1.Controls.Add(this.button1130);
            this.groupBox1.Controls.Add(this.button1100);
            this.groupBox1.Controls.Add(this.button1030);
            this.groupBox1.Controls.Add(this.button1000);
            this.groupBox1.Location = new System.Drawing.Point(57, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1430
            // 
            this.button1430.Location = new System.Drawing.Point(330, 49);
            this.button1430.Name = "button1430";
            this.button1430.Size = new System.Drawing.Size(57, 41);
            this.button1430.TabIndex = 9;
            this.button1430.Text = "14:30";
            this.button1430.UseVisualStyleBackColor = true;
            this.button1430.Click += new System.EventHandler(this.button1430_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::kurs_0._1.Properties.Resources._81_big;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Виберіть на який час записатись";
            // 
            // button1200
            // 
            this.button1200.Location = new System.Drawing.Point(0, 49);
            this.button1200.Name = "button1200";
            this.button1200.Size = new System.Drawing.Size(60, 41);
            this.button1200.TabIndex = 8;
            this.button1200.Text = "12:00";
            this.button1200.UseVisualStyleBackColor = true;
            this.button1200.Click += new System.EventHandler(this.button1200_Click);
            // 
            // button1400
            // 
            this.button1400.Location = new System.Drawing.Point(268, 49);
            this.button1400.Name = "button1400";
            this.button1400.Size = new System.Drawing.Size(56, 41);
            this.button1400.TabIndex = 7;
            this.button1400.Text = "14:00";
            this.button1400.UseVisualStyleBackColor = true;
            this.button1400.Click += new System.EventHandler(this.button1400_Click);
            // 
            // button1330
            // 
            this.button1330.Location = new System.Drawing.Point(201, 49);
            this.button1330.Name = "button1330";
            this.button1330.Size = new System.Drawing.Size(60, 41);
            this.button1330.TabIndex = 6;
            this.button1330.Text = "13:30";
            this.button1330.UseVisualStyleBackColor = true;
            this.button1330.Click += new System.EventHandler(this.button1330_Click);
            // 
            // button1300
            // 
            this.button1300.Location = new System.Drawing.Point(135, 49);
            this.button1300.Name = "button1300";
            this.button1300.Size = new System.Drawing.Size(60, 41);
            this.button1300.TabIndex = 5;
            this.button1300.Text = "13:00";
            this.button1300.UseVisualStyleBackColor = true;
            this.button1300.Click += new System.EventHandler(this.button1300_Click);
            // 
            // button1230
            // 
            this.button1230.Location = new System.Drawing.Point(66, 49);
            this.button1230.Name = "button1230";
            this.button1230.Size = new System.Drawing.Size(60, 41);
            this.button1230.TabIndex = 4;
            this.button1230.Text = "12:30";
            this.button1230.UseVisualStyleBackColor = true;
            this.button1230.Click += new System.EventHandler(this.button1230_Click);
            // 
            // button1130
            // 
            this.button1130.Location = new System.Drawing.Point(456, -2);
            this.button1130.Name = "button1130";
            this.button1130.Size = new System.Drawing.Size(57, 45);
            this.button1130.TabIndex = 3;
            this.button1130.Text = "11:30";
            this.button1130.UseVisualStyleBackColor = true;
            this.button1130.Click += new System.EventHandler(this.button1130_Click);
            // 
            // button1100
            // 
            this.button1100.Location = new System.Drawing.Point(393, -2);
            this.button1100.Name = "button1100";
            this.button1100.Size = new System.Drawing.Size(57, 45);
            this.button1100.TabIndex = 2;
            this.button1100.Text = "11:00";
            this.button1100.UseVisualStyleBackColor = true;
            this.button1100.Click += new System.EventHandler(this.button1100_Click);
            // 
            // button1030
            // 
            this.button1030.Location = new System.Drawing.Point(330, -2);
            this.button1030.Name = "button1030";
            this.button1030.Size = new System.Drawing.Size(57, 45);
            this.button1030.TabIndex = 1;
            this.button1030.Text = "10:30";
            this.button1030.UseVisualStyleBackColor = true;
            this.button1030.Click += new System.EventHandler(this.button1030_Click);
            // 
            // button1000
            // 
            this.button1000.BackColor = System.Drawing.SystemColors.Control;
            this.button1000.Location = new System.Drawing.Point(267, -2);
            this.button1000.Name = "button1000";
            this.button1000.Size = new System.Drawing.Size(57, 45);
            this.button1000.TabIndex = 0;
            this.button1000.Text = "10:00";
            this.button1000.UseVisualStyleBackColor = true;
            this.button1000.Click += new System.EventHandler(this.button1000_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::kurs_0._1.Properties.Resources._81_big;
            this.button1.Location = new System.Drawing.Point(232, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вибрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Image = global::kurs_0._1.Properties.Resources._81_big;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(-5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "   Лікар";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::kurs_0._1.Properties.Resources._81_big;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button_1530
            // 
            this.button_1530.Location = new System.Drawing.Point(456, 49);
            this.button_1530.Name = "button_1530";
            this.button_1530.Size = new System.Drawing.Size(57, 41);
            this.button_1530.TabIndex = 12;
            this.button_1530.Text = "15:30";
            this.button_1530.UseVisualStyleBackColor = true;
            this.button_1530.Click += new System.EventHandler(this.button_1530_Click);
            // 
            // button_1500
            // 
            this.button_1500.Location = new System.Drawing.Point(393, 49);
            this.button_1500.Name = "button_1500";
            this.button_1500.Size = new System.Drawing.Size(57, 41);
            this.button_1500.TabIndex = 13;
            this.button_1500.Text = "15:00";
            this.button_1500.UseVisualStyleBackColor = true;
            this.button_1500.Click += new System.EventHandler(this.button_1500_Click);
            // 
            // button_0930
            // 
            this.button_0930.BackColor = System.Drawing.SystemColors.Control;
            this.button_0930.Location = new System.Drawing.Point(201, -1);
            this.button_0930.Name = "button_0930";
            this.button_0930.Size = new System.Drawing.Size(60, 44);
            this.button_0930.TabIndex = 15;
            this.button_0930.Text = "09:30";
            this.button_0930.UseVisualStyleBackColor = true;
            this.button_0930.Click += new System.EventHandler(this.button_0930_Click);
            // 
            // button_0900
            // 
            this.button_0900.BackColor = System.Drawing.SystemColors.Control;
            this.button_0900.Location = new System.Drawing.Point(135, -1);
            this.button_0900.Name = "button_0900";
            this.button_0900.Size = new System.Drawing.Size(60, 44);
            this.button_0900.TabIndex = 16;
            this.button_0900.Text = "09:00";
            this.button_0900.UseVisualStyleBackColor = true;
            this.button_0900.Click += new System.EventHandler(this.button_0900_Click);
            // 
            // button_0830
            // 
            this.button_0830.BackColor = System.Drawing.SystemColors.Control;
            this.button_0830.Location = new System.Drawing.Point(66, -1);
            this.button_0830.Name = "button_0830";
            this.button_0830.Size = new System.Drawing.Size(60, 44);
            this.button_0830.TabIndex = 17;
            this.button_0830.Text = "08:30";
            this.button_0830.UseVisualStyleBackColor = true;
            this.button_0830.Click += new System.EventHandler(this.button_0830_Click);
            // 
            // button_0800
            // 
            this.button_0800.BackColor = System.Drawing.SystemColors.Control;
            this.button_0800.Location = new System.Drawing.Point(0, -1);
            this.button_0800.Name = "button_0800";
            this.button_0800.Size = new System.Drawing.Size(60, 44);
            this.button_0800.TabIndex = 18;
            this.button_0800.Text = "08:00";
            this.button_0800.UseVisualStyleBackColor = true;
            this.button_0800.Click += new System.EventHandler(this.button_0800_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_nubertel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_stag);
            this.Controls.Add(this.txt_spec);
            this.Controls.Add(this.btn_rollback);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Calendar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Міська Дитяча Лікарня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Calendar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1430;
        private System.Windows.Forms.Button button1200;
        private System.Windows.Forms.Button button1400;
        private System.Windows.Forms.Button button1330;
        private System.Windows.Forms.Button button1300;
        private System.Windows.Forms.Button button1230;
        private System.Windows.Forms.Button button1130;
        private System.Windows.Forms.Button button1100;
        private System.Windows.Forms.Button button1030;
        private System.Windows.Forms.Button button1000;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rollback;
        private System.Windows.Forms.TextBox txt_spec;
        private System.Windows.Forms.TextBox txt_stag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nubertel;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_0800;
        private System.Windows.Forms.Button button_0830;
        private System.Windows.Forms.Button button_0900;
        private System.Windows.Forms.Button button_0930;
        private System.Windows.Forms.Button button_1500;
        private System.Windows.Forms.Button button_1530;
    }
}