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
            DateTime currentTime = DateTime.Now;
            if (ItemsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ItemsList.SelectedItems[0];
                string name = @"C:\app\data\name.txt";
                string description = @"C:\app\data\description.txt";
                string price = @"C:\app\data\price.txt";
                string weight = @"C:\app\data\weight.txt";
                int index = selectedItem.Index;
                string nameSel = selectedItem.Text;
                List<string> nameList = File.ReadAllLines(name).ToList();
                List<string> descriptionList = File.ReadAllLines(description).ToList();
                List<string> priceList = File.ReadAllLines(price).ToList();
                List<string> weightList = File.ReadAllLines(weight).ToList();
                if (index >= 0 && index < nameList.Count)
                {
                    nameList.RemoveAt(index);
                    descriptionList.RemoveAt(index);
                    priceList.RemoveAt(index);
                    weightList.RemoveAt(index);
                    File.WriteAllLines(name, nameList);
                    File.WriteAllLines(description, descriptionList);
                    File.WriteAllLines(price, priceList);
                    File.WriteAllLines(weight, weightList);
                }
                File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} удалил {nameSel}" + Environment.NewLine);

                ItemsList.Items.Remove(selectedItem);
            }

        }
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
