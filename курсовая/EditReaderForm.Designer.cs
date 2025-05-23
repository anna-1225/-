namespace курсовая
{
    partial class EditReaderForm
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
            this.LibraryCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.Reestablish = new System.Windows.Forms.DateTimePicker();
            this.Registration = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.chkListener = new System.Windows.Forms.CheckBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.panelPPS = new System.Windows.Forms.Panel();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEditReaders = new System.Windows.Forms.Panel();
            this.panelStudent.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            this.panelPPS.SuspendLayout();
            this.panelEditReaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibraryCardNumber
            // 
            this.LibraryCardNumber.Enabled = false;
            this.LibraryCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibraryCardNumber.Location = new System.Drawing.Point(314, 364);
            this.LibraryCardNumber.Mask = "0000-0000";
            this.LibraryCardNumber.Name = "LibraryCardNumber";
            this.LibraryCardNumber.Size = new System.Drawing.Size(190, 29);
            this.LibraryCardNumber.TabIndex = 34;
            // 
            // Reestablish
            // 
            this.Reestablish.Enabled = false;
            this.Reestablish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reestablish.Location = new System.Drawing.Point(314, 305);
            this.Reestablish.Name = "Reestablish";
            this.Reestablish.Size = new System.Drawing.Size(190, 29);
            this.Reestablish.TabIndex = 33;
            // 
            // Registration
            // 
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(314, 245);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(190, 29);
            this.Registration.TabIndex = 32;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(314, 481);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(188, 124);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(314, 423);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(190, 32);
            this.Category.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(310, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Категория читателя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(264, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Номер читательского билета";
            // 
            // Surname
            // 
            this.Surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(314, 184);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(190, 29);
            this.Surname.TabIndex = 26;
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(312, 123);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(190, 29);
            this.LastName.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(356, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(356, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(325, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата регистрации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(308, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Дата перерегистрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(388, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя";
            // 
            // tName
            // 
            this.tName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tName.Location = new System.Drawing.Point(312, 63);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(190, 29);
            this.tName.TabIndex = 19;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(54, 481);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(190, 124);
            this.Delete.TabIndex = 35;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.chkListener);
            this.panelStudent.Controls.Add(this.txtGroup);
            this.panelStudent.Controls.Add(this.label10);
            this.panelStudent.Controls.Add(this.label9);
            this.panelStudent.Controls.Add(this.label8);
            this.panelStudent.Controls.Add(this.txtFaculty);
            this.panelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelStudent.Location = new System.Drawing.Point(37, 24);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(240, 184);
            this.panelStudent.TabIndex = 36;
            // 
            // chkListener
            // 
            this.chkListener.AutoSize = true;
            this.chkListener.Location = new System.Drawing.Point(15, 141);
            this.chkListener.Name = "chkListener";
            this.chkListener.Size = new System.Drawing.Size(222, 28);
            this.chkListener.TabIndex = 6;
            this.chkListener.Text = "Слушатели ПО и ФПК";
            this.chkListener.UseVisualStyleBackColor = true;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(15, 98);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(190, 29);
            this.txtGroup.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Факультет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Группа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 2;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(17, 39);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(188, 29);
            this.txtFaculty.TabIndex = 0;
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.txtEmployeePosition);
            this.panelEmployee.Controls.Add(this.label16);
            this.panelEmployee.Controls.Add(this.label17);
            this.panelEmployee.Controls.Add(this.txtDivision);
            this.panelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelEmployee.Location = new System.Drawing.Point(557, 295);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(212, 153);
            this.panelEmployee.TabIndex = 37;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(12, 95);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(187, 29);
            this.txtEmployeePosition.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 24);
            this.label16.TabIndex = 14;
            this.label16.Text = "Отдел";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 24);
            this.label17.TabIndex = 13;
            this.label17.Text = "Должность";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(9, 36);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(190, 29);
            this.txtDivision.TabIndex = 12;
            // 
            // panelPPS
            // 
            this.panelPPS.Controls.Add(this.txtDegree);
            this.panelPPS.Controls.Add(this.txtRank);
            this.panelPPS.Controls.Add(this.label15);
            this.panelPPS.Controls.Add(this.label14);
            this.panelPPS.Controls.Add(this.txtPosition);
            this.panelPPS.Controls.Add(this.label11);
            this.panelPPS.Controls.Add(this.label12);
            this.panelPPS.Controls.Add(this.label13);
            this.panelPPS.Controls.Add(this.txtDepartment);
            this.panelPPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPPS.Location = new System.Drawing.Point(546, 24);
            this.panelPPS.Name = "panelPPS";
            this.panelPPS.Size = new System.Drawing.Size(247, 265);
            this.panelPPS.TabIndex = 38;
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(21, 160);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(191, 29);
            this.txtDegree.TabIndex = 15;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(21, 221);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(191, 29);
            this.txtRank.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 24);
            this.label15.TabIndex = 13;
            this.label15.Text = "Степень";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(69, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Звание";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(22, 100);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(191, 29);
            this.txtPosition.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Кафедра";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Должность";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 24);
            this.label13.TabIndex = 8;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(22, 39);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(190, 29);
            this.txtDepartment.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(569, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 122);
            this.button1.TabIndex = 39;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelEditReaders
            // 
            this.panelEditReaders.Controls.Add(this.button1);
            this.panelEditReaders.Controls.Add(this.tName);
            this.panelEditReaders.Controls.Add(this.panelPPS);
            this.panelEditReaders.Controls.Add(this.label1);
            this.panelEditReaders.Controls.Add(this.panelEmployee);
            this.panelEditReaders.Controls.Add(this.label2);
            this.panelEditReaders.Controls.Add(this.panelStudent);
            this.panelEditReaders.Controls.Add(this.label3);
            this.panelEditReaders.Controls.Add(this.Delete);
            this.panelEditReaders.Controls.Add(this.label4);
            this.panelEditReaders.Controls.Add(this.LibraryCardNumber);
            this.panelEditReaders.Controls.Add(this.label5);
            this.panelEditReaders.Controls.Add(this.Reestablish);
            this.panelEditReaders.Controls.Add(this.LastName);
            this.panelEditReaders.Controls.Add(this.Registration);
            this.panelEditReaders.Controls.Add(this.Surname);
            this.panelEditReaders.Controls.Add(this.SaveButton);
            this.panelEditReaders.Controls.Add(this.label6);
            this.panelEditReaders.Controls.Add(this.Category);
            this.panelEditReaders.Controls.Add(this.label7);
            this.panelEditReaders.Location = new System.Drawing.Point(251, 38);
            this.panelEditReaders.Name = "panelEditReaders";
            this.panelEditReaders.Size = new System.Drawing.Size(827, 635);
            this.panelEditReaders.TabIndex = 40;
            // 
            // EditReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1329, 707);
            this.Controls.Add(this.panelEditReaders);
            this.Name = "EditReaderForm";
            this.Text = "Редактирование читателя";
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.panelPPS.ResumeLayout(false);
            this.panelPPS.PerformLayout();
            this.panelEditReaders.ResumeLayout(false);
            this.panelEditReaders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox LibraryCardNumber;
        private System.Windows.Forms.DateTimePicker Reestablish;
        private System.Windows.Forms.DateTimePicker Registration;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.CheckBox chkListener;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Panel panelPPS;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEditReaders;
    }
}