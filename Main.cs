using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /* static void Main2()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 7000);

            NetworkStream stream = tcpClient.GetStream();
            byte[] buffer = new byte[1024];
            stream.Read(buffer, 0, buffer.Length);
            string end = Encoding.ASCII.GetString(buffer);
            MessageBox.Show(end);
            tcpClient.Close();
        } */

        public Boolean CheckHaveNameDB(string name)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand dcmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `name` = @uL", db.getConnection());

            dcmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = name;

            adapter.SelectCommand = dcmd;
            adapter.Fill(table);
           

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ResultLabel.Text = "Идет поиск...";
            this.ResultLabel.ForeColor = Color.Black;
            this.ResultLabel.Visible = true;
            this.AvatarPicBox.Visible = false;
            this.DataLabel.Visible = false;
            if (CheckHaveNameDB(this.NameTextBox.Text))
            {
                this.ResultLabel.ForeColor = Color.Green;
                this.ResultLabel.Text = "Человек найден!";
                this.AvatarPicBox.Visible = true;
                this.NameWhoFind.Text = this.NameTextBox.Text;
                this.NameWhoFind.Visible = true;

                string buffer = "";

                DB db = new DB();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();

                    using (MySqlCommand dcmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `name` = @uL", connection))
                    {
                        dcmd.Parameters.AddWithValue("@uL", this.NameTextBox.Text);

                        using (MySqlDataReader reader = dcmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buffer = Convert.ToString(reader["date"]);
                            }
                        }
                    }
                }
                buffer = buffer.Substring(0, buffer.Length - 7);
                this.DataLabel.Text = "Зарегестрирован с " + buffer;
                this.DataLabel.Visible = true;
            }            
            else
            {
                this.ResultLabel.ForeColor = Color.Red;
                this.ResultLabel.Text = "Человек не найден! Проверьте имя на отпечатки";
                this.NameWhoFind.Visible = false;
                this.AvatarPicBox.Visible = false;
                this.DataLabel.Visible= false;
            }
        }

        private void NameWhoFind_Click(object sender, EventArgs e)
        {
            Chat form = new Chat();
            form.Show();
        }
    }
}
