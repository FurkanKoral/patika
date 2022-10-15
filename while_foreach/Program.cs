namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak konsoldan giren sayı dahil ortama hesaplayıp ekrana yazan program
            Console.WriteLine("Bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);



            //a dan z ye kadar tüm harfleri konsala yazdır
            char character = 'a';
            while(character<='z')
            {
                Console.Write(character);
                character++;           
            }

            Console.WriteLine("**** Foreach Döngüsü ****");
            string[] marka = {"Toyota","Mercedes","Audi"};

            foreach (var arac in marka)
            {
                Console.WriteLine(arac);
            }
        
        }
    }
}