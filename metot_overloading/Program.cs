namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametresi
            string sayi = "999";
            bool sonuc = int.TryParse(sayi,out int outSayi);
            if(sonuc){
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else {
                Console.WriteLine("Başarısız!");
            }

            Metotlar metot = new Metotlar();
            metot.Topla(4,6,out int ToplamSonucu);
            Console.WriteLine(ToplamSonucu);


            //Metot aşırı yükleme-Metot overloading
            int ifade = 999;
            metot.EkranaYazdir(Convert.ToString(ifade));
            metot.EkranaYazdir(ifade);//int değere yeni bir metot yazarak EkranaYazdir i aşırı yükledik.
            metot.EkranaYazdir("Furkan","Koral");

            //metot imzası
            //metot adı + parametre sayısı + parametre
            
        }
    }
    class Metotlar
    {
        public void Topla(int a , int b,out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1 + " " + veri2);
        }
    }
}
