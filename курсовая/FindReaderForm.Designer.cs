namespace курсовая
{
    partial class FindReaderForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectReader = new System.Windows.Forms.Button();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibraryCardNumber
            // 
            this.LibraryCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibraryCardNumber.Location = new System.Drawing.Point(356, 75);
            this.LibraryCardNumber.Mask = "0000-0000";
            this.LibraryCardNumber.Name = "LibraryCardNumber";
            this.LibraryCardNumber.Size = new System.Drawing.Size(260, 40);
            this.LibraryCardNumber.TabIndex = 35;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(652, 154);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(191, 72);
            this.CancelButton.TabIndex = 37;
            this.CancelButton.Text = "Выход";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // SelectReader
            // 
            this.SelectReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectReader.Location = new System.Drawing.Point(390, 154);
            this.SelectReader.Name = "SelectReader";
            this.SelectReader.Size = new System.Drawing.Size(191, 72);
            this.SelectReader.TabIndex = 38;
            this.SelectReader.Text = "Выбрать";
            this.SelectReader.UseVisualStyleBackColor = true;
            this.SelectReader.Click += new System.EventHandler(this.SelectReader_Click);
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.label8);
            this.panelFind.Controls.Add(this.btnFind);
            this.panelFind.Controls.Add(this.LibraryCardNumber);
            this.panelFind.Controls.Add(this.CancelButton);
            this.panelFind.Controls.Add(this.SelectReader);
            this.panelFind.Location = new System.Drawing.Point(132, 115);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(942, 311);
            this.panelFind.TabIndex = 39;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(118, 154);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(191, 72);
            this.btnFind.TabIndex = 39;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(238, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(458, 29);
            this.label8.TabIndex = 58;
            this.label8.Text = "Введите номер читательского билета";
            // 
            // FindReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 574);
            this.Controls.Add(this.panelFind);
            this.Name = "FindReaderForm";
            this.Text = "Поиск читателя";
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox LibraryCardNumber;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectReader;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label8;
    }
}