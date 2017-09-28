using System;

namespace DatesAndTimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());   
            // Console.Write(myValue.ToShortDateString());
            // Console.WriteLine(myValue.ToLongTimeString());
            // Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            // Console.WriteLine(myValue.AddHours(3).ToShortTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToShortTimeString());
            //  Console.WriteLine(myValue.Month.ToString());
            //  Console.WriteLine(myValue.);
            // DateTime myBirthday = new DateTime(1344, 2, 12);
            // Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("12/7/69");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);


            Console.ReadLine();


        }
    }
}


///localized to usa
/// date math: add or subtract values to and from it
/// tells date in three days
/// you can chain multiple methods to save typing
/// makes statement more readable
/// created new instance and initialized it
/// 