using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void LogButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand dcmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            dcmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value= this.LoginTextBox.Text;
            dcmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = this.PasswordTextBox.Text;

            adapter.SelectCommand = dcmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
                MessageBox.Show("Вы успешно залогинились!");

            }
            else
                MessageBox.Show("Ошибка в логине или в пароле");
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (CheckHaveUserDB(this.LoginTextBox.Text, this.PasswordTextBox.Text))
                MessageBox.Show("Данный пользеватель есть в базе данных");
            else
            {

                using(StreamWriter stream = new StreamWriter("Login.txt"))
                {
                    stream.WriteLine(this.LoginTextBox.Text);
                }

                using (StreamWriter stream = new StreamWriter("Password.txt"))
                {
                    stream.WriteLine(this.PasswordTextBox.Text);
                }

                FormForChooseName form = new FormForChooseName();
                form.Show();
            }

        }
        public Boolean CheckHaveUserDB(String login, String password)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand dcmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            dcmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            dcmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = dcmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.PasswordTextBox.Text;
            if ((text.Length == 0 && this.LoginTextBox.Text.Length == 0) || text.Length == 0 || this.LoginTextBox.Text.Length == 0)
            {
                this.RegButton.Enabled = false;
                this.LogButton.Enabled = false;
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {

                    if (Convert.ToString(text[i]) == " ")
                    {
                        this.RegButton.Enabled = false;
                        this.LogButton.Enabled = false;
                        this.ProblemInLoginOrPassLabel.Visible = true;
                        break;
                    }
                    else
                    {
                        this.RegButton.Enabled = true;
                        this.LogButton.Enabled = true;
                        this.ProblemInLoginOrPassLabel.Visible = false;
                    }
                }
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.LoginTextBox.Text;
            if((text.Length == 0 && this.PasswordTextBox.Text.Length == 0) || text.Length == 0 || this.PasswordTextBox.Text.Length == 0)
            {
                this.RegButton.Enabled = false;
                this.LogButton.Enabled = false;
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {

                    if (Convert.ToString(text[i]) == " ")
                    {
                        this.RegButton.Enabled = false;
                        this.LogButton.Enabled = false;
                        this.ProblemInLoginOrPassLabel.Visible = true;
                        break;
                    }
                    else
                    {
                        this.RegButton.Enabled = true;
                        this.LogButton.Enabled = true;
                        this.ProblemInLoginOrPassLabel.Visible = false;
                    }
                }
            }
        }
    }
}
