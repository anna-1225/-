namespace курсовая
{
    partial class BookSearch
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
            this.FindBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByCode = new System.Windows.Forms.RadioButton();
            this.SearchByTitle = new System.Windows.Forms.RadioButton();
            this.SearchBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorsBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.EditBook = new System.Windows.Forms.Button();
            this.TakeBook = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindBook
            // 
            this.FindBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindBook.Location = new System.Drawing.Point(290, 79);
            this.FindBook.Name = "FindBook";
            this.FindBook.Size = new System.Drawing.Size(327, 29);
            this.FindBook.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название или шифр книги:";
            // 
            // SearchByCode
            // 
            this.SearchByCode.AutoSize = true;
            this.SearchByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByCode.Location = new System.Drawing.Point(290, 114);
            this.SearchByCode.Name = "SearchByCode";
            this.SearchByCode.Size = new System.Drawing.Size(114, 28);
            this.SearchByCode.TabIndex = 2;
            this.SearchByCode.TabStop = true;
            this.SearchByCode.Text = "по шифру";
            this.SearchByCode.UseVisualStyleBackColor = true;
            // 
            // SearchByTitle
            // 
            this.SearchByTitle.AutoSize = true;
            this.SearchByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByTitle.Location = new System.Drawing.Point(474, 114);
            this.SearchByTitle.Name = "SearchByTitle";
            this.SearchByTitle.Size = new System.Drawing.Size(143, 28);
            this.SearchByTitle.TabIndex = 3;
            this.SearchByTitle.TabStop = true;
            this.SearchByTitle.Text = "по названию";
            this.SearchByTitle.UseVisualStyleBackColor = true;
            // 
            // SearchBook
            // 
            this.SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBook.Location = new System.Drawing.Point(389, 148);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(115, 35);
            this.SearchBook.TabIndex = 4;
            this.SearchBook.Text = "Найти";
            this.SearchBook.UseVisualStyleBackColor = true;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.LibraryCode,
            this.AuthorsBook,
            this.PublisherBook,
            this.YearBook,
            this.LocationBook});
            this.dgvBooks.Location = new System.Drawing.Point(52, 205);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(807, 269);
            this.dgvBooks.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // LibraryCode
            // 
            this.LibraryCode.HeaderText = "Шифр";
            this.LibraryCode.Name = "LibraryCode";
            this.LibraryCode.ReadOnly = true;
            // 
            // AuthorsBook
            // 
            this.AuthorsBook.HeaderText = "Авторы";
            this.AuthorsBook.Name = "AuthorsBook";
            this.AuthorsBook.ReadOnly = true;
            // 
            // PublisherBook
            // 
            this.PublisherBook.HeaderText = "Издательство";
            this.PublisherBook.Name = "PublisherBook";
            this.PublisherBook.ReadOnly = true;
            // 
            // YearBook
            // 
            this.YearBook.HeaderText = "Год";
            this.YearBook.Name = "YearBook";
            this.YearBook.ReadOnly = true;
            // 
            // LocationBook
            // 
            this.LocationBook.HeaderText = "Местоположение";
            this.LocationBook.Name = "LocationBook";
            this.LocationBook.ReadOnly = true;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(667, 532);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(192, 53);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBook.Location = new System.Drawing.Point(455, 532);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(192, 53);
            this.DeleteBook.TabIndex = 8;
            this.DeleteBook.Text = "Удалить";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // EditBook
            // 
            this.EditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBook.Location = new System.Drawing.Point(244, 532);
            this.EditBook.Name = "EditBook";
            this.EditBook.Size = new System.Drawing.Size(192, 53);
            this.EditBook.TabIndex = 9;
            this.EditBook.Text = "Редактировать";
            this.EditBook.UseVisualStyleBackColor = true;
            this.EditBook.Click += new System.EventHandler(this.EditBook_Click);
            // 
            // TakeBook
            // 
            this.TakeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeBook.Location = new System.Drawing.Point(32, 532);
            this.TakeBook.Name = "TakeBook";
            this.TakeBook.Size = new System.Drawing.Size(192, 53);
            this.TakeBook.TabIndex = 10;
            this.TakeBook.Text = "Взять книгу";
            this.TakeBook.UseVisualStyleBackColor = true;
            this.TakeBook.Click += new System.EventHandler(this.TakeBook_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.EditBook);
            this.panelSearch.Controls.Add(this.TakeBook);
            this.panelSearch.Controls.Add(this.FindBook);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.DeleteBook);
            this.panelSearch.Controls.Add(this.SearchByCode);
            this.panelSearch.Controls.Add(this.Cancel);
            this.panelSearch.Controls.Add(this.SearchByTitle);
            this.panelSearch.Controls.Add(this.dgvBooks);
            this.panelSearch.Controls.Add(this.SearchBook);
            this.panelSearch.Location = new System.Drawing.Point(174, 12);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(897, 616);
            this.panelSearch.TabIndex = 11;
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 704);
            this.Controls.Add(this.panelSearch);
            this.Name = "BookSearch";
            this.Text = "Поиск книг";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FindBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SearchByCode;
        private System.Windows.Forms.RadioButton SearchByTitle;
        private System.Windows.Forms.Button SearchBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button EditBook;
        private System.Windows.Forms.Button TakeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibraryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorsBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationBook;
        private System.Windows.Forms.Panel panelSearch;
    }
}