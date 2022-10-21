namespace konu4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını
            // console'a yazdırın.
            Console.Write("Bİr cümle yazınız.");
            string? cumle = Console.ReadLine();
            Console.WriteLine("Girilen cümlenin karakter sayısı " + cumle.Length);
            string[] dizi = cumle.Split(" ");
            Console.WriteLine("Yazdığının cümlede " + dizi.Count() + " kelime var.");
        }
    }
}