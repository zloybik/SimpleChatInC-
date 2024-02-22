namespace WindowsFormsApp2
{
    partial class FormForChooseName
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
            this.components = new System.ComponentModel.Container();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SayChooseNameLabel = new System.Windows.Forms.Label();
            this.EndRegistryButton = new System.Windows.Forms.Button();
            this.ErrorInNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 60);
            this.NameTextBox.MaxLength = 32;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(235, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SayChooseNameLabel
            // 
            this.SayChooseNameLabel.AutoSize = true;
            this.SayChooseNameLabel.Location = new System.Drawing.Point(12, 44);
            this.SayChooseNameLabel.Name = "SayChooseNameLabel";
            this.SayChooseNameLabel.Size = new System.Drawing.Size(101, 13);
            this.SayChooseNameLabel.TabIndex = 2;
            this.SayChooseNameLabel.Text = "Введите ваше имя";
            // 
            // EndRegistryButton
            // 
            this.EndRegistryButton.Enabled = false;
            this.EndRegistryButton.Location = new System.Drawing.Point(160, 104);
            this.EndRegistryButton.Name = "EndRegistryButton";
            this.EndRegistryButton.Size = new System.Drawing.Size(86, 38);
            this.EndRegistryButton.TabIndex = 3;
            this.EndRegistryButton.Text = "Закончить регистрацию";
            this.EndRegistryButton.UseVisualStyleBackColor = true;
            this.EndRegistryButton.Click += new System.EventHandler(this.EndRegistryButton_Click);
            // 
            // ErrorInNameLabel
            // 
            this.ErrorInNameLabel.AutoSize = true;
            this.ErrorInNameLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorInNameLabel.Location = new System.Drawing.Point(12, 83);
            this.ErrorInNameLabel.Name = "ErrorInNameLabel";
            this.ErrorInNameLabel.Size = new System.Drawing.Size(162, 13);
            this.ErrorInNameLabel.TabIndex = 4;
            this.ErrorInNameLabel.Text = "Нельзя иметь пробел в имени";
            this.ErrorInNameLabel.Visible = false;
            // 
            // FormForChooseName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 147);
            this.Controls.Add(this.ErrorInNameLabel);
            this.Controls.Add(this.EndRegistryButton);
            this.Controls.Add(this.SayChooseNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.MaximizeBox = false;
            this.Name = "FormForChooseName";
            this.Text = "Последний шаг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label SayChooseNameLabel;
        private System.Windows.Forms.Button EndRegistryButton;
        private System.Windows.Forms.Label ErrorInNameLabel;
    }
}