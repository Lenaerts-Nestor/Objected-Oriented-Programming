using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //deze heb ik zelf niet gedaan, ik had half zonder de if().
            Console.WriteLine("Geef je verjaardag (formaat: d/m . Bv 18/3)");
            DateTime verj = DateTime.Parse(Console.ReadLine());


            if (verj < DateTime.Today)
                verj = verj.AddYears(1);


            string dagLokaal = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(verj.DayOfWeek);
            TimeSpan dagenOver = verj - DateTime.Today;

            Console.WriteLine($"Je ben jarig over {dagenOver.Days} dagen en dat is op een {dagLokaal}.");
        }
    }
}
