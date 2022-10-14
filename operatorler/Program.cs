// See https://aka.ms/new-console-template for more information
Console.WriteLine("**********atama ve işlemli atama operatörleri**********");
//atama ve işlemli atama
int x = 3;
int y = 3;
y+=2;// y = y + 2
Console.WriteLine(y);//5
y/=5;// y = y / 5
Console.WriteLine(y);//1
x*=2;// x = x * 2
Console.WriteLine(x);//6

Console.WriteLine("**********mantıksal operatörler**********");
//Mantıksal Operatörler
// ||(veya) , &&(ve) , !(değil)

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted)//ve operatöründe 2 değerinde true doğru dönmesi lazım
Console.WriteLine("Perfect!");

if(isSuccess || isCompleted)// veya operatöründe sadece biri true dönerse de olur
Console.WriteLine("Great!");

if(isSuccess && !isCompleted)// değil operatörü true değeri false , false değeri true yapar
Console.WriteLine("Fine!");

Console.WriteLine("**********ilişkisel operatörler**********");
//İlişkisel operatörler
// < , > , == , <= , >= , !=

int a = 3;
int b = 4;
bool sonuc = a<b;//küçüktür
Console.WriteLine(sonuc);
sonuc = a>=b; //büyük eşittir
Console.WriteLine(sonuc);
sonuc = a<=b; //küçük eşittir
Console.WriteLine(sonuc);
sonuc = a==b; //eşittir
Console.WriteLine(sonuc);
sonuc = a!=b; //eşit değildir
Console.WriteLine(sonuc);


Console.WriteLine("**********aritmetik operatörler**********");
//Aritmetik Operatörler
// + , - , * , /

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 + sayi2;//toplama
Console.WriteLine(sonuc1);
sonuc1 = sayi1 - sayi2;//çıkarma
Console.WriteLine(sonuc1);
sonuc1 = sayi1 * sayi2;//çarpma 
Console.WriteLine(sonuc1);
sonuc1 = sayi1 / sayi2;//bölme
Console.WriteLine(sonuc1);
sonuc1 = ++sayi1;//1 ekleme
Console.WriteLine(sonuc1);

// % : mod alma
int sonuc2 = 20%3;
Console.WriteLine(sonuc2);








