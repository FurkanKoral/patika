using System.Collections;
namespace konu2
{
        class Program
    {
        static void Main(string[] args)
        {
            // 2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif 
            // sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.Write("Pozitif bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pozitif bir sayı giriniz : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int deger;
            List<int> liste = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Sayı giriniz : ");
                deger = Convert.ToInt32(Console.ReadLine());
                liste.Add(deger);
            }

            foreach (var item in liste)
            {
                if(item == m || item % m == 0)
                    Console.WriteLine("Çıkan sayılar : " + item);   
            }
        }
    }
}
