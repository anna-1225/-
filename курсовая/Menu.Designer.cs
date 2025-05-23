namespace курсовая
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.catalogButton = new System.Windows.Forms.Button();
            this.IssueAndReturnButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ReadersButton = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogButton
            // 
            this.catalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogButton.Location = new System.Drawing.Point(131, 345);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.Size = new System.Drawing.Size(272, 70);
            this.catalogButton.TabIndex = 0;
            this.catalogButton.Text = "Управление книгами";
            this.catalogButton.UseVisualStyleBackColor = true;
            this.catalogButton.Click += new System.EventHandler(this.catalogButton_Click);
            // 
            // IssueAndReturnButton
            // 
            this.IssueAndReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssueAndReturnButton.Location = new System.Drawing.Point(131, 141);
            this.IssueAndReturnButton.Name = "IssueAndReturnButton";
            this.IssueAndReturnButton.Size = new System.Drawing.Size(272, 70);
            this.IssueAndReturnButton.TabIndex = 1;
            this.IssueAndReturnButton.Text = "Выдача и возврат";
            this.IssueAndReturnButton.UseVisualStyleBackColor = true;
            this.IssueAndReturnButton.Click += new System.EventHandler(this.IssueAndReturnButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportsButton.Location = new System.Drawing.Point(131, 243);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(272, 70);
            this.ReportsButton.TabIndex = 2;
            this.ReportsButton.Text = "Отчеты";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(131, 451);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(272, 70);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Управление читателями";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(131, 558);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(272, 70);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReadersButton
            // 
            this.ReadersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadersButton.Location = new System.Drawing.Point(131, 43);
            this.ReadersButton.Name = "ReadersButton";
            this.ReadersButton.Size = new System.Drawing.Size(272, 70);
            this.ReadersButton.TabIndex = 5;
            this.ReadersButton.Text = "Регистрация";
            this.ReadersButton.UseVisualStyleBackColor = true;
            this.ReadersButton.Click += new System.EventHandler(this.ReadersButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.ExitButton);
            this.panelMenu.Controls.Add(this.ReadersButton);
            this.panelMenu.Controls.Add(this.IssueAndReturnButton);
            this.panelMenu.Controls.Add(this.ReportsButton);
            this.panelMenu.Controls.Add(this.SettingsButton);
            this.panelMenu.Controls.Add(this.catalogButton);
            this.panelMenu.Location = new System.Drawing.Point(454, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(505, 664);
            this.panelMenu.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1473, 841);
            this.Controls.Add(this.panelMenu);
            this.Name = "Menu";
            this.Text = "Меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catalogButton;
        private System.Windows.Forms.Button IssueAndReturnButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ReadersButton;
        private System.Windows.Forms.Panel panelMenu;
    }
}

