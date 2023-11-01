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
        public static string[] name_get() => CashRegister.name;
        public static string[] description_get() => CashRegister.description;
        public static string[] price_get() => CashRegister.price;
        public static string[] weight_get() => CashRegister.weight;
        private static ArrayList shopping_basket = new ArrayList();
        public static void addElem(string name, string description, string price, string weight)
        {
            string path = @"C:\app\data\";
            string[] fileNames = { "name.txt", "description.txt", "price.txt", "weight.txt" };
            string[] dataToWrite = { name, description, price, weight };
            for (int i = 0; i < fileNames.Length; i++)
            {
                string dataFilePath = Path.Combine(path, fileNames[i]);
                File.AppendAllText(dataFilePath, dataToWrite[i] + Environment.NewLine);
                switch (i)
                {
                    case 0: CashRegister.name = File.ReadAllLines(dataFilePath); break;
                    case 1: CashRegister.description = File.ReadAllLines(dataFilePath); break;
                    case 2: CashRegister.price = File.ReadAllLines(dataFilePath); break;
                    case 3: CashRegister.weight = File.ReadAllLines(dataFilePath); break;
                }
            }
        }
        public static void removeDish(string name)
        {
            string path = @"C:\app\data\";
            string nameToRemove = name;
            int index = Array.IndexOf(CashRegister.name, nameToRemove);
            if (index >= 0)
            {
                List<string> nameList = CashRegister.name.ToList();
                List<string> descriptionList = CashRegister.description.ToList();
                List<string> priceList = CashRegister.price.ToList();
                List<string> weightList = CashRegister.weight.ToList();

                nameList.RemoveAt(index);
                descriptionList.RemoveAt(index);
                priceList.RemoveAt(index);
                weightList.RemoveAt(index);

                CashRegister.name = nameList.ToArray();
                CashRegister.description = descriptionList.ToArray();
                CashRegister.price = priceList.ToArray();
                CashRegister.weight = weightList.ToArray();

                File.WriteAllLines(Path.Combine(path, "name.txt"), CashRegister.name);
                File.WriteAllLines(Path.Combine(path, "description.txt"), CashRegister.description);
                File.WriteAllLines(Path.Combine(path, "price.txt"), CashRegister.price);
                File.WriteAllLines(Path.Combine(path, "weight.txt"), CashRegister.weight);
            }

        }
        public static void shopping_basket_add(int quantity) => CashRegister.shopping_basket.Add(quantity.ToString());
        public static void shopping_basket_clear() => CashRegister.shopping_basket.Clear();
        public static void sum_add(int value) => CashRegister.sum += value;

    }
}
