
using praktichne4;

Console.WriteLine("Введiть марку телефона: ");
string brand = Console.ReadLine();
Console.WriteLine("Введiть модель телефона: ");
string model = Console.ReadLine();
Console.WriteLine("Введiть рiк випуску телефона: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть розмiр екрану (дюйми): ");
double screensize = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть систему: ");
string os = Console.ReadLine();
Console.WriteLine("Введiть обсяг пам'ятi (ГБ): ");
int storage = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть тривалiсть роботи батареi (години): ");
double batterytime = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть ємнiсть батареi (mAh): ");
int batterymah = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть цiну телефона: ");
double price = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть щоденне використання телефону (години): ");
double dailyUsageH = double.Parse(Console.ReadLine());

Phone myPhone = new Phone();

myPhone.Brand = brand;
myPhone.Model = model;
myPhone.Year = year;
myPhone.ScreenSize = screensize;
myPhone.OS = os;
myPhone.Storage = storage;
myPhone.BatteryTime = batterytime;
myPhone.BatterymAh = batterymah;
myPhone.Price = price;

double dailyBatteryUsagePercentage = myPhone.GetDailyBatteryUsagePercentage(dailyUsageH);

Console.WriteLine();
Console.WriteLine("Iнформацiя про телефон: ");
Console.WriteLine("Марка: " + myPhone.Brand);
Console.WriteLine("Модель: " + myPhone.Model);
Console.WriteLine("Рiк випуску: " + myPhone.Year);
Console.WriteLine("Розмiр екрану: " + myPhone.ScreenSize);
Console.WriteLine("Система: " + myPhone.OS);
Console.WriteLine("Обсяг пам'ятi: " + myPhone.Storage + "ГБ");
Console.WriteLine("Тривалiсть роботи батареi:" + myPhone.BatteryTime + " годин");
Console.WriteLine("Емнiсть батареi: " + myPhone.BatterymAh + " mAh");
Console.WriteLine("Цiна телефона: " + myPhone.Price + " грн");
Console.WriteLine("Щоденне використання батареi: " + dailyBatteryUsagePercentage.ToString("0.00") + "%");