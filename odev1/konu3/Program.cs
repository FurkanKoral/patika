
namespace konu3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime 
            // girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.Write("Pozitif bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string?[] dizi = new string[n];
            Console.WriteLine(n + " adet kelime giriniz .");
            for (int i = 0; i < n; i++)
            {
                dizi[i] = Console.ReadLine();
            }
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }


        }
    }
}
