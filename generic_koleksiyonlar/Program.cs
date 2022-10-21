namespace generic_koleklsiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System Collections.Generic
            //T -> object türündendir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(2);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //foreach ve list.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
            
            //Lİsteden eleman çıkarma 
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içinde bulundu.");
            
            //Eleman ile indexe erişim 
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziden liste çevirme
            string[] hayvanlar = {"kedi","köpek","kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //liste nasıl temizlenir
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullancıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 20;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 23;

            kullancıListesi.Add(kullanıcı1);
            kullancıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                 Isim = "Deniz",
                 Soyisim = "Arda",
                 Yas = 24
            });

            foreach (var kullanıcı in kullancıListesi)
            {
                Console.WriteLine("Kullancı Adı : " + kullanıcı.Isim);
                Console.WriteLine("Kullancı Soyadı : " + kullanıcı.Soyisim);
                Console.WriteLine("Kullancı Yaşı : " + kullanıcı.Yas);

            }
        }
    }
    public class Kullanıcılar{
        private string? isim;
        private string? soyisim;
        private int yas;

        public string? Isim { get => isim; set => isim = value; }
        public string? Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set =>yas = value; }


        
    }
}