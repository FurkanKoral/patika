namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //    [Erişim belirleyicisi] [veri tipi] özellikAdı;
            //    [Erişim belirleyicisi] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
            //    {
            //     //Metot komutları
            //    }
            //}


            //*Public
            //*Private
            //*Internal
            //*Protected
            Console.WriteLine("***** Çalışan1 ******");
            Calisan calisan1 = new Calisan("Ayşe","Kara",2345634,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Console.WriteLine("***** Çalışan2 ******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 2567825;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine();

            Console.WriteLine("***** Çalışan3 ******");
            Calisan calisan3 = new Calisan("Furkan","Koral");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string? Ad;
        public string? Soyad;
        public int No;
        public string? Departman;

        public Calisan(string ad , string soyad , int no , string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad , string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Departamanı : {0}",Departman);

        }
    }
}