using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichne4
{
    internal class Phone
    {
        public string Brand;
        public string Model;
        public int Year;
        public double ScreenSize;
        public string OS;
        public int Storage;
        public double BatteryTime;
        public int BatterymAh;
        public double Price;

        public double GetDailyBatteryUsagePercentage(double dailyUsageH)
        {
            double usageDaily = dailyUsageH / BatteryTime;
            double usageInmAh = usageDaily * BatterymAh;
            double percentage = (usageInmAh / BatterymAh) * 100;
            return percentage;
        }
    }
}
