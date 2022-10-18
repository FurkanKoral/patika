namespace array_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = {23,12,86,72,3,11,17};
            Console.WriteLine("**** Sırasız Sayı Dizisi ****");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.WriteLine("**** Sıralı Sayı Dizisi *****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("**** Array Clear ****");
            //Sayı dizisinin elemanlarını kullanarak 2. indexten itibaren 2 sayıyı 0 yapar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            


            //Reverse
            Console.WriteLine("**** Array Revers ****");
            //Diziyi ters çevirir.
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            
            //IndexOf
            Console.WriteLine("**** indexof Revers ****");
            //Dizideki 23 değerinin index bilgisini döner.
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));


            //Resize
            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 55;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

             
            






        }
    }
}
