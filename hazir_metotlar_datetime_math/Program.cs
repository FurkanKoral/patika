namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("****** DateTime Kütüphanesi ******");


            Console.WriteLine(DateTime.Now);//Günün tarihini getirir
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());


            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//21
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday


            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//April


            Console.WriteLine(DateTime.Now.ToString("yy"));//22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022

            Console.WriteLine("****** Math Kütüphanesi ******");
            //Math
            Console.WriteLine(Math.Abs(-25));//Mutlak alır
            Console.WriteLine(Math.Sin(30));//Sinüs alır
            Console.WriteLine(Math.Cos(30));//Cosünüs alır
            Console.WriteLine(Math.Tan(30));//Tanjant alır

            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22


            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(2,3));//üs alır 2^3
            Console.WriteLine(Math.Sqrt(9));//Karekök alır
            Console.WriteLine(Math.Log(9));//Logaritma
            Console.WriteLine(Math.Exp(3));//e üzeri 3 verir
            Console.WriteLine(Math.Log10(10));//10 sayısının log10 karşılığı


            


            
























            
            



            




        }


    }
}