using prakitchne5_Lib_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace praktichne5_App_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone[] arrPhones;

            Console.Write("Введiть кiлькiсть телефонiв: ");
            int cntPhones = int.Parse(Console.ReadLine());
            arrPhones = new Phone[cntPhones];

            for (int i = 0; i < cntPhones; i++)
            {
                Console.WriteLine("Введiть марку телефона: ");
                string pBrand = Console.ReadLine();
                Console.WriteLine("Введiть модель телефона: ");
                string pModel = Console.ReadLine();
                Console.WriteLine("Введiть рiк випуску телефона: ");
                string pYear = Console.ReadLine();
                Console.WriteLine("Введiть розмiр екрану (дюйми): ");
                string pScreenSize = Console.ReadLine();
                Console.WriteLine("Введiть систему: ");
                string pOS = Console.ReadLine();
                Console.WriteLine("Введiть обсяг пам'ятi (ГБ): ");
                string pStorage = Console.ReadLine();
                Console.WriteLine("Введiть тривалiсть роботи батареi (години): ");
                string pBatteryTime = Console.ReadLine();
                Console.WriteLine("Введiть ємнiсть батареi (mAh): ");
                string pBatterymAh = Console.ReadLine();
                Console.WriteLine("Введiть цiну телефона: ");
                string pPrice = Console.ReadLine();
                Console.WriteLine("Введiть щоденне використання телефону (години): ");
                string pdailyUsageH = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                Phone thePhone = new Phone();
                thePhone.Brand = pBrand;
                thePhone.Model = pModel;
                thePhone.Year = int.Parse(pYear);
                thePhone.ScreenSize = double.Parse(pScreenSize);
                thePhone.OS = pOS;
                thePhone.Storage = int.Parse(pStorage);
                thePhone.BatteryTime = double.Parse(pBatteryTime);
                thePhone.BatterymAh = int.Parse(pBatterymAh);
                thePhone.Price = double.Parse(pPrice);
                thePhone.DailyUsageH = double.Parse(pdailyUsageH);


                arrPhones[i] = thePhone;
            }
            foreach (Phone p in arrPhones)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Данi про телефон {0}", p.Brand + " " + p.Model);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Марка: " + p.Brand);
                Console.WriteLine("Модель: " + p.Model);
                Console.WriteLine("Рiк випуску: " + p.Year.ToString());
                Console.WriteLine("Розмiр екрану: " + p.ScreenSize.ToString());
                Console.WriteLine("Система: " + p.OS);
                Console.WriteLine("Обсяг пам'ятi: " + p.Storage.ToString());
                Console.WriteLine("Тривалiсть роботи батареi: " + p.BatteryTime.ToString());
                Console.WriteLine("Емнiсть батареi: " + p.BatterymAh.ToString());
                Console.WriteLine("Цiна телефону: " + p.Price.ToString());
                Console.WriteLine("Щоденне використання батареi: " + p.GetDailyBatteryUsagePercentage(p.DailyUsageH).ToString("0.00"));

            }
            Console.ReadKey();

        }
    }
}
