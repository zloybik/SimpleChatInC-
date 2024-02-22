namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.Label H4rmyChatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RegButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProblemInLoginOrPassLabel = new System.Windows.Forms.Label();
            H4rmyChatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // H4rmyChatLabel
            // 
            H4rmyChatLabel.BackColor = System.Drawing.SystemColors.Control;
            H4rmyChatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            H4rmyChatLabel.Location = new System.Drawing.Point(92, 115);
            H4rmyChatLabel.Name = "H4rmyChatLabel";
            H4rmyChatLabel.Size = new System.Drawing.Size(153, 103);
            H4rmyChatLabel.TabIndex = 2;
            H4rmyChatLabel.Text = "H4RMY CHAT";
            H4rmyChatLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegButton
            // 
            this.RegButton.Enabled = false;
            this.RegButton.Location = new System.Drawing.Point(12, 352);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(140, 86);
            this.RegButton.TabIndex = 0;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Enabled = false;
            this.LogButton.Location = new System.Drawing.Point(196, 352);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(140, 86);
            this.LogButton.TabIndex = 1;
            this.LogButton.Text = "Логиниться";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\image(1).png";
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginTextBox.Location = new System.Drawing.Point(42, 169);
            this.LoginTextBox.MaxLength = 100;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(267, 20);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.Tag = "";
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(43, 211);
            this.PasswordTextBox.MaxLength = 100;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(266, 20);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // ProblemInLoginOrPassLabel
            // 
            this.ProblemInLoginOrPassLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ProblemInLoginOrPassLabel.ForeColor = System.Drawing.Color.Red;
            this.ProblemInLoginOrPassLabel.Location = new System.Drawing.Point(39, 234);
            this.ProblemInLoginOrPassLabel.Name = "ProblemInLoginOrPassLabel";
            this.ProblemInLoginOrPassLabel.Size = new System.Drawing.Size(270, 29);
            this.ProblemInLoginOrPassLabel.TabIndex = 8;
            this.ProblemInLoginOrPassLabel.Text = "Недопустимые символы(Например пробел) в Логине или в Пароле";
            this.ProblemInLoginOrPassLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.ProblemInLoginOrPassLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(H4rmyChatLabel);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.RegButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "H4rmy chat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProblemInLoginOrPassLabel;
    }
}

