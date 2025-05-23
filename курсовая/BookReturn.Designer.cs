namespace курсовая
{
    partial class BookReturn
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
            this.lblReaderInfo = new System.Windows.Forms.Label();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelReturn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.panelReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReaderInfo
            // 
            this.lblReaderInfo.AutoSize = true;
            this.lblReaderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReaderInfo.Location = new System.Drawing.Point(87, 65);
            this.lblReaderInfo.Name = "lblReaderInfo";
            this.lblReaderInfo.Size = new System.Drawing.Size(70, 26);
            this.lblReaderInfo.TabIndex = 0;
            this.lblReaderInfo.Text = "label1";
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookTitle,
            this.BookCode,
            this.IssueDate,
            this.DueDate});
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(71, 124);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(611, 150);
            this.dgvBorrowedBooks.TabIndex = 1;
            // 
            // BookTitle
            // 
            this.BookTitle.HeaderText = "Название книги";
            this.BookTitle.Name = "BookTitle";
            // 
            // BookCode
            // 
            this.BookCode.HeaderText = "Шифр книги";
            this.BookCode.Name = "BookCode";
            this.BookCode.ReadOnly = true;
            // 
            // IssueDate
            // 
            this.IssueDate.HeaderText = "Дата выдачи";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Срок возврата";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturn.Location = new System.Drawing.Point(71, 289);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 60);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Вернуть книгу";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(358, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 60);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelReturn
            // 
            this.panelReturn.Controls.Add(this.dgvBorrowedBooks);
            this.panelReturn.Controls.Add(this.lblReaderInfo);
            this.panelReturn.Controls.Add(this.btnReturn);
            this.panelReturn.Controls.Add(this.btnClose);
            this.panelReturn.Location = new System.Drawing.Point(263, 64);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(787, 444);
            this.panelReturn.TabIndex = 4;
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 605);
            this.Controls.Add(this.panelReturn);
            this.Name = "BookReturn";
            this.Text = "Возврат книг";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReaderInfo;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelReturn;
    }
}