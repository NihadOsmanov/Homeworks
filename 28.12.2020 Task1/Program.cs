using System;

namespace _28._12._2020_Task1
{
    class Program
    {


        //public delegate string PrintMonth(int month);
        public delegate string Func(int month); 
        static void Main(string[] args)
        {
            int Months;
            string January;
            string Febuary;
            string March;
            string April;
            string May;
            string June;
            string July;
            string August;
            string September;
            string October;
            string November;
            string December;
            
            Console.WriteLine("Select a month");
            string month = Console.ReadLine();
            Console.WriteLine($"What information he/she wants to know: \n 1 = translated name of month \n 2 = season name");
            string chooice = (Console.ReadLine());
            
            Month custom_m = Month.January;
            Func pm;

            //Func<string> p =  
            
            if (chooice == "1")
            {
                //TranslateMonthName(x);
                //string s = Console.ReadLine();
                pm = TranslateMonthName;
                Console.WriteLine("You chose 1");

                switch (Convert.ToInt32(month))
                {
                    case 1:
                        custom_m = Month.January;
                        January = "Tercume olunan ad : Yanvar";
                        Console.WriteLine(January);
                        Console.WriteLine(" Information about app");
                        break;
                    case 2:
                        custom_m = Month.Febuary;
                        Febuary = "Tercume olunan ad : Fevral";
                        Console.WriteLine(Febuary);
                        Console.WriteLine(" Information about app");

                        break;
                    case 3:
                        custom_m = Month.March;
                        March = "Tercume olunan ad : Mart";
                        Console.WriteLine(March);
                        Console.WriteLine(" Information about app");

                        break;
                    case 4:
                        custom_m = Month.April;
                        April = "Tercume olunan ad : Aprel";
                        Console.WriteLine(April);
                        Console.WriteLine(" Information about app");

                        break;
                    case 5:
                        custom_m = Month.May;
                        May = "Tercume olunan ad : May";
                        Console.WriteLine(May);

                        Console.WriteLine(" Information about app");

                        break;
                    case 6:
                        custom_m = Month.June;
                        June = "Tercume olunan ad : Iyun";
                        Console.WriteLine(June);

                        Console.WriteLine(" Information about app");

                        break;
                    case 7:
                        custom_m = Month.July;
                        July = "Tercume olunan ad : Iyul";
                        Console.WriteLine(July);

                        Console.WriteLine(" Information about app");

                        break;
                    case 8:
                        custom_m = Month.August;
                        August = "Tercume olunan ad : Avqust";
                        Console.WriteLine(August);

                        Console.WriteLine(" Information about app");

                        break;
                    case 9:
                        custom_m = Month.September;
                        September = "Tercume olunan ad : Sentyabr";
                        Console.WriteLine(September);

                        Console.WriteLine(" Information about app");

                        break;
                    case 10:
                        custom_m = Month.October;
                        October = "Tercume olunan ad : Oktyabr";
                        Console.WriteLine(October);

                        Console.WriteLine(" Information about app");

                        break;
                    case 11:
                        custom_m = Month.November;
                        November = "Tercume olunan ad : Noyabr";
                        Console.WriteLine(November);

                        Console.WriteLine(" Information about app");

                        break;
                    case 12:
                        custom_m = Month.Decemeber;
                        December = "Tercume olunan ad : Dekabr";
                        Console.WriteLine(December);

                        Console.WriteLine("Information about app");

                        break;


                }


            }
            else if (chooice == "2")
            {
                //PrintSeasonName(y);
                pm = PrintSeasonName;
                // String s = Console.ReadLine();
                Console.WriteLine("You chose 2");
                switch (Convert.ToInt32(month))
                {
                    case 1:
                        custom_m = Month.January;
                        January = "Movsumun adi : Qis";
                        Console.WriteLine(January);
                        Console.WriteLine(" Information about app");
                        break;
                    case 2:
                        custom_m = Month.Febuary;
                        Febuary = "Movsumun adi : Qis";
                        Console.WriteLine(Febuary);
                        Console.WriteLine(" Information about app");

                        break;
                    case 3:
                        custom_m = Month.March;
                        March = "Movsumun adi : Yaz";
                        Console.WriteLine(March);
                        Console.WriteLine(" Information about app");

                        break;
                    case 4:
                        custom_m = Month.April;
                        April = "Movsumun adi : Yaz";
                        Console.WriteLine(April);
                        Console.WriteLine(" Information about app");

                        break;
                    case 5:
                        custom_m = Month.May;
                        May = "Movsumun adi : Yaz";
                        Console.WriteLine(May);

                        Console.WriteLine(" Information about app");

                        break;
                    case 6:
                        custom_m = Month.June;
                        June = "Movsumun adi : Yay";
                        Console.WriteLine(June);

                        Console.WriteLine(" Information about app");

                        break;
                    case 7:
                        custom_m = Month.July;
                        July = "Movsumun adi : Yay";
                        Console.WriteLine(July);

                        Console.WriteLine(" Information about app");

                        break;
                    case 8:
                        custom_m = Month.August;
                        August = "Movsumun adi : Yay";
                        Console.WriteLine(August);

                        Console.WriteLine(" Information about app");

                        break;
                    case 9:
                        custom_m = Month.September;
                        September = "Movsumun adi : Payiz";
                        Console.WriteLine(September);

                        Console.WriteLine(" Information about app");

                        break;
                    case 10:
                        custom_m = Month.October;
                        October = "Movsumun adi : Payiz";
                        Console.WriteLine(October);

                        Console.WriteLine(" Information about app");

                        break;
                    case 11:
                        custom_m = Month.November;
                        November = "Movsumun adi : Payiz";
                        Console.WriteLine(November);

                        Console.WriteLine(" Information about app");

                        break;
                    case 12:
                        custom_m = Month.Decemeber;
                        December = "Movsumun adi : Qis";
                        Console.WriteLine(December);

                        Console.WriteLine("Information about app");

                        break;
                }

                int months = Convert.ToInt32(month);

                pm.Invoke(months);

            }
            else Console.WriteLine("Seciminiz sehvdi"); ;

            
        }

        public static string TranslateMonthName(int month)
        {
            //Console.WriteLine("translated name of month");
            return month.ToString();
        }
        public static string PrintSeasonName(int month)
        {
            //Console.WriteLine("Name of season");
            return month.ToString();
        }
    }
}
