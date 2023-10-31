using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Сash_register
{
    internal class CashRegister
    {
        private static string[] name = File.ReadAllLines(@"C:\app\data\name.txt");
        private static string[] description = File.ReadAllLines(@"C:\app\data\description.txt");
        private static string[] price = File.ReadAllLines(@"C:\app\data\price.txt");
        private static string[] weight = File.ReadAllLines(@"C:\app\data\weight.txt");
        private static int sum = 0;
        public static string[] name_get()
        {
            return CashRegister.name;
        }

        public static string[] description_get()
        {
            return CashRegister.description;
        }

        public static string[] price_get()
        {
            return CashRegister.price;
        }
        public static string[] weight_get()
        {
            return CashRegister.weight;
        }
        public static void addElem(string name, string description, string price, string weight)
        {
            string path = @"C:\app\data\";
            string[] fileNames = { "name.txt", "description.txt", "price.txt", "weight.txt" };
            File.AppendAllText(path + "name.txt", name + "\n");
            File.AppendAllText(path + "description.txt", description + "\n");
            File.AppendAllText(path + "price.txt", price + "\n");
            File.AppendAllText(path + "weight.txt", weight + "\n");
            CashRegister.name = File.ReadAllLines(path + "name.txt");
            CashRegister.description = File.ReadAllLines(path + "description.txt");
            CashRegister.price = File.ReadAllLines(path + "price.txt");
            CashRegister.weight = File.ReadAllLines(path + "weight.txt");
        }
        public static void removeElement(string name)
        {
            string path = @"C:\app\data\";

            int num = CashRegister.name.ToList().IndexOf(name);

            List<string> nameList = new List<string>(CashRegister.name);
            List<string> descriptionList = new List<string>(CashRegister.description);
            List<string> priceList = new List<string>(CashRegister.price);
            List<string> weightList = new List<string>(CashRegister.weight);

            if (num >= 0)
            {
                nameList.RemoveAt(num);
                descriptionList.RemoveAt(num);
                priceList.RemoveAt(num);
                weightList.RemoveAt(num);

                CashRegister.name = nameList.ToArray();
                CashRegister.description = descriptionList.ToArray();
                CashRegister.price = priceList.ToArray();
                CashRegister.weight = weightList.ToArray();

                File.WriteAllLines(path + "name.txt", CashRegister.name);
                File.WriteAllLines(path + "description.txt", CashRegister.description);
                File.WriteAllLines(path + "price.txt", CashRegister.price);
                File.WriteAllLines(path + "weight.txt", CashRegister.weight);
            }
        }

        private static ArrayList shopping_basket = new ArrayList();
        public static void shopping_basket_add(int quantity)
        {
            CashRegister.shopping_basket.Add(quantity.ToString());
        }

        public static void shopping_basket_remove(int index)
        {
            CashRegister.shopping_basket.RemoveAt(index);
        }
        public static void shopping_basket_clear()
        {
            CashRegister.shopping_basket.Clear();
        }

        public static void sum_add(int value)
        {
            CashRegister.sum += value;
        }

    }
}
