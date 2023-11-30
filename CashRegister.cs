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
            UpdateFile(GlobalPath.NameFilePath, name, ref CashRegister.name);
            UpdateFile(GlobalPath.DescriptionFilePath, description, ref CashRegister.description);
            UpdateFile(GlobalPath.PriceFilePath, price, ref CashRegister.price);
            UpdateFile(GlobalPath.WeightFilePath, weight, ref CashRegister.weight);
        }

        private static void UpdateFile(string filePath, string dataToWrite, ref string[] targetArray)
        {
            File.AppendAllText(filePath, $"{dataToWrite}{Environment.NewLine}");
            targetArray = File.ReadAllLines(filePath);
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
