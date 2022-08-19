namespace EP_Programirnaje_projekat___program
{
    partial class Form_Nov_Termin
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_Grad = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Broj = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Slova = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Potvrdi = new System.Windows.Forms.Button();
            this.button_Odustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.Red;
            this.button_Exit.Location = new System.Drawing.Point(459, 1);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(60, 30);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/ MM/ yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(161, 405);
            this.dateTimePicker.MinDate = new System.DateTime(2019, 3, 27, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 24);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Tag = "";
            // 
            // maskedTextBox_Grad
            // 
            this.maskedTextBox_Grad.AsciiOnly = true;
            this.maskedTextBox_Grad.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Grad.Location = new System.Drawing.Point(169, 226);
            this.maskedTextBox_Grad.Mask = "LL";
            this.maskedTextBox_Grad.MinimumSize = new System.Drawing.Size(4, 40);
            this.maskedTextBox_Grad.Name = "maskedTextBox_Grad";
            this.maskedTextBox_Grad.Size = new System.Drawing.Size(46, 40);
            this.maskedTextBox_Grad.TabIndex = 8;
            // 
            // maskedTextBox_Broj
            // 
            this.maskedTextBox_Broj.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_Broj.Location = new System.Drawing.Point(257, 226);
            this.maskedTextBox_Broj.Mask = "00000";
            this.maskedTextBox_Broj.MinimumSize = new System.Drawing.Size(4, 40);
            this.maskedTextBox_Broj.Name = "maskedTextBox_Broj";
            this.maskedTextBox_Broj.Size = new System.Drawing.Size(76, 40);
            this.maskedTextBox_Broj.TabIndex = 12;
            // 
            // maskedTextBox_Slova
            // 
            this.maskedTextBox_Slova.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_Slova.Location = new System.Drawing.Point(343, 226);
            this.maskedTextBox_Slova.Mask = "LL";
            this.maskedTextBox_Slova.MinimumSize = new System.Drawing.Size(4, 40);
            this.maskedTextBox_Slova.Name = "maskedTextBox_Slova";
            this.maskedTextBox_Slova.Size = new System.Drawing.Size(46, 40);
            this.maskedTextBox_Slova.TabIndex = 13;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tradicionalno";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 21);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Automatsko";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 21);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Dubinsko";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(163, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip pranja";
            // 
            // button_Potvrdi
            // 
            this.button_Potvrdi.BackColor = System.Drawing.Color.White;
            this.button_Potvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Potvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Potvrdi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Potvrdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button_Potvrdi.Location = new System.Drawing.Point(129, 469);
            this.button_Potvrdi.Name = "button_Potvrdi";
            this.button_Potvrdi.Size = new System.Drawing.Size(121, 37);
            this.button_Potvrdi.TabIndex = 22;
            this.button_Potvrdi.Text = "Potvrdi";
            this.button_Potvrdi.UseVisualStyleBackColor = false;
            this.button_Potvrdi.Click += new System.EventHandler(this.button_Potvrdi_Click);
            // 
            // button_Odustani
            // 
            this.button_Odustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button_Odustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Odustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Odustani.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Odustani.ForeColor = System.Drawing.Color.Gray;
            this.button_Odustani.Location = new System.Drawing.Point(282, 469);
            this.button_Odustani.Name = "button_Odustani";
            this.button_Odustani.Size = new System.Drawing.Size(121, 37);
            this.button_Odustani.TabIndex = 23;
            this.button_Odustani.Text = "Odustani";
            this.button_Odustani.UseVisualStyleBackColor = false;
            this.button_Odustani.Click += new System.EventHandler(this.button_Odustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Broj Tablice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Datum i vreme za rezervaciju termina";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EP_Programirnaje_projekat___program.Properties.Resources.carimg2;
            this.pictureBox2.Location = new System.Drawing.Point(140, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EP_Programirnaje_projekat___program.Properties.Resources.Layer_1;
            this.pictureBox1.Location = new System.Drawing.Point(129, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 405);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 3, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(62, 24);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Tag = "";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form_Nov_Termin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(520, 523);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Odustani);
            this.Controls.Add(this.button_Potvrdi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.maskedTextBox_Slova);
            this.Controls.Add(this.maskedTextBox_Broj);
            this.Controls.Add(this.maskedTextBox_Grad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button_Exit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form_Nov_Termin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Nov_Termin";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Grad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Broj;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Slova;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button_Potvrdi;
        public System.Windows.Forms.Button button_Odustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}