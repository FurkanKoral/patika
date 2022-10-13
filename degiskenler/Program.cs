// See https://aka.ms/new-console-template for more information
int? deger = 2;
string? degisken = null;
string? Degisken = null;
//Büyük küçük harf duyarlılığı vardır
//Değişken tanımlarken rakamla başlayamaz
// class gibi sistemde kullanılan isimler değişkene verilemez
//Değişken tanımlarken Türkçe karakter kullanılamaz
// Değişken tanımlarken boşluk karakteri kullanılmaz

Console.WriteLine(degisken + deger + Degisken);

byte a = 5;      //1 byte
sbyte b = 5;     //1 byte

short c = 5;     //2 byte
ushort d = 5;    //2 byte

Int16 i16 = 2;   //2 byte
int i = 2;       //4 byte
Int32 i32 = 2;   //4 byte
Int64 i64 = 2;   //8 byte

uint ui = 4;     //4 byte 
long l = 4;      //8 byte
ulong ul = 4;    //8 byte

float f = 5;     //4 byte
double e = 5;    //8 byte
decimal de = 5;  //16 byte

char ch = '2';   //2 byte
string str = "Furkan";     //sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

//object veri türü her türlü veriyi tutar
object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

//string ifadeler
string str1 = string.Empty;//null değer atar
str1 = "Furkan Koral";
string ad = "Furkan";
string soyad = "Koral";
string tamisim = ad + " " + soyad;

//integer tanımlama şekilleri
int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

//boolean

bool bool1 = 10<2;

//Değişken dönüşümleri

//int değeri string değere çevirme
string? str20 = "20";
int int20 = 22;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);//çıktısı 2022

//string değeri int değere çevirme
int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine( int21);//çıktısı 42
 
//Diğer Yöntem
int int22 = int21 + int.Parse(str20);
Console.WriteLine(int22);//çıktısı 62


string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime5 = DateTime.Now.ToString("dd;MM;yyyy");
Console.WriteLine(datetime5);

string hour = DateTime.Now.ToString("HH.dd");
Console.WriteLine(hour);
Console.Read();









