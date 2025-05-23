namespace курсовая
{
    partial class ForUsers
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
            this.IssuanceBook = new System.Windows.Forms.Button();
            this.ReturnBook = new System.Windows.Forms.Button();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // IssuanceBook
            // 
            this.IssuanceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssuanceBook.Location = new System.Drawing.Point(19, 124);
            this.IssuanceBook.Name = "IssuanceBook";
            this.IssuanceBook.Size = new System.Drawing.Size(205, 83);
            this.IssuanceBook.TabIndex = 0;
            this.IssuanceBook.Text = "Выдача книг";
            this.IssuanceBook.UseVisualStyleBackColor = true;
            this.IssuanceBook.Click += new System.EventHandler(this.IssuanceBook_Click);
            // 
            // ReturnBook
            // 
            this.ReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnBook.Location = new System.Drawing.Point(281, 124);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(205, 83);
            this.ReturnBook.TabIndex = 1;
            this.ReturnBook.Text = "Возврат книг";
            this.ReturnBook.UseVisualStyleBackColor = true;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.label8);
            this.panelUsers.Controls.Add(this.buttonExit);
            this.panelUsers.Controls.Add(this.IssuanceBook);
            this.panelUsers.Controls.Add(this.ReturnBook);
            this.panelUsers.Location = new System.Drawing.Point(135, 154);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(770, 332);
            this.panelUsers.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(537, 124);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(205, 83);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(263, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 29);
            this.label8.TabIndex = 58;
            this.label8.Text = "Выберите действие";
            // 
            // ForUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 597);
            this.Controls.Add(this.panelUsers);
            this.Name = "ForUsers";
            this.Text = "Выдача и возврат";
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IssuanceBook;
        private System.Windows.Forms.Button ReturnBook;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label8;
    }
}