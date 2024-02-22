namespace WindowsFormsApp2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.NameWhoFind = new System.Windows.Forms.Label();
            this.AvatarPicBox = new System.Windows.Forms.PictureBox();
            this.DataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(231, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Напишите имя кого хотите добавить в друзья";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(12, 51);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(230, 39);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "label2";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResultLabel.Visible = false;
            // 
            // NameWhoFind
            // 
            this.NameWhoFind.AutoSize = true;
            this.NameWhoFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameWhoFind.Location = new System.Drawing.Point(93, 122);
            this.NameWhoFind.Name = "NameWhoFind";
            this.NameWhoFind.Size = new System.Drawing.Size(35, 13);
            this.NameWhoFind.TabIndex = 3;
            this.NameWhoFind.Text = "label2";
            this.NameWhoFind.Visible = false;
            this.NameWhoFind.Click += new System.EventHandler(this.NameWhoFind_Click);
            // 
            // AvatarPicBox
            // 
            this.AvatarPicBox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPicBox.Image")));
            this.AvatarPicBox.Location = new System.Drawing.Point(11, 111);
            this.AvatarPicBox.Name = "AvatarPicBox";
            this.AvatarPicBox.Size = new System.Drawing.Size(76, 71);
            this.AvatarPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarPicBox.TabIndex = 4;
            this.AvatarPicBox.TabStop = false;
            this.AvatarPicBox.Visible = false;
            // 
            // DataLabel
            // 
            this.DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DataLabel.Location = new System.Drawing.Point(93, 150);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(155, 32);
            this.DataLabel.TabIndex = 5;
            this.DataLabel.Text = "label2";
            this.DataLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 344);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.AvatarPicBox);
            this.Controls.Add(this.NameWhoFind);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "H4rmy chat | Welcome!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label NameWhoFind;
        private System.Windows.Forms.PictureBox AvatarPicBox;
        private System.Windows.Forms.Label DataLabel;
    }
}