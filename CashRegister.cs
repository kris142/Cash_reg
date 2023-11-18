using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Сash_register
{
    public class GlobalPath
    {
        public static string LogFilePath = @"log.txt";
        public static string PasswordFilePath = @"pass.txt";
        public static string UserFilePath = @"user.txt";

        public static string NameFilePath = @"data\name.txt";
        public static string DescriptionFilePath = @"data\description.txt";
        public static string PriceFilePath = @"data\price.txt";
        public static string WeightFilePath = @"data\weight.txt";

        public static string LogiFilePath = @"logi.txt";
    }

    internal class CashRegister
    {
        private static string[] name = File.ReadAllLines(GlobalPath.NameFilePath);
        private static string[] description = File.ReadAllLines(GlobalPath.DescriptionFilePath);
        private static string[] price = File.ReadAllLines(GlobalPath.PriceFilePath);
        private static string[] weight = File.ReadAllLines(GlobalPath.WeightFilePath);

        public static string[] name_get() => CashRegister.name;
        public static string[] description_get() => CashRegister.description;
        public static string[] price_get() => CashRegister.price;
        public static string[] weight_get() => CashRegister.weight;
        public static void addElem(string name, string description, string price, string weight)
        {
            string[] fileNames = { GlobalPath.NameFilePath, GlobalPath.DescriptionFilePath, GlobalPath.PriceFilePath, GlobalPath.WeightFilePath };
            string[] dataToWrite = { name, description, price, weight };

            for (int i = 0; i < fileNames.Length; i++)
            {
                string dataFilePath = fileNames[i];
                File.AppendAllText(dataFilePath, $"{dataToWrite[i]}{Environment.NewLine}");

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

                File.WriteAllLines(GlobalPath.NameFilePath, CashRegister.name);
                File.WriteAllLines(GlobalPath.DescriptionFilePath, CashRegister.description);
                File.WriteAllLines(GlobalPath.PriceFilePath, CashRegister.price);
                File.WriteAllLines(GlobalPath.WeightFilePath, CashRegister.weight);
            }
        }
        private static int sum = 0;
        private static ArrayList shopping_basket = new ArrayList();
        public static void shopping_basket_add(int quantity) => CashRegister.shopping_basket.Add(quantity.ToString());
        public static void shopping_basket_clear() => CashRegister.shopping_basket.Clear();
        public static void sum_add(int value) => CashRegister.sum += value;

    }
}
