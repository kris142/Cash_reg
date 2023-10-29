using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            string filePath = @"C:\app\data\";
            string[] fileNames = { "name.txt", "description.txt", "price.txt", "weight.txt" };
            List<List<string>> data = new List<List<string>>();
            for (int i = 0; i < fileNames.Length; i++)
            {
                string dataFilePath = Path.Combine(filePath, fileNames[i]);
                using (StreamWriter writer = File.AppendText(dataFilePath))
                {
                    writer.WriteLine(i == 0 ? name : i == 1 ? description : i == 2 ? price : weight);
                }
            }
            for (int i = 0; i < fileNames.Length; i++)
            {
                string dataFilePath = Path.Combine(filePath, fileNames[i]);
                List<string> dataList = new List<string>();

                using (StreamReader reader = File.OpenText(dataFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        dataList.Add(line);
                    }
                }
                data.Add(dataList);
            }/*
            List<string> names = data[0];
            List<string> descriptions = data[1];
            List<string> prices = data[2];
            List<string> weights = data[3];*/

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
