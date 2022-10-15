// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
        //Implicit Conversion(Bilinçsiz ya da kapalı dönüşüm)
        Console.WriteLine("*****İmplicit Conversion*****");
        
        byte a = 5;
        sbyte b = 30;
        short c = 10;
        
        int d = a + b + c;
        Console.WriteLine("d:" + d);
        
        long h = d;
        Console.WriteLine("h:" + h);
        
        float i = h;
        Console.WriteLine("i:" + i);
        
        string e = "Furkan";
        char f = 'k';
        object g = e + f + d;
        Console.WriteLine("g:" + g);
        
        //Explicit Conversion(Bilinçli ya da açık dönüşüm)
        
        Console.WriteLine("*****Explicit Conversion*****");
        
        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y:" + y);
        
        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" + t);
        
        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v:" + v);
        
        //ToString methodu ile dönüşüm
        Console.WriteLine("**** ToString Methodu ****");
        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" + yy);
        
        string zz = 12.5f.ToString();
        Console.WriteLine("zz:" + zz);
        
        //System.Convert ile tip dönüşümü
        Console.WriteLine("**** System.Convert sınıfı ****");
        
        string s1 = "10" ,s2 = "20";
        int sayi1 ,sayi2 ,toplam;
        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);
        toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam:" + toplam);
        
        
        //Parse
        Console.WriteLine("**** Parse ****");
        ParseMethod();
        }
        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10.25";
            int sayi1;
            double double1;

            sayi1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("sayi1:" + sayi1);
            Console.WriteLine("double1:" + double1);
        }
    }
}



   







