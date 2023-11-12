using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Сash_register
{
    public partial class home : Form
    {
        private List<string> products = new List<string>();

        public home()
        {
            InitializeComponent();
            Load += new EventHandler(Loadh);
        }

        private void сброситьАвторизациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acc.access = "none";
        }

        private void ent_acc(object sender, EventArgs e)
        {
            Log log = new Log();
            Close();
            log.Show();
        }

        private void exit(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Уверены что хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void add_dish(object sender, EventArgs e)
        {
            AddDish addElement = new AddDish();
            this.Close();
            this.Dispose();
            addElement.ShowDialog();
        }

        private void menuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = Acc.name;
            if (Acc.access == "admin")
            {
                adddish.Enabled = true;
                Register.Enabled = true;
                to_shopping_basket.Enabled = true;
                Menu_bas.Enabled = true;
            }
            else if (Acc.access == "cashier")
            {
                adddish.Enabled = false;
                Register.Enabled = false;
                to_shopping_basket.Enabled = true;
                Menu_bas.Enabled = true;
            }
            else if (Acc.access == "none")
            {
                adddish.Enabled = false;
                Register.Enabled = false;
                to_shopping_basket.Enabled = false;
                Menu_bas.Enabled = false;
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }
        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.ShowDialog();
        }

        private void product_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product_list.SelectedItem != null)
            {
                string selectedProduct = product_list.SelectedItem.ToString();

                if (product_list.SelectedIndices.Count > 0)
                {
                    int index = product_list.SelectedIndices[0];

                    if (index >= 0)
                    {
                        this.name.Text = selectedProduct;
                        this.price.Text = CashRegister.price_get()[index];
                        quantity1.Value = 1;
                    }
                }
            }
        }

        private void to_shopping_basket_Click(object sender, EventArgs e)
        {
            if (product_list.SelectedItem == null)
            {
                MessageBox.Show("Выберете блюдо");
            }
            else
            {
                int index = CashRegister.name_get().ToList().IndexOf(product_list.SelectedItem.ToString());
                DateTime currentTime = DateTime.Now;

                if (shopping_basket.Items.ContainsKey(CashRegister.name_get()[index]))
                {
                    int quantity = int.Parse(this.quantity1.Text);
                    int pricу = int.Parse(this.price.Text);
                    ListViewItem item = shopping_basket.Items[CashRegister.name_get()[index]];

                    int oldQuantity = int.Parse(item.SubItems[2].Text);
                    int oldAmount = int.Parse(item.SubItems[3].Text);

                    int newQuantity = oldQuantity + quantity;
                    int newAmount = oldAmount + (quantity * pricу);

                    item.SubItems[2].Text = newQuantity.ToString();
                    item.SubItems[3].Text = newAmount.ToString();
                    File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} добавил {CashRegister.name_get()[index]} - {quantity} шт" + "\n");
                }
                else
                {
                    int quantity = int.Parse(this.quantity1.Text);
                    int pricing = int.Parse(this.price.Text);
                    int amount = quantity * pricing;
                    CashRegister.shopping_basket_add(quantity);
                    CashRegister.sum_add(amount);
                    string[] itemText = { CashRegister.name_get()[index], pricing.ToString(), quantity.ToString(), amount.ToString() };
                    ListViewItem item = new ListViewItem(itemText);
                    item.Name = CashRegister.name_get()[index];
                    this.shopping_basket.Items.Add(item);
                    File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} добавил {CashRegister.name_get()[index]} - {quantity} шт" + "\n");
                }
                int currentSum = int.Parse(this.sum.Text);
                this.sum.Text = (currentSum + int.Parse(this.quantity1.Text) * int.Parse(this.price.Text)).ToString();
                quantity1.Value = 1;
            }
        }

        private void shopping_basket_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.removeselected.Enabled = true;
        }

        private void removeselected_Click(object sender, EventArgs e)
        {
            try
            {
                int indexs = CashRegister.name_get().ToList().IndexOf(product_list.SelectedItem.ToString());
                DateTime currentTime = DateTime.Now;
                if (product_list.SelectedItem == null || product_list.SelectedItem.ToString() == "0")
                {
                    MessageBox.Show("Error");
                }
                else if (indexs >= 0 && indexs < CashRegister.name_get().Count())
                {
                    if (shopping_basket.SelectedItems.Count > 0)
                    {
                        string selectedItem = shopping_basket.SelectedItems[0].Text;
                        int index = CashRegister.name_get().ToList().IndexOf(selectedItem);

                        if (index >= 0 && shopping_basket.Items.ContainsKey(CashRegister.name_get()[index]))
                        {
                            int quantity = 1;
                            ListViewItem item = shopping_basket.Items[CashRegister.name_get()[index]];
                            int oldQuantity = int.Parse(item.SubItems[2].Text);
                            int oldAmount = int.Parse(item.SubItems[3].Text);
                            int pricing = oldAmount / oldQuantity;

                            if (oldQuantity > 1)
                            {
                                int newQuantity = oldQuantity - quantity;
                                int newAmount = oldAmount - pricing;
                                item.SubItems[2].Text = newQuantity.ToString();
                                item.SubItems[3].Text = newAmount.ToString();
                                int currentSum = int.Parse(this.sum.Text);
                                this.sum.Text = (currentSum - pricing).ToString();
                                File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} удалил из корзины {CashRegister.name_get()[index]} - {quantity} шт" + "\n");
                            }
                            else
                            {
                                shopping_basket.Items.Remove(item);
                                int currentSum = int.Parse(this.sum.Text);
                                this.sum.Text = (currentSum - pricing).ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Товар не найден");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите элемент в корзине для удаления.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (shopping_basket.Items.Count > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                    {
                        foreach (ListViewItem item in shopping_basket.Items)
                        {
                            string line = $"{item.SubItems[0].Text} {item.SubItems[1].Text} руб. {item.SubItems[2].Text} шт. = {item.SubItems[3].Text} руб ";
                            streamWriter.WriteLine($"В {currentTime} {Acc.name} сделал экспорт");
                            streamWriter.WriteLine(line);
                        }

                        streamWriter.WriteLine($"Итого {sum.Text}");

                        CashRegister.shopping_basket_clear();
                        shopping_basket.Items.Clear();
                        sum.Text = "0";

                        File.AppendAllText("C:\\app\\logi.txt", $"В {currentTime} {Acc.name} сделал экспорт" + Environment.NewLine);
                    }
                }
            }
            else { MessageBox.Show("Корзина пуста, добавьте элемент"); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CashRegister.shopping_basket_clear();
            shopping_basket.Items.Clear();
            sum.Text = "0";
        }
        private void Loadh(object sender, EventArgs e)
        {
            products.AddRange(product_list.Items.Cast<string>());
            string[] newProducts = CashRegister.name_get();
            products.AddRange(newProducts);
            label2.Text = Acc.name;
            if (Acc.access == "admin")
            {
                adddish.Enabled = true;
                Register.Enabled = true;
                to_shopping_basket.Enabled = true;
                Menu_bas.Enabled = true;
            }
            else if (Acc.access == "cashier")
            {
                adddish.Enabled = false;
                Register.Enabled = false;
                to_shopping_basket.Enabled = true;
                Menu_bas.Enabled = true;
            }
            else if (Acc.access == "none")
            {
                adddish.Enabled = false;
                Register.Enabled = false;
                to_shopping_basket.Enabled = false;
                Menu_bas.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            product_list.Items.Clear();
            product_list.Items.AddRange(products.ToArray());
        }
    }
}
