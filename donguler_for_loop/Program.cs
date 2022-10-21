namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrana kullanıcının istediği sayıya kadar olan tek sayıları yazdır
            // Console.WriteLine("Bir sayı giriniz");
            // int? sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= sayac; i++)
            // {
            //     if(i % 2 == 1)
            //         Console.WriteLine(i);
            // }

            // //1 ile 1000 arasındaki tek sayıların ve çift sayıların toplamı
            // int tekToplam = 0;
            // int ciftToplam = 0;
            // for (int i = 0; i <= 1000; i++)
            // {
            //     if(i%2==1){
            //         tekToplam +=i;
            //     }
            //     else
            //     {
            //         ciftToplam +=i;
            //     }
            // }
            // Console.WriteLine("Çift sayıların Toplamı =" + ciftToplam);
            // Console.WriteLine("Tek sayıların Toplamı =" + tekToplam);


            //break,continue

            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}