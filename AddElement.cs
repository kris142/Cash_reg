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
            DateTime currentTime = DateTime.Now;
            ListViewItem listViewItem = new ListViewItem(this.nametextbox.Text);
            listViewItem.SubItems.Add(this.descriptextbox.Text);
            listViewItem.SubItems.Add(this.weightbox.Text);
            listViewItem.SubItems.Add(this.pricebox.Text);
            this.ItemsList.Items.Add(listViewItem);
            CashRegister.addElem(this.nametextbox.Text, this.descriptextbox.Text, this.weightbox.Text, this.pricebox.Text);
            File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} добавил {this.nametextbox.Text}" + Environment.NewLine);
            descriptextbox.Text = weightbox.Text = pricebox.Text = nametextbox.Text = "";
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
    }
}
