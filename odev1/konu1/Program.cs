using System.Collections;
namespace konu1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Bir konsol uygulamasındau kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan
            // n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            int deger;
            Console.Write("Pozitif bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Bir sayı giriniz : ");
                deger = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = deger;
            }
            ArrayList cift = new ArrayList();

            foreach (var item in sayilar)
            {
                if(item%2==0)
                   cift.Add(item);
            }
            foreach (var item in cift)
                Console.WriteLine("Çift sayılar : " + item);
        }
    }
}
