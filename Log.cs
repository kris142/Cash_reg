using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сash_register
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Enter_cl(object sender, EventArgs e)
        {
            string[] login = File.ReadAllLines(GlobalPath.LogFilePath);
            string[] password = File.ReadAllLines(GlobalPath.PasswordFilePath);
            string[] user_name = File.ReadAllLines(GlobalPath.UserFilePath);
            DateTime currentTime = DateTime.Now;

            if (login_.Text.Length < 2 || password_.Text.Length < 2)
            {
                MessageBox.Show("Текстовые поля меньше двух символов");
            }
            else
            {
                bool loggedIn = false;

                if (login_.Text == "admin" && password_.Text == "admin")
                {
                    Acc.access = "admin";
                    Acc.name = "admin";
                    MessageBox.Show("Добро пожаловать уважаемый Админ");
                    this.Close();
                    loggedIn = true;
                    home home = new home();
                    home.Show();
                }
                else
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (login_.Text == login[i] && password_.Text == password[i])
                        {
                            Acc.access = "cashier";
                            Acc.name = user_name[i];
                            label3.Text = "";
                            MessageBox.Show("Добро пожаловать");
                            this.Close();
                            loggedIn = true;
                            home home = new home();
                            home.Show();
                        }
                    }
                }
                if (!loggedIn)
                {
                    label3.Text = "Неверные данные";
                }
                if (loggedIn)
                {
                    File.AppendAllText(GlobalPath.LogiFilePath, $"В {currentTime} {Acc.name} вошел в систему" + Environment.NewLine);
                }
            }
        }
        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 97 || e.KeyChar >= 122) && (e.KeyChar <= 65 || e.KeyChar >= 90) && number != 8 && number != 'A' && number != 'a' && number != 'Z' && number != 'z' && number != '_' && number != '.' && number != '-') e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) => password_.UseSystemPasswordChar = checkBox1.Checked ? false : true;

        private void button2_Click(object sender, EventArgs e)
        {
            home home = new home();
            this.Close();
            home.Show();
        }
    }
}
