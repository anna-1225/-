namespace курсовая
{
    partial class AddEditBookForm
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
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxLoanDays = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.BooksCategory = new System.Windows.Forms.Label();
            this.ReadingHallOnly = new System.Windows.Forms.CheckBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.RemoveAuthor = new System.Windows.Forms.Button();
            this.SaveBook = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.LibraryCode = new System.Windows.Forms.MaskedTextBox();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.readingHallPanel = new System.Windows.Forms.Panel();
            this.ShelfNumber = new System.Windows.Forms.NumericUpDown();
            this.RackNumber = new System.Windows.Forms.NumericUpDown();
            this.HallNumber = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelAddBook = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.AvailableCopies = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLoanDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            this.readingHallPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RackNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HallNumber)).BeginInit();
            this.panelAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(87, 77);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(230, 29);
            this.Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(104, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Библиотечный шифр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(104, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Место издательства";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(136, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Издательство";
            // 
            // Place
            // 
            this.Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place.Location = new System.Drawing.Point(89, 254);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(230, 29);
            this.Place.TabIndex = 6;
            // 
            // Publisher
            // 
            this.Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Publisher.Location = new System.Drawing.Point(89, 195);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(230, 29);
            this.Publisher.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(136, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Год издания";
            // 
            // MaxLoanDays
            // 
            this.MaxLoanDays.Enabled = false;
            this.MaxLoanDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxLoanDays.Location = new System.Drawing.Point(87, 438);
            this.MaxLoanDays.Maximum = new decimal(new int[] {
            351,
            0,
            0,
            0});
            this.MaxLoanDays.Name = "MaxLoanDays";
            this.MaxLoanDays.Size = new System.Drawing.Size(232, 29);
            this.MaxLoanDays.TabIndex = 12;
            this.MaxLoanDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(134, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Срок выдачи";
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Учебник",
            "Повесть",
            "Роман",
            "Статья",
            "Стих",
            "Диссертация",
            "Реферат",
            "Другое"});
            this.Category.Location = new System.Drawing.Point(386, 81);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(232, 32);
            this.Category.TabIndex = 16;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // BooksCategory
            // 
            this.BooksCategory.AutoSize = true;
            this.BooksCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BooksCategory.Location = new System.Drawing.Point(459, 54);
            this.BooksCategory.Name = "BooksCategory";
            this.BooksCategory.Size = new System.Drawing.Size(105, 24);
            this.BooksCategory.TabIndex = 17;
            this.BooksCategory.Text = "Категория";
            // 
            // ReadingHallOnly
            // 
            this.ReadingHallOnly.AutoSize = true;
            this.ReadingHallOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadingHallOnly.Location = new System.Drawing.Point(393, 119);
            this.ReadingHallOnly.Name = "ReadingHallOnly";
            this.ReadingHallOnly.Size = new System.Drawing.Size(230, 28);
            this.ReadingHallOnly.TabIndex = 18;
            this.ReadingHallOnly.Text = "Только читальный зал";
            this.ReadingHallOnly.UseVisualStyleBackColor = true;
            // 
            // AuthorName
            // 
            this.AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorName.Location = new System.Drawing.Point(386, 187);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(232, 29);
            this.AuthorName.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(470, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Автор";
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.ItemHeight = 24;
            this.listBoxAuthors.Location = new System.Drawing.Point(386, 227);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(232, 76);
            this.listBoxAuthors.TabIndex = 21;
            // 
            // AddAuthor
            // 
            this.AddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAuthor.Location = new System.Drawing.Point(639, 227);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(112, 28);
            this.AddAuthor.TabIndex = 22;
            this.AddAuthor.Text = "Добавить автора";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // RemoveAuthor
            // 
            this.RemoveAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveAuthor.Location = new System.Drawing.Point(639, 272);
            this.RemoveAuthor.Name = "RemoveAuthor";
            this.RemoveAuthor.Size = new System.Drawing.Size(112, 31);
            this.RemoveAuthor.TabIndex = 23;
            this.RemoveAuthor.Text = "Удалить автора";
            this.RemoveAuthor.UseVisualStyleBackColor = true;
            this.RemoveAuthor.Click += new System.EventHandler(this.RemoveAuthor_Click_1);
            // 
            // SaveBook
            // 
            this.SaveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBook.Location = new System.Drawing.Point(112, 595);
            this.SaveBook.Name = "SaveBook";
            this.SaveBook.Size = new System.Drawing.Size(209, 72);
            this.SaveBook.TabIndex = 24;
            this.SaveBook.Text = "Сохранить";
            this.SaveBook.UseVisualStyleBackColor = true;
            this.SaveBook.Click += new System.EventHandler(this.SaveBook_Click);
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCancel.Location = new System.Drawing.Point(511, 595);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(209, 72);
            this.BCancel.TabIndex = 25;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // LibraryCode
            // 
            this.LibraryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibraryCode.Location = new System.Drawing.Point(89, 136);
            this.LibraryCode.Mask = "0000-0000";
            this.LibraryCode.Name = "LibraryCode";
            this.LibraryCode.Size = new System.Drawing.Size(230, 29);
            this.LibraryCode.TabIndex = 26;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.Location = new System.Drawing.Point(89, 312);
            this.Year.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(232, 29);
            this.Year.TabIndex = 27;
            this.Year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // readingHallPanel
            // 
            this.readingHallPanel.Controls.Add(this.ShelfNumber);
            this.readingHallPanel.Controls.Add(this.RackNumber);
            this.readingHallPanel.Controls.Add(this.HallNumber);
            this.readingHallPanel.Controls.Add(this.label12);
            this.readingHallPanel.Controls.Add(this.label11);
            this.readingHallPanel.Controls.Add(this.label10);
            this.readingHallPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readingHallPanel.Location = new System.Drawing.Point(349, 354);
            this.readingHallPanel.Name = "readingHallPanel";
            this.readingHallPanel.Size = new System.Drawing.Size(306, 215);
            this.readingHallPanel.TabIndex = 28;
            // 
            // ShelfNumber
            // 
            this.ShelfNumber.Location = new System.Drawing.Point(38, 159);
            this.ShelfNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ShelfNumber.Name = "ShelfNumber";
            this.ShelfNumber.Size = new System.Drawing.Size(231, 29);
            this.ShelfNumber.TabIndex = 29;
            this.ShelfNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RackNumber
            // 
            this.RackNumber.Location = new System.Drawing.Point(38, 103);
            this.RackNumber.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.RackNumber.Name = "RackNumber";
            this.RackNumber.Size = new System.Drawing.Size(231, 29);
            this.RackNumber.TabIndex = 28;
            this.RackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HallNumber
            // 
            this.HallNumber.Location = new System.Drawing.Point(37, 42);
            this.HallNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.HallNumber.Name = "HallNumber";
            this.HallNumber.Size = new System.Drawing.Size(232, 29);
            this.HallNumber.TabIndex = 27;
            this.HallNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Номер читального зала";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Номер стеллажа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Номер полки";
            // 
            // panelAddBook
            // 
            this.panelAddBook.Controls.Add(this.label8);
            this.panelAddBook.Controls.Add(this.BCancel);
            this.panelAddBook.Controls.Add(this.readingHallPanel);
            this.panelAddBook.Controls.Add(this.Title);
            this.panelAddBook.Controls.Add(this.Year);
            this.panelAddBook.Controls.Add(this.label1);
            this.panelAddBook.Controls.Add(this.LibraryCode);
            this.panelAddBook.Controls.Add(this.label2);
            this.panelAddBook.Controls.Add(this.label3);
            this.panelAddBook.Controls.Add(this.SaveBook);
            this.panelAddBook.Controls.Add(this.label4);
            this.panelAddBook.Controls.Add(this.RemoveAuthor);
            this.panelAddBook.Controls.Add(this.Place);
            this.panelAddBook.Controls.Add(this.AddAuthor);
            this.panelAddBook.Controls.Add(this.Publisher);
            this.panelAddBook.Controls.Add(this.listBoxAuthors);
            this.panelAddBook.Controls.Add(this.label5);
            this.panelAddBook.Controls.Add(this.label9);
            this.panelAddBook.Controls.Add(this.AvailableCopies);
            this.panelAddBook.Controls.Add(this.AuthorName);
            this.panelAddBook.Controls.Add(this.ReadingHallOnly);
            this.panelAddBook.Controls.Add(this.MaxLoanDays);
            this.panelAddBook.Controls.Add(this.BooksCategory);
            this.panelAddBook.Controls.Add(this.label6);
            this.panelAddBook.Controls.Add(this.Category);
            this.panelAddBook.Controls.Add(this.label7);
            this.panelAddBook.Location = new System.Drawing.Point(247, 12);
            this.panelAddBook.Name = "panelAddBook";
            this.panelAddBook.Size = new System.Drawing.Size(803, 690);
            this.panelAddBook.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(236, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 29);
            this.label8.TabIndex = 58;
            this.label8.Text = "Заполните данные о книге";
            // 
            // AvailableCopies
            // 
            this.AvailableCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableCopies.Location = new System.Drawing.Point(87, 377);
            this.AvailableCopies.Name = "AvailableCopies";
            this.AvailableCopies.Size = new System.Drawing.Size(232, 29);
            this.AvailableCopies.TabIndex = 10;
            this.AvailableCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(86, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Доступное количество";
            // 
            // AddEditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 725);
            this.Controls.Add(this.panelAddBook);
            this.Name = "AddEditBookForm";
            this.Text = "Добавление книги";
            ((System.ComponentModel.ISupportInitialize)(this.MaxLoanDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            this.readingHallPanel.ResumeLayout(false);
            this.readingHallPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RackNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HallNumber)).EndInit();
            this.panelAddBook.ResumeLayout(false);
            this.panelAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCopies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MaxLoanDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label BooksCategory;
        private System.Windows.Forms.CheckBox ReadingHallOnly;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxAuthors;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.Button RemoveAuthor;
        private System.Windows.Forms.Button SaveBook;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.MaskedTextBox LibraryCode;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.Panel readingHallPanel;
        private System.Windows.Forms.NumericUpDown ShelfNumber;
        private System.Windows.Forms.NumericUpDown RackNumber;
        private System.Windows.Forms.NumericUpDown HallNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelAddBook;
        private System.Windows.Forms.NumericUpDown AvailableCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}