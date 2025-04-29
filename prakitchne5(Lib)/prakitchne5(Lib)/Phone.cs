using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakitchne5_Lib_
{
    public class Phone
    {
        public string Brand;
        public string Model;
        public int Year;
        public double ScreenSize;
        public string OS;
        public int Storage;
        public double BatteryTime;
        public double BatterymAh;
        public double Price;
        public double DailyUsageH;
        public double DailyBatteryUsagePercentage
        {
            get
            {
                return GetDailyBatteryUsagePercentage(0);
            }
        }
        public double GetDailyBatteryUsagePercentage(double dailyUsageH)
        {
            double usageDaily = dailyUsageH / BatteryTime;
            double usageInmAh = usageDaily * BatterymAh;
            double percentage = (usageInmAh / BatterymAh) * 100;
            return percentage;
        }
    }
}
