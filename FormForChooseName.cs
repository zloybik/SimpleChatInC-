using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormForChooseName : Form
    {
        public FormForChooseName()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = this.NameTextBox.Text;
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == Convert.ToChar(" "))
                {
                    this.ErrorInNameLabel.Visible = true;
                    this.EndRegistryButton.Enabled = false;
                }
                else
                {
                    this.ErrorInNameLabel.Visible = false;
                    this.EndRegistryButton.Enabled = true;
                }
            }
        }

        private void EndRegistryButton_Click(object sender, EventArgs e)
        {
            if (CheckHaveNameDB(this.NameTextBox.Text))
                MessageBox.Show("Данное имя уже есть в датабазе");
            else
            {
                string login, password;
                using (StreamReader stream = new StreamReader("Login.txt"))
                {
                    login = stream.ReadLine();
                }
                using (StreamReader stream = new StreamReader("Password.txt"))
                {
                    password = stream.ReadLine();
                }

                File.Delete("Login.txt");
                File.Delete("Password.txt");

                DB db = new DB();
                MySqlCommand dcmd = new MySqlCommand("INSERT INTO `accounts` (`login`, `password`, `name`, `date`) VALUES (@uL, @uP, @uN, @uD);", db.getConnection());
   

                dcmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                dcmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
                dcmd.Parameters.Add("@uN", MySqlDbType.VarChar).Value = this.NameTextBox.Text;
                dcmd.Parameters.Add("@uD", MySqlDbType.Date).Value = DateTime.Now;

                db.openConnection();

                if (dcmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт зарегестрирован!");
                }

                else
                    MessageBox.Show("Не удалось зарегестрировать аккаунт");

                db.closeConnection();
                this.Close();
            }
        }
        public Boolean CheckHaveNameDB(String name)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand dcmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `name` = @uL", db.getConnection());

            dcmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = name;

            adapter.SelectCommand = dcmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
