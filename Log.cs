﻿using System;
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
            string[] login = File.ReadAllLines(@"C:\app\log.txt");
            string[] password = File.ReadAllLines(@"C:\app\pass.txt");
            string[] user_name = File.ReadAllLines(@"C:\app\user_name.txt");
            DateTime currentTime = DateTime.Now;
            if (login_.Text.Length < 2 || password_.Text.Length < 2)
            {
                MessageBox.Show("Текстовые поля меньше двух символов");
            }
            else
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login_.Text == "admin" && password_.Text == "admin")
                    {
                        Acc.access = "admin";
                        Acc.name = "admin";
                        MessageBox.Show("Добро пожаловать уважаемый Админ");
                        this.Close();
                        break;
                    }
                    else if (login_.Text == login[i] & password_.Text == password[i])
                    {
                        Acc.access = "cashier";
                        Acc.name = user_name[i];
                        label3.Text = "";
                        MessageBox.Show("Добро пожаловать");
                        this.Close();
                        break;
                    }
                    else
                    {
                        label3.Text = "Неверные данные";
                    }
                    File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} вошел в систему" + Environment.NewLine);

                }
            }
        }
        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 97 || e.KeyChar >= 122) && (e.KeyChar <= 65 || e.KeyChar >= 90) && number != 8 && number != 'A' && number != 'a' && number != 'Z' && number != 'z' && number != '_' && number != '.' && number != '-') e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_.UseSystemPasswordChar = false;
            }
            else
            {
                password_.UseSystemPasswordChar = true;
            }
        }
    }
}