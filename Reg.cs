using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сash_register
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }
        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 97 || e.KeyChar >= 122) && (e.KeyChar <= 65 || e.KeyChar >= 90) && number != 8 && number != 'A' && number != 'a' && number != 'Z' && number != 'z' && number != '_' && number != '.' && number != '-') e.Handled = true;
        }
        private void Reg_Click(object sender, EventArgs e)
        {
            home home = new home();
            if (log.Text.Length < 2 || pass1.Text.Length < 2 || pass2.Text.Length < 2)
            {
                MessageBox.Show("Текстовые поля меньше двух символов");
            }
            else
            {
                string[] login = File.ReadAllLines(@"C:\app\log.txt");
                if (login.Contains(log.Text))
                {
                    MessageBox.Show("Логин уже занят");
                }
                else if (pass1.Text == pass2.Text)
                {
                    string l = @"C:\app\log.txt";
                    string p = @"C:\app\pass.txt";
                    string u = @"C:\app\user.txt";
                    File.AppendAllText(l, (log.Text + "\n"));
                    File.AppendAllText(p, (pass1.Text + "\n"));
                    File.AppendAllText(u, (user_name.Text + "\n"));
                    MessageBox.Show("Регистрация успешна");
                    this.Close();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
        }

        private void user_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!
    ((l >= 'А' && l <= 'я')
    || (l >= '0' && l <= '9')
    || l == 'ё'
    || l == 'Ё'
    || l == '\b')) { e.Handled = true; } 
        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
