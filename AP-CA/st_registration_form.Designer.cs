namespace AP_CA
{
    partial class st_registration_form
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
            this.StudentNumber = new System.Windows.Forms.GroupBox();
            this.txtCourse = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtLevel2 = new System.Windows.Forms.RadioButton();
            this.undGrad = new System.Windows.Forms.RadioButton();
            this.txtCounty = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentNumber.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentNumber
            // 
            this.StudentNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentNumber.Controls.Add(this.txtCourse);
            this.StudentNumber.Controls.Add(this.button3);
            this.StudentNumber.Controls.Add(this.button2);
            this.StudentNumber.Controls.Add(this.txtName);
            this.StudentNumber.Controls.Add(this.label13);
            this.StudentNumber.Controls.Add(this.label12);
            this.StudentNumber.Controls.Add(this.txtSname);
            this.StudentNumber.Controls.Add(this.txtLevel2);
            this.StudentNumber.Controls.Add(this.undGrad);
            this.StudentNumber.Controls.Add(this.txtCounty);
            this.StudentNumber.Controls.Add(this.txtCity);
            this.StudentNumber.Controls.Add(this.label11);
            this.StudentNumber.Controls.Add(this.txtEmail);
            this.StudentNumber.Controls.Add(this.label9);
            this.StudentNumber.Controls.Add(this.label8);
            this.StudentNumber.Controls.Add(this.label7);
            this.StudentNumber.Controls.Add(this.label6);
            this.StudentNumber.Controls.Add(this.txtPhone);
            this.StudentNumber.Controls.Add(this.txtAddress);
            this.StudentNumber.Controls.Add(this.txtStudentID);
            this.StudentNumber.Controls.Add(this.label5);
            this.StudentNumber.Controls.Add(this.label4);
            this.StudentNumber.Controls.Add(this.label3);
            this.StudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNumber.Location = new System.Drawing.Point(0, 75);
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(1029, 602);
            this.StudentNumber.TabIndex = 0;
            this.StudentNumber.TabStop = false;
            this.StudentNumber.Text = "Student Details";
            this.StudentNumber.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtCourse
            // 
            this.txtCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCourse.FormattingEnabled = true;
            this.txtCourse.Items.AddRange(new object[] {
            "Software Development",
            "Data Analytics",
            "Fintech",
            "Business Analysis",
            "Cloud Computing"});
            this.txtCourse.Location = new System.Drawing.Point(662, 65);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(271, 33);
            this.txtCourse.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 58);
            this.button3.TabIndex = 34;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 58);
            this.button2.TabIndex = 33;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 31);
            this.txtName.TabIndex = 32;
            this.txtName.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "First Name";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(485, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Course";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(229, 108);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(218, 31);
            this.txtSname.TabIndex = 29;
            this.txtSname.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // txtLevel2
            // 
            this.txtLevel2.AccessibleName = "pstgrad";
            this.txtLevel2.AutoSize = true;
            this.txtLevel2.Location = new System.Drawing.Point(841, 118);
            this.txtLevel2.Name = "txtLevel2";
            this.txtLevel2.Size = new System.Drawing.Size(158, 29);
            this.txtLevel2.TabIndex = 28;
            this.txtLevel2.TabStop = true;
            this.txtLevel2.Text = "Postgraduate";
            this.txtLevel2.UseVisualStyleBackColor = true;
            this.txtLevel2.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // undGrad
            // 
            this.undGrad.AccessibleName = "undgrad";
            this.undGrad.AutoSize = true;
            this.undGrad.Location = new System.Drawing.Point(662, 118);
            this.undGrad.Name = "undGrad";
            this.undGrad.Size = new System.Drawing.Size(173, 29);
            this.undGrad.TabIndex = 27;
            this.undGrad.TabStop = true;
            this.undGrad.Text = "Undergraduate";
            this.undGrad.UseVisualStyleBackColor = true;
            this.undGrad.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // txtCounty
            // 
            this.txtCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCounty.FormattingEnabled = true;
            this.txtCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.txtCounty.Location = new System.Drawing.Point(229, 194);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(218, 33);
            this.txtCounty.TabIndex = 26;
            this.txtCounty.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(229, 239);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(218, 31);
            this.txtCity.TabIndex = 25;
            this.txtCity.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "City";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(662, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 31);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "County";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Surname";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(662, 158);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(271, 31);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(662, 203);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 31);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(229, 153);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(218, 31);
            this.txtStudentID.TabIndex = 9;
            this.txtStudentID.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStudentID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Course";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 48);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip3.TabIndex = 11;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.closeToolStripMenuItem.Text = "Close ";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // st_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 679);
            this.Controls.Add(this.StudentNumber);
            this.Controls.Add(this.menuStrip3);
            this.Name = "st_registration_form";
            this.Text = "st_registration_form";
            this.Load += new System.EventHandler(this.St_registration_form_Load);
            this.Controls.SetChildIndex(this.menuStrip3, 0);
            this.Controls.SetChildIndex(this.StudentNumber, 0);
            this.StudentNumber.ResumeLayout(false);
            this.StudentNumber.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton txtLevel2;
        private System.Windows.Forms.RadioButton undGrad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtCourse;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}