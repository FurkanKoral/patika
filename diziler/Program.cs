namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilerde değer atama ve değiştirme
            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[1]);
        
            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını alan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
            int dizi_uzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[dizi_uzunlugu];

            for(int i = 0;i<dizi_uzunlugu;i++){
                Console.Write("Lütfen {0}.sayıyı giriniz.",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam+= sayi;
            
            Console.WriteLine("Ortalama:" + toplam/dizi_uzunlugu);
            
            


        }
    }
}