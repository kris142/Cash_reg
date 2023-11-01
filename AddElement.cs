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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Сash_register
{
    public partial class AddElement : Form
    {
        public AddElement()
        {
            InitializeComponent();
        }
        private void AddElement_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < CashRegister.price_get().Length; i++)
            {
                this.ItemsList.Items.Add(new ListViewItem(new string[]
                {
                    CashRegister.name_get()[i],
                    CashRegister.description_get()[i],
                    CashRegister.weight_get()[i],
                    CashRegister.price_get()[i]
                }));
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            string[] arr = File.ReadAllLines(@"C:\app\data\name.txt");
            if (descriptext.Text != "" && weight.Text != "" && price.Text != "" && namebox.Text != "" && !arr.Contains(this.namebox.Text))
            {
                DateTime currentTime = DateTime.Now;
                ListViewItem listViewItem = new ListViewItem(this.namebox.Text);
                listViewItem.SubItems.Add(this.descriptext.Text);
                listViewItem.SubItems.Add(this.weight.Text);
                listViewItem.SubItems.Add(this.price.Text);
                this.ItemsList.Items.Add(listViewItem);
                CashRegister.addElem(this.namebox.Text, this.descriptext.Text, this.weight.Text, this.price.Text);
                File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} добавил {this.namebox.Text}" + Environment.NewLine);
                descriptext.Text = weight.Text = price.Text = namebox.Text = "";
            }
            else
            {
                MessageBox.Show("Не все поля заполнены/ или элемент уже есть");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            Close();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            string selectedText = this.ItemsList.SelectedItems[0].Text;
            CashRegister.removeElement(selectedText);
            this.ItemsList.Items.Remove(this.ItemsList.SelectedItems[0]);
        }
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nametextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char text = e.KeyChar;
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || text == '-');
        }
    }
}
