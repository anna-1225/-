namespace курсовая
{
    partial class Library
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
            this.AddBooks = new System.Windows.Forms.Button();
            this.EditBooks = new System.Windows.Forms.Button();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBooks
            // 
            this.AddBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBooks.Location = new System.Drawing.Point(83, 206);
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(197, 93);
            this.AddBooks.TabIndex = 0;
            this.AddBooks.Text = "Добавить книгу";
            this.AddBooks.UseVisualStyleBackColor = true;
            this.AddBooks.Click += new System.EventHandler(this.AddBooks_Click);
            // 
            // EditBooks
            // 
            this.EditBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBooks.Location = new System.Drawing.Point(358, 206);
            this.EditBooks.Name = "EditBooks";
            this.EditBooks.Size = new System.Drawing.Size(197, 93);
            this.EditBooks.TabIndex = 1;
            this.EditBooks.Text = "Редактирование и удаление";
            this.EditBooks.UseVisualStyleBackColor = true;
            this.EditBooks.Click += new System.EventHandler(this.EditBooks_Click);
            // 
            // panelLibrary
            // 
            this.panelLibrary.Controls.Add(this.label1);
            this.panelLibrary.Controls.Add(this.buttonExit);
            this.panelLibrary.Controls.Add(this.AddBooks);
            this.panelLibrary.Controls.Add(this.EditBooks);
            this.panelLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelLibrary.Location = new System.Drawing.Point(190, 70);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(916, 538);
            this.panelLibrary.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(633, 206);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(197, 93);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(353, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите действие";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1667, 767);
            this.Controls.Add(this.panelLibrary);
            this.Name = "Library";
            this.Text = "Управление книгами";
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBooks;
        private System.Windows.Forms.Button EditBooks;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}