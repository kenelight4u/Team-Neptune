using System.Linq;

namespace TeamNeptune
{
    public class Holiday
    {
        public string Name { get; set; }

        public int Day { get; set; }

        public string Month { get; set; }

        public Holiday(string name, int day, string month)
        {
            this.Name = name;

            this.Day = day;

            this.Month = month;
        }

        public static bool InSameMonth(Holiday holOne, Holiday holTwo)
        {
            // return holTwo.Month.Equals(holOne.Month);

            return (holOne.Month == holTwo.Month) ? true : false;
        }

        public static double AvgDate(Holiday[] holiday)
        {
            // return holiday.Average(x => x.Day);

            double sum = 0;

            for (int i = 0; i < holiday.Length; i++)
            {
                sum += holiday[i].Day;
            }
            return sum / holiday.Length;
        }
    }
}