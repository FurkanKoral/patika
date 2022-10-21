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

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 2345634;
            calisan1.Departman = "İnsan Kaynakları";

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 2567825;
            calisan2.Departman = "Satın Alma";

            calisan1.CalisanBilgileri();
            Console.WriteLine("****************************");
            calisan2.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string? Ad;
        public string? Soyad;
        public int No;
        public string? Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Departamanı : {0}",Departman);

        }
    }
}