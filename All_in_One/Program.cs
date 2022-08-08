using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_in_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string
            //STRİNG:metinsel ifadeleri tutan yapılardır.
            //string name = "İrem";
            //Console.WriteLine(name);
            //tip  değişken  değişkene atadığım  isim.
            //     referans 
            #endregion
            #region DeğişkenKuralları
            //Değişken ismi verirken kurallar
            //1-C# içerisind gömülü gelen isimler değişken ismi olamaz
            //2-değişken isimleri numaratik sembolik ifadelerle başlayamaz.
            //Aynı değişken isminden birdaha tanımlayamazsın.
            //Değişken ismi verirken boşuk bırakmazsın. 
            //byte
            //float
            //decimal
            //double
            //long
            //ulong 
            //uShort
            #endregion
            #region Bool
            //bool: true -false döner
            //bool değer = true;
            //bool değer1 = false; 
            #endregion
            #region Char
            //char a = 'A';
            //Console.WriteLine(a); 
            #endregion
            #region DateTime
            ////string born = "23/05/1991";
            ////DateTime date = DateTime.Now;
            ////Console.WriteLine(date);
            ////Console.WriteLine(date.Year);
            ////Console.WriteLine(date.Day);
            ////Console.WriteLine(date.Hour);
            ////Console.WriteLine(date.Minute); 
            #endregion
            #region Var
            //var: Varsayılan olarak değer tutar.
            //var a = 10;
            //var b = "Bibi";
            //var c = 'A';
            //var d = 10.5; 
            #endregion
            #region const
            //const: sabitlemek için kullanılır. Const işareklenmiş bir değişken tanımlandığı anda değerini vermek zorundasın.
            // const int a=10; 
            #endregion
            #region Explicit-implicit
            //int number = 3;//Açık Açık tanımlama:Explicit
            //var numara = 4;//KApalı tanım:Implicit 
            #endregion
            #region Try-catch
            //System.FormatException: Tipte kaynaklı
            //System.OverflowException:verdiğin değer aralığından büyük demek
            //try
            //{
            //    Console.Write("Adınızı Giriniz: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Soyadını Gir: ");
            //    string lastName = Console.ReadLine();
            //    Console.Write("Yaşını Gir: ");
            //    byte age = Convert.ToByte(Console.ReadLine());
            //    Console.WriteLine($"Adınız-Soyadınız-Yaşınız: {name} {lastName} {age}");
            //}

            //catch (FormatException)
            //{

            //    Console.WriteLine("Format hatası");
            //}
            //catch (OverflowException)
            //{

            //    Console.WriteLine("0-255 Arası");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Beklenmedik Bir hata ");
            //}
            //finally
            //{
            //    Console.WriteLine("Merhaba");
            //}  
            #endregion
            #region Checked-uncheck
            //int a = 300;
            //byte b =(byte) a;//explicit type casting
            //Console.WriteLine(b);
            //Eğer küçük türden büyük türe bir çevirme yapıyorsan implicit type casting
            //byte c = 25;
            //int d = c;
            //try
            //{
            //    checked
            //    {
            //        int a = 300;
            //        byte b = (byte)a;
            //        Console.WriteLine(b);
            //    }

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hatalı işlem 0-255 arasında para gönderin.");
            //}

            //unchecked
            //{
            //    int a = 300;
            //    byte b = (byte)a;
            //    Console.WriteLine(b);
            //} 
            #endregion
            #region Operatörler
            //byte a = 25;
            //object b = a;//boxing: kutulama-Stackteki verileri heap'e taşımak
            //a = (byte)b;//unboxing kutudan çıkardım.Heap'den stack
            ////unboxing yapabilmek için mutlaka kutulama yapmak zorundasınız. 
            #endregion
            #region Karar Yapıları - KonuAnlatım
            //if (1==1)
            //{
            //    Console.WriteLine("test");
            //}
            //else
            //{
            //    Console.WriteLine("test1");
            //} 
            #endregion
            #region Karar Yapıları - İlk Örnek
            //Console.Write("1.Sayiyi Gir: ");
            //byte sayi1 = byte.Parse(Console.ReadLine());
            //Console.Write("2.Sayiyi Gir: ");
            //byte sayi2 = byte.Parse(Console.ReadLine());
            //if (sayi1>sayi2)
            //{
            //    Console.WriteLine($"En büyük sayi ={sayi1}");
            //}
            //else
            //{
            //    Console.WriteLine($"En büyük sayi ={sayi2}");
            //} 
            #endregion
            #region Karar Yapıları - Örnek
            //Console.Write("1.Sayiyi Gir: ");
            //byte sayi1 = byte.Parse(Console.ReadLine());
            //Console.Write("2.Sayiyi Gir: ");
            //byte sayi2 = byte.Parse(Console.ReadLine());
            //if (sayi1 > sayi2) 
            //{
            //    Console.WriteLine($"En büyük sayi ={sayi1}");
            //}
            //else if (sayi2>sayi1)
            //{
            //    Console.WriteLine($"En büyük sayi ={sayi2}");
            //    //if (sayi2>sayi1)
            //    //{
            //    //    Console.WriteLine(sayi2 + sayi1);
            //    //}
            //}
            //else
            //{
            //    Console.WriteLine($"İki Sayı Birbirine eşit");
            //} 
            #endregion
            #region Swich
            //Console.Write("Havale(1)-Eft(2)-Operatör(3)");
            //byte secim = Convert.ToByte(Console.ReadLine());
            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine("Havale");
            //        Console.WriteLine("Kaç para");
            //        decimal para = decimal.Parse(Console.ReadLine());
            //        if (para > 1000)
            //        {
            //            Console.WriteLine("Havale ücreti 4TL");
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("Eft");
            //        break;
            //    case 3:
            //        Console.WriteLine("Operatör");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        break;

            //}
            #endregion
            #region For KonuAnlatım
            //5!=5*4*3*2*1
            //int sonuc = 1;
            //for (int i = 2; i <=5; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);
            //Console.WriteLine("Faktöriyel Hesabı");
            //Console.Write("Sayi Giriniz: ");
            //ushort secim = Convert.ToUInt16(Console.ReadLine());
            //ushort sonuc = 1;
            //for (ushort i = 2; i <= secim; i++)
            //{
            //    sonuc *= i;
            //    //sonuc=sonuc*i;
            //Console.WriteLine(sonuc);
            //}
            //string name = "Merhaba ";
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion
            #region Sonsuz Döngü
            //byte i = 0;
            //for (; ; )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} 
            #endregion
            #region SonsuzDöngü ÖRneği
            //for (; ; )
            //{
            //    Console.Write("Kullanıcı Adını Gir: ");
            //    string user = Console.ReadLine();
            //    Console.Write("Şifrenizi Giriniz: ");
            //    string pass = Console.ReadLine();
            //    if (user.ToLower()=="admin"&&pass=="123")
            //    {
            //        Console.WriteLine("Hoşgeldin grup 179'a");
            //        break;//Döngüyle kullanılır.
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekrar Deneyiniz....");
            //    }
            //} 
            #endregion
            #region RandomSayı
            //Random ran = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(ran.Next(0, 20));
            //}
            //Console.WriteLine("Rasgele Sayi üretmeye hosşgeldin");
            //Console.WriteLine("Kaç Sayı Üretmek istiyorsun");
            //byte sayi = byte.Parse(Console.ReadLine());
            //Random random = new Random();
            //for (int i = 0; i < sayi; i++)
            //{

            //    Console.WriteLine(random.Next(1,100));
            //} 
            #endregion
            #region Do-while-while
            //while (true)
            //{
            //    console.writeline("test");
            //}
            //while (false)
            //{
            //    Console.WriteLine("Test");
            //}

            //do
            //{
            //    Console.WriteLine("Test");
            //} while (false);
            #endregion
            #region Diziler
            //Dizi:Aynı tipteki verileri bir arada tutar
            //Dizi Tanımlamak için Tip[dizi parantezi]değişken adı=new int[eleman sayisi]

            //int a = 10;
            //a = 30;
            //int b = 20;
            //int c = 30;
            //int[] sayilar = new int[3];

            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //Console.WriteLine(sayilar[0]);  
            #endregion
            #region string
            //string name = "Hakan";
            //char[] dizi = name.ToCharArray();
            //Console.WriteLine(dizi); 

            //Kullanıcıdan isim alın bunu ascıı kodlarına çevirsin ve desinki ismininiz sayısal toplamı =
            //char harf = 'A';
            //Console.WriteLine((int)harf);
            //while (true)
            //{
            //    Console.Write("İsmin ne?: ");
            //    string isim = Console.ReadLine();
            //    int toplam = 0;
            //    for (int i = 0; i < isim.Length; i++)
            //    {
            //        toplam +=(int)isim[i];
            //    }
            //    Console.WriteLine($"İsmininzin Toplamı ={toplam}");
            //}
            #endregion
            #region sayilar.Lenght
            //int[] sayilar = new int[3];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine("----------------");
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //} 
            #endregion
            #region RandomSayı
            // Kullanıcıya sor Kaç tane sayı üretilecek
            //Dizi
            //Random Sayı üretin 
            //oSayıları ekrana basın
            //Console.Write("Kaç Adet Sayi Üreteceksin: ");
            //byte adet = byte.Parse(Console.ReadLine());
            //int[] sayilar = new int[adet];
            //Random random = new Random();
            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    Console.WriteLine(sayilar[i] += random.Next(1, 100));
            //} 
            #endregion
            #region Foreach
            //int[] sayilar = { 1, 2, 3, 4 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            ////foreach (var item in sayilar)
            ////{
            ////    Console.WriteLine(item);
            ////} 
            #endregion
            #region ÇokBoyutluDizi
            //int[,] sayilar = new int[2,3];
            //sayilar[0, 0] = 10;
            //sayilar[0, 1] = 20;
            //sayilar[0, 2] = 30;
            //sayilar[1, 0] = 40;
            //sayilar[1, 1] =50;
            //sayilar[1, 2] = 60;
            ////foreach (var item in sayilar)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //for (int i = 0; i < sayilar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sayilar.GetLength(1); j++)
            //    {
            //        Console.WriteLine(sayilar[i,j]);
            //    }

            //} 
            #endregion
            #region DiziProje - Örnek
            //string[] arabalar = new string[0];
            ////+1=1.Eleman//11Elaman
            ////-1=10elemanlı dizi
            //while (true)
            //{
            //    Console.Write("Araba Ekle(1)-Araba Listele(2)-Çıkış(0): ");
            //    char enter = Console.ReadKey().KeyChar;

            //    if (enter == '1')
            //    {
            //        Console.WriteLine();
            //        Array.Resize(ref arabalar, arabalar.Length + 1);
            //        Console.Write("Model Giriniz: ");
            //        arabalar[arabalar.Length - 1] = Console.ReadLine();
            //        #region III.Yol
            //        //   //0                1
            //        //string[] container = arabalar;
            //        //arabalar = new string[arabalar.Length + 1];

            //        //for (int i = 0; i < container.Length; i++)
            //        //{
            //        //    arabalar[i] = container[i];
            //        //}
            //        //Console.Write("Modeli Yazınız: ");
            //        //arabalar[container.Length]=Console.ReadLine();
            //        //Console.ReadLine(); 
            //        #endregion
            //        #region II.Yol
            //        //arabalar = new string[1];
            //        //Console.Write("Model Giriniz: ");
            //        //arabalar[0] = Console.ReadLine(); 
            //        #endregion
            //        #region IYol
            //        //for (int i = 0; i < arabalar.Length; i++)
            //        //{
            //        //    Console.Write((i + 1) + "-" + "Arabanın Modeli Giriniz: ");
            //        //    arabalar[i] = Console.ReadLine();
            //        //} 
            //        #endregion
            //    }
            //    else if (enter == '2')
            //    {
            //        for (int i = 0; i < arabalar.Length; i++)
            //        {
            //            Console.WriteLine(arabalar[i]);
            //        }
            //    }
            //    else if (enter == '0')
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı Giriş...");
            //    }
            //}
            //Console.ReadLine(); 
            #endregion
            #region Odev - Yıldız Üçgen-Kare Ödevi
            //Console.WriteLine("Lütfen yıldız büyüklüğünüz için bir sayı giriniz.");
            //int yildiz = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= yildiz; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //Console.WriteLine("Lütfen içi boş kare büyüklüğünüz için bir sayı giriniz.");
            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n - 1; i++)
            //{
            //    Console.Write("*");
            //}
            //for (int i = 0; i < n - 1; i++)
            //{
            //    Console.WriteLine("*");
            //    //for (int k = i; k < n-1; k++)
            //    //{
            //    //    Console.Write("");
            //    //}
            //    //for (int x = 0; x <= i; x++)
            //    //{
            //    //    Console.WriteLine("*");
            //    //}
            //    //Console.WriteLine( );

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine("Kaç tane sayi üretmek istersin");
            //int sayi = int.Parse(Console.ReadLine());

            //int[] dizi = new int[sayi];
            //int[] tempDizi = new int[sayi];

            //Random random = new Random();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(1, 10);

            //}
            //dizi = tempDizi;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[0] != tempDizi[i])
            //    {
            //        Console.WriteLine(dizi[0]);

            //    }
            //} 
            #endregion
            #region Feyza Esertepe Giremesin Ödevi
            //try
            //{
            //    // tc no hane sorgulama yap uyarı versin. bozuksa başa döndür. tc no da break deyip atmasın düzgün gir deyip başa göndersin.


            //    Console.WriteLine("Merhaba Sisteme hoşgeldiniz.");
            //    Console.WriteLine("Lütfen adınızı giriniz.");
            //    string isim = Console.ReadLine();
            //    Console.WriteLine("Lütfen soyadınızı giriniz.");
            //    string soyad = Console.ReadLine();

            //    if (isim.ToLower() != "feyza" && soyad.ToLower() != "esertepe")
            //    {
            //        Console.WriteLine("Yaşınız?");
            //        byte yas = byte.Parse(Console.ReadLine());

            //        Console.WriteLine("Lütfen Tc kimlik no giriniz.");
            //        string tcno = Console.ReadLine();

            //        if (tcno.ToCharArray().Length != 11)
            //        {
            //            while (true)
            //            {
            //                Console.WriteLine("Düzgün bir tc no giriniz.");
            //                string yeniTc = Console.ReadLine();
            //                if (yeniTc.ToCharArray().Length == 11)
            //                {
            //                    break;
            //                }
            //            }
            //        }
            //        // SORU :  Hocam ben burda konsola {yeniTc} yi nasıl yazdıracağım ?



            //        Console.WriteLine("Sisteme Hoşgeldiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Burayı terket");
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Düzgün değer gir.");
            //}
            //Console.ReadLine(); 
            #endregion
            #region Hesap Makinesi
            //    Console.WriteLine("Merhaba");
            //    while (true)
            //    {
            //        Console.Write("Toplama(1)-Çıkarma(2)-Çarpma(3)-Bölme(4)-Çıkış(0): ");
            //        double sayi1 = 0;
            //        double sayi2 = 0;
            //        byte enter = byte.Parse(Console.ReadLine());
            //        if (enter == 0)
            //        {
            //            break;
            //        }
            //        if (enter == 1 || enter == 2 || enter == 3 || enter == 4)
            //        {
            //            Console.Write("1.Sayıyı Gir: ");
            //            sayi1 = double.Parse(Console.ReadLine());
            //            Console.Write("2.Sayıyı Gir: ");
            //            sayi2 = double.Parse(Console.ReadLine());
            //            if (enter == 1)
            //            {
            //                Console.WriteLine("Toplama Sonucu: " + Toplama(sayi1, sayi2));
            //            }
            //            else if (enter == 2)
            //            {
            //                Console.WriteLine(Cıkarma(sayi1, sayi2));
            //            }
            //            else if (enter == 3)
            //            {
            //                Carpma(sayi1, sayi2);
            //            }
            //            else if (enter == 4)
            //            {

            //                Console.WriteLine(Bolme(sayi1, sayi2));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hatalı Giriş");
            //            }
            //        }
            //    }
            //}
            //static double Toplama(double a, double b)
            //{
            //    return a + b;
            //}
            //static string Cıkarma(double a, double b)
            //{
            //    if (a > b)
            //    {
            //        return "Çıkarma Sonucu: " + (a - b).ToString();
            //    }
            //    else if (b > a)
            //    {
            //        return "Çıkarma Sonucu: " + (b - a).ToString();
            //    }
            //    return "İki Sayı Biribirine Eşit Sonuc 0";
            //}
            //static double Bolme(double a, double b)
            //{
            //    if (a > b)
            //    {
            //        return a / b;
            //    }
            //    else if (b > a)
            //    {
            //        return b / a;
            //    }
            //    return 1;
            //}
            //static void Carpma(double a, double b)
            //{
            //    Console.WriteLine(a * b);
            #endregion
            #region Ref Out
            //    int a = 50;
            //    int b = 100;
            //    var result = Alp(ref a, b);
            //    Console.WriteLine(result);
            //    Console.WriteLine(a);
            //    Console.WriteLine("--------------");
            //    double c;
            //    double d;

            //    Console.WriteLine(Bibi(out c, out d));
            //    Console.WriteLine(c);
            //    Console.WriteLine(d);
            //    Console.ReadLine();
            //}
            //static int Alp(ref int number1, int number2)
            //{
            //    number1 = 30;
            //    return number1 + number2;
            //}
            //static double Bibi(out double number1, out double number2)
            //{
            //    number1 = 30;
            //    number2 = 20;
            //    return number1 - number2;
            #endregion
            #region Methodlar - KonuAnlatım
            //Methodlar: iş yapan kod bloklarıdır. 
            //Bir namespaca bir classın altında yer alır.
            //(static)-DonusTipi-Methotİsmi()-{}
            //Void:Boş dönen
            //double-decimal-string...: 
            //method overloading: methodların aşırı yüklenmesi anlamına gelir
            #endregion
            #region Methodlar - İlkÖrnek
            //Console.Write("Bir sayı Gir: ");//
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("Bir sayı Gir: ");//
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(Toplama(sayi1,sayi2)); 
            #endregion
            #region Methodlar - 2.Örnek
            //  int a = 10;
            //  int b = 20;
            //  string name = "Emre";
            //  Console.WriteLine(a + b+" "+name);
            //  Console.WriteLine("----------------");
            //  Console.WriteLine(Toplama(3, 5));
            // Console.WriteLine( Toplama(5, 4));
            //  Toplama(5, 10);
            //Console.WriteLine(  Toplama(5, 5, 4));

            //  Console.ReadLine(); 
            #endregion
            #region Tek Satırlı Method
            //static int Toplama(int a, int b) => a + b; 
            #endregion
            #region static int Üç Sayı Toplama Methodu
            //static int UcSayıTopla(int a,int b,int c)
            //{
            //    return a + b + c;
            //}
            //static string Toplama(int a,int b)
            //{
            //    return "Toplama Sonucu: " +( a + b);
            //}
            //static void Toplama(int a,int b)
            //{
            //    Console.WriteLine(a + b);
            //} 
            #endregion
            #region OOP - KonuAnlatım
            //private :Özel Gizli
            //public: Erişime açık/Gizli olmayan her yerden erişilebilen
            //write once,use everywhere(Bir kere yaz her yer de kullan);
            //Öğrenci Tuğgenin soyadı nedir?
            //Cevap:Ogrenci ne?
            //int a = 10;
            //string ogr1name = "Tuğgen";
            //string ogr2name = "Okan";
            //string ogr3name = "İrem";

            //string ogr1lastName = "Köse";
            //string ogr2lastName = "Kandemir";
            //string ogr3lastName = "Önemli"; 
            #endregion
            #region OOP - İlk Örnek
            //        Ogrenci ogrenci1 = new Ogrenci();
            //        ogrenci1.ad = "Tuğgen";
            //        ogrenci1.soyad = "Köse";
            //        ogrenci1.numara = 10;
            //        ogrenci1.BilgiGetir();
            //        Ogrenci.BilgiGetir(ogrenci1);
            //        //Console.WriteLine(ogrenci1.ad+"-"+ogrenci1.soyad+"-"+ogrenci1.numara);
            //        //BilgiGetir(ogrenci1);

            //        Ogrenci ogrenci2 = new Ogrenci();
            //        ogrenci2.ad = "Okan";
            //        ogrenci2.soyad = "Kandemir";
            //        ogrenci2.numara = 11;
            //        //BilgiGetir(ogrenci2);
            //        //Console.WriteLine(ogrenci2.ad + "-" + ogrenci2.soyad + "-" + ogrenci2.numara);
            //        Console.ReadLine();
            //    }
            //    //static void BilgiGetir(Ogrenci og)
            //    //{
            //    //    Console.WriteLine(og.ad + "-" + og.soyad + "-" + og.numara);
            //    //}
            //}
            //class Ogrenci
            //{
            //    public string ad;//field
            //    public string soyad;
            //    public int numara;
            //    public void BilgiGetir()
            //    {
            //        Console.WriteLine($"Adı:{this.ad} Soyad:{this.soyad} Numara: {this.numara}");
            //    }
            //    public static void BilgiGetir(Ogrenci ogr)
            //    {
            //        Console.WriteLine($"Adı:{ogr.ad} Soyad:{ogr.soyad} Numara: {ogr.numara}");
            //    } 
            #endregion
            #region OOP - Personel Proje Örneği
            //static void Main(string[] args)
            //{
            //    Person person = new Person();
            //    person.Name = "Öykü";
            //    person.LastName = "Köse";
            //    person.StartDate = new DateTime(2021, 05, 17);
            //    person.Born = new DateTime(1995, 07, 22);
            //    person.StartSalary = 4000M;
            //    person.Statu = Statu.İşçi;
            //    Console.WriteLine(person.BilgiGetir());
            //    Console.WriteLine("------------------------");
            //    Person person2 = new Person("Bibi", "Zada", new DateTime(1987, 03, 21), new DateTime(2000, 10, 15), 2500M, Statu.Yönetici);
            //    Console.WriteLine(person2.BilgiGetir());
            //    Console.ReadLine();
            //}
            //public enum Statu
            //{
            //    Yönetici,
            //    İşçi,
            //    Memur,
            //    Müdür
            //}
            //public class Person
            //{
            //    public Person()
            //    {

            //    }
            //    public Person(string name, string lastname, DateTime born, DateTime startdate, decimal startsalary, Statu statu)
            //    {
            //        Name = name;
            //        LastName = lastname;
            //        Born = born;
            //        StartDate = startdate;
            //        StartSalary = startsalary;
            //        Statu = statu;

            //    }
            //    public decimal StartSalary { get; set; }
            //    public string Name { get; set; }
            //    public string LastName { get; set; }
            //    public string FullName { get { return Name + " " + LastName; } }
            //    public DateTime Born { get; set; }
            //    public DateTime StartDate { get; set; }
            //    public int WorkYear { get { return DateTime.Now.Year - StartDate.Year; } }
            //    public string Age { get { return "Yaşınız: " + (DateTime.Now.Year - Born.Year); } }
            //    public decimal Salary
            //    {
            //        get
            //        {
            //            if (WorkYear == 0)
            //            {
            //                return StartSalary;
            //            }
            //            else if (WorkYear > 10)
            //            {
            //                return StartSalary + (StartSalary * (30M / 100M));
            //            }
            //            else if (WorkYear > 5)
            //            {
            //                return StartSalary + (StartSalary * (20M / 100M));
            //            }
            //            else
            //            {
            //                return StartSalary + (StartSalary * (10M / 100M));
            //            }

            //        }





            //    }
            //    public string BilgiGetir()
            //    {
            //        return FullName + " " + Salary + " " + Age+" "+WorkYear;

            //    }
            //    public Statu Statu { get; set; }//Navigation
            //} 
            #endregion
            #region OOP - Person Navigat (Öğretmen - Öğrenci Örneği)
            //    static void Main(string[] args)
            //    {
            //        Console.WriteLine("---------Ogrenci1");
            //        Ogrenci ogrenci1 = new Ogrenci();
            //        Console.WriteLine(ogrenci1.Name = "Gizem");
            //        Console.WriteLine(ogrenci1.LastName = "Tümsavaş");
            //        Console.WriteLine(ogrenci1.Numara =10 );

            //        Console.WriteLine("----------Ogrenci2");
            //        Ogrenci ogrenci2 = new Ogrenci();
            //        Console.WriteLine(ogrenci2.Name = "Emre");
            //        Console.WriteLine(ogrenci2.LastName = "Nar");
            //        Console.WriteLine(ogrenci2.Numara = 11);
            //        Console.WriteLine("---------- Ogretmen");
            //        Ogretmen ogretmen = new Ogretmen();
            //        Console.WriteLine(ogretmen.Ad = "Feyza");
            //        Console.WriteLine(ogretmen.Soyad = "Esertepe");
            //        Console.WriteLine("----------OgretmenOgrencisi");
            //        ogretmen.Ogrenci = new Ogrenci[] { ogrenci1, ogrenci2 };
            //        foreach (var item in ogretmen.Ogrenci)
            //        {
            //            Console.WriteLine(item.Name);
            //        }
            //        Console.ReadLine();
            //    }
            //}
            //public class Ogretmen
            //{
            //    public string Ad { get; set; }
            //    public string Soyad { get; set; }
            //    public Ogrenci[] Ogrenci { get; set; }
            //}
            //public class Ogrenci
            //{
            //    public int Numara { get; set; }
            //    public string Name { get; set; }
            //    public string LastName { get; set; }
            //    public Ogretmen Ogretmen { get; set; }
            //} 
            #endregion
            #region OOP - Devam Örneği
            //    {
            //        //Kapsülleme:Encapsulation:Açık olan -fildların korunma altına alınması için kullanılır.
            //        //ctor: 
            //        //-Nesne Türetir.
            //        //-class içindeki nesneleri oluşturu.
            //        //-Onlara varsayılan değeri atar
            //        Ogrenci ogrenci1 = new Ogrenci();
            //        ogrenci1.ad = "Hakan";
            //        ogrenci1.soyad = "Yıldız";
            //        ogrenci1.BilgiGetir();
            //        Ev ev = new Ev(10, 10, "İstanbul");
            //       //ev.BilgiGetir();
            //        Console.WriteLine(ev.KatSayisi+"-"+ ev.Konum+"-"+ ev.OdaSayisi);
            //        //ev.KatSayisi = 10;
            //        //ev.Konum = "Ankara";
            //        //ev.OdaSayisi = 4;
            //        //ev.BilgiGetir();
            //        #region Konuanlatım2
            //        //do
            //        //{
            //        //    Console.Write("Öğrenci Adını Giriniz: ");
            //        //    ogrenci1.ad = Console.ReadLine();
            //        //    Console.Write("Öğrenci Soyadı Giriniz: ");
            //        //    ogrenci1.soyad = Console.ReadLine();
            //        //    //Console.Write("Öğrenci Numara Giriniz: ");
            //        //    //ogrenci1.Numara = -10;
            //        //   // ogrenci1.SetNumber(-10);
            //        //   //Console.WriteLine(ogrenci1.GetNumber());
            //        //    ogrenci1.BilgiGetir();

            //        //} while (true);
            //        //Console.WriteLine(ogrenci1.SetNumber(-10)); 
            //        #endregion
            //        #region Konuanlatım
            //        //ogrenci1.ad = "Hakan";
            //        //ogrenci1.soyad = "Yıldız";
            //        //ogrenci1.numara = -10;
            //        //ogrenci1.BilgiGetir();
            //        //do
            //        //{
            //        //    Console.Write("Öğrenci Adını Giriniz: ");
            //        //    ogrenci1.ad = Console.ReadLine();
            //        //    Console.Write("Öğrenci Soyadı Giriniz: ");
            //        //    ogrenci1.soyad = Console.ReadLine();
            //        //    Console.Write("Öğrenci Numara Giriniz: ");
            //        //    ogrenci1.numara =int.Parse( Console.ReadLine());

            //        //} while (ogrenci1.numara>0);
            //        //while (ogrenci1.numara > 0)
            //        //{
            //        //    Console.Write("Öğrenci Adını Giriniz: ");
            //        //    ogrenci1.ad = Console.ReadLine();
            //        //    Console.Write("Öğrenci Soyadı Giriniz: ");
            //        //    ogrenci1.soyad = Console.ReadLine();
            //        //    Console.Write("Öğrenci Numara Giriniz: ");
            //        //    ogrenci1.numara = int.Parse(Console.ReadLine());
            //        //}
            //        //ogrenci1.BilgiGetir(); 
            //        #endregion
            //        Console.ReadLine();
            //    }
            //}
            //class Ogrenci
            //{
            //    public Ogrenci()
            //    {

            //    }
            //    public string ad;
            //    public string soyad;

            //    //int numara;
            //    private int Numra;

            //    public int _Numara
            //    {
            //        get { return Numra; }
            //        set { Numra = Math.Abs(value); }
            //    }

            //    #region III.Yol
            //    //public int Numara 
            //    //{
            //    //    get 
            //    //    {
            //    //        return this.numara;
            //    //    }
            //    //    set
            //    //    {
            //    //        this.numara = Math.Abs(value);
            //    //    }
            //    //} 
            //    #endregion
            //    #region II.Yol
            //    //public int Numara 
            //    //{ 
            //    //    get => numara; 
            //    //    set => numara = Math.Abs(value); 
            //    //} 
            //    #endregion
            //    #region I.Yöntem
            //    //public void SetNumber(int number)
            //    //{      //10              //|-10|
            //    //    this.numara = Math.Abs(number);
            //    //}
            //    //public int GetNumber()
            //    //{
            //    //    return this.numara;
            //    //} 
            //    #endregion

            //    public  void BilgiGetir()
            //    {
            //        Console.WriteLine($"Adınız:{ad} Soyadınız:{soyad} ");
            //    }
            //}
            //public class Ev
            //{
            //    public Ev(int katsayisi, int odasyisi, string konum)
            //    {

            //        this.Konum = konum;
            //        this.KatSayisi = katsayisi;
            //        this.OdaSayisi = odasyisi;
            //    }
            //    public int KatSayisi { get; set; }
            //    public int OdaSayisi { get; set; }
            //    public string Konum { get; set; }
            //    //public void BilgiGetir()
            //    //{
            //    //    Console.WriteLine($"Ev BilGileri: Kat: {KatSayisi}-Oda:{OdaSayisi}-Konum:{Konum}");
            //    //} 
            #endregion
            #region Inheritance ve Örneği
            //        //OOP İlkeleri
            //        //1-Kalıtım
            //        //2-Kapsülleme
            //        //3-ÇokBiçimlilik
            //        //4-Soyutlama
            //        //Kalıtım kuralı: Bir sınıf sadece bir sınıftan kalıtım alabilir.
            //        //this:aynı class
            //        //base: ana classı tetiklemek için kullanılır.
            //        Köpek köpek = new Köpek();
            //        Console.WriteLine(köpek.Boy = 15);
            //        Console.WriteLine(köpek.Kilo = 15);
            //        Kedi kedi = new Kedi();
            //        Console.WriteLine(kedi.Boy = 20);
            //        Console.WriteLine(kedi.Kilo = 10);
            //        B b = new B();
            //        //Hayvanlar hy = new Kedi();
            //        //Canlılar cn = new Köpek();

            //        Hayvanlar[] hayvanlar = new Hayvanlar[2];
            //        hayvanlar[0] = köpek;
            //        hayvanlar[1] = kedi;
            //        foreach (var item in hayvanlar)
            //        {
            //            Console.WriteLine(item.Kilo+"--" + item.Boy);
            //        }
            //        Console.ReadLine();
            //    }
            //}
            ////Name Hiding
            //class A
            //{
            //    public int X { get; set; }
            //}
            //class B:A
            //{
            //    public new int X { get; set; }
            //}
            //public class YavruKedi : Kedi
            //{
            //    public YavruKedi()
            //    {

            //    }
            //}
            //public class Köpek : Hayvanlar//child-(derived)class
            //{
            //    public Köpek()
            //    {

            //    }
            //    public string Havala()
            //    {
            //        return "Hav hav";
            //    }
            //}
            //public class Kedi : Hayvanlar//child class
            //{
            //    public Kedi()

            //    {

            //    }
            //    public string Miyavla()
            //    {
            //        return "miyav miyav";
            //    }
            //}
            //public class Hayvanlar : Canlılar
            //{
            //    public Hayvanlar() : base(12)
            //    {

            //    }
            //    public char Cinsiyet { get; set; }
            //}
            //public class Canlılar//base class
            //{
            //    public Canlılar(int a)
            //    {

            //    }
            //    public int Kilo { get; set; }
            //    public int Boy { get; set; }
            //    public bool Yemek { get; set; }
            //    public bool Enerji { get; set; }
            //} 
            #endregion
            #region Polymorphism ve Örneği
            //        //virtual/abstarct/ovveride eziyorsun.
            //        //method overloading
            //        Kangal kn = new Kangal();
            //        Console.WriteLine(kn.Boy = 10);
            //        Console.WriteLine(kn.Kilo = 10);
            //        Console.WriteLine(kn.Havla());
            //        Console.WriteLine("----------");
            //        Golden gl = new Golden();
            //        Console.WriteLine(gl.Boy = 15);
            //        Console.WriteLine(gl.Kilo = 15);
            //        Console.WriteLine(gl.Havla());
            //        Console.WriteLine("----------");
            //        Terrier te = new Terrier();
            //        Console.WriteLine(te.Boy = 3);
            //        Console.WriteLine(te.Kilo = 3);
            //        Console.WriteLine(te.Havla());
            //        Console.ReadLine();

            //    }
            //}
            //public class Terrier : Kopekler
            //{
            //    public override string Havla()
            //    {
            //        return "Hiv";
            //    }
            //    public bool Sus { get; set; }
            //}
            ////virtual:kalıtım alan sınıf isterse beni ezebilir. ya da aynen kullanabilirr
            //public class Kopekler
            //{
            //    public int Boy { get; set; }
            //    public int Kilo { get; set; }
            //    public string Cinsiyet { get; set; }
            //    public virtual string Havla()
            //    {
            //        return "Hav hav";
            //    }
            //}
            //public class Kangal : Kopekler
            //{
            //    public override string Havla()
            //    {
            //        return "Sivaslıyım";
            //    }
            //    public bool Coban { get; set; }
            //}
            //public class Golden : Kopekler
            //{
            //    public override string Havla()
            //    {
            //        return "Kanka Naber:)";
            //    }
            //    public bool Oyuncu { get; set; }
            //} 
            #endregion
            #region Abstraction - KonuAnlatım
            //Urunler urunler = new Urunler();
            // Ekmek em = new Ekmek();
            // Console.WriteLine(em.Marka="Uno");
            //Console.WriteLine( em.Fiyat = 10);
            //Console.WriteLine( em.UnTipi = "Kepek");
            // Console.WriteLine(em.KdvFiyat());
            // Console.WriteLine("-------------");
            // Çikolata çik = new Çikolata();
            // Console.WriteLine(çik.Marka = "Ülker");
            // Console.WriteLine(çik.Fiyat = 15);
            // Console.WriteLine(çik.Tip="Bitter");
            // Console.WriteLine(çik.KdvFiyat());
            // Console.WriteLine("-------------");
            // Sut st = new Sut();
            // Console.WriteLine(st.Marka = "Pınar");
            // Console.WriteLine(st.Fiyat = 20);
            // Console.WriteLine(st.Cesit = "YarımYağlı");
            // Console.WriteLine(st.KdvFiyat());
            // Console.WriteLine("-------------");
            // Urunler[] sepet = new Urunler[3];
            // sepet[0] = em;
            // sepet[1] = çik;
            // sepet[2] = st;
            // decimal toplam = 0;
            // foreach (Urunler item in sepet)
            // {
            //     toplam += item.KdvFiyat();
            // }
            // Console.WriteLine(toplam + "TL Ödediniz.."); 
            #endregion
            #region Abstraction - Örnek
            //        Çikolata çk = new Çikolata();
            //        Console.WriteLine("Kaç kilo Çikolata alacaksın?: ");
            //        çk.KacKg = byte.Parse(Console.ReadLine());

            //        Console.WriteLine(çk.KdvFiyat());
            //        Console.ReadLine();
            //    }
            //}
            //public abstract class Urunler
            ////Soyut sınıftır.Kalıtım Almadan hiç bir sınıf bunu kullanamz. 
            ////nesnesi oluşturulamaz.
            //{
            //    public string Marka { get; set; }
            //    public decimal Fiyat { get; set; }
            //    public abstract decimal KdvFiyat();

            //}
            //class Sut : Urunler
            //{
            //    public string Cesit { get; set; }

            //    public override decimal KdvFiyat()
            //    {
            //        return Fiyat * (1.14M);
            //    }
            //}
            //public class Ekmek : Urunler
            //{
            //    public string UnTipi { get; set; }

            //    public override decimal KdvFiyat()
            //    {
            //        return Fiyat * (1.12M);
            //    }
            //}
            //public class Çikolata : Urunler
            //{

            //    const decimal kgFiyat = 10M;

            //    public byte KacKg { get; set; }
            //    public Çikolata()
            //    {

            //    }
            //    public string Tip { get; set; }

            //    public override decimal KdvFiyat()
            //    {
            //        return (KacKg * kgFiyat) * (1.18M);
            //    }
            //} 
            #endregion
            #region Interface - Örnek
            //        SamsungNote10 sam = new SamsungNote10();
            //        sam.Fiyat = 10000M;
            //        AppleIphone13 ip = new AppleIphone13();
            //        ip.Fiyat = 15000M;
            //        ICepTelefonu[] cep = new ICepTelefonu[2];
            //        cep[0] = ip;
            //        cep[1] = sam;

            //        decimal toplam = 0;
            //        foreach (var item in cep)
            //        {
            //            toplam += item.KDV();
            //        }

            //        Console.WriteLine(toplam);
            //        Console.ReadLine();
            //    }
            //}
            //public class SamsungNote10 : ICepTelefonu
            //{
            //    public bool Sarj { get; set; }
            //    public decimal EkranBoyutu { get; set; }
            //    public string Marka { get; set; }
            //    public string Model { get; set; }
            //    public decimal Fiyat { get; set; }

            //    public bool Arama()
            //    {
            //        return true;
            //    }

            //    public decimal KDV()
            //    {
            //        return Fiyat * 1.10M;
            //    }

            //    public bool Mesaj()
            //    {
            //        return true;
            //    }

            //    public string Ses()
            //    {
            //        return "Zır Zır";
            //    }
            //}
            //public interface ITelefon : IElektronik
            //{
            //    string Ses();
            //    bool Arama();
            //}
            //public interface IElektronik
            //{
            //    string Marka { get; set; }
            //    string Model { get; set; }
            //    decimal Fiyat { get; set; }
            //    decimal KDV();
            //}
            //public interface ICepTelefonu : ITelefon
            //{
            //    bool Sarj { get; set; }
            //    bool Mesaj();
            //    decimal EkranBoyutu { get; set; }
            //}
            //public class AppleIphone13 : ICepTelefonu
            //{
            //    public bool Sarj { get; set; }
            //    public decimal EkranBoyutu { get; set; }
            //    public string Marka { get; set; }
            //    public string Model { get; set; }
            //    public decimal Fiyat { get; set; }

            //    public bool Arama()
            //    {
            //        return true;
            //    }

            //    public decimal KDV()
            //    {
            //        return Fiyat * 1.20M;
            //    }

            //    public bool Mesaj()
            //    {
            //        return true;
            //    }

            //    public string Ses()
            //    {
            //        return "Dot Dot";
            //    }
            //} 
            #endregion
            #region Interface - Örnek 2
            //        //IUrun urun = new Domates();
            //        Domates domates = new Domates();
            //        C c = new C();
            //    }
            //}
            //public abstract class Sebzeler : IUrun
            //{
            //    public string Marka { get; set; }
            //    public decimal Fiyat { get; set; }

            //    public abstract decimal KDV();

            //}
            //public interface IUrun2
            //{
            //    decimal KDV();
            //}
            //public interface IBaseUrun : IUrun2, IUrun
            //{
            //}
            //public interface IBaseUrun2 : IBaseUrun
            //{
            //}
            //public abstract class A
            //{
            //    public abstract decimal KDV();
            //}
            //public abstract class B : A
            //{

            //}
            //public class C : B
            //{
            //    public override decimal KDV()
            //    {
            //        throw new NotImplementedException();
            //    }
            //}
            //public interface IUrun : IUrun2
            //{
            //    #region İnterface
            //    ////Erişim Bildirgeci: public-private-internal
            //    ////İnterfaceler içerisnde tanımlanan üyeler erişim bildirhgeci almazlar
            //    ////İnterfaceleri ayırt edebilmek için isimlendirken başına I konulur. 
            //    ////Tamamen soyuttur. 
            //    ////interfaceler uygulama verir. :IUrun
            //    ////uygulama verdiği classta içinde barındırdığı her şeyi verme zorunluluğu vardır.  
            //    #endregion

            //    string Marka { get; set; }
            //    decimal Fiyat { get; set; }
            //}
            //public class Domates : Sebzeler
            //{
            //    public override decimal KDV()
            //    {
            //        return Fiyat * 1.12M;
            //    }
            //}
            ////internal class A
            ////  {
            ////      public int MyProperty { get; set; }
            ////  } 
            #endregion
            #region Kolleksiyonlar - Konuanlatım
            //int[] sayilar = new int[3];
            //sayilar[0]= 1;
            //sayilar[1] = 10;
            //sayilar[2] = 15;
            //Farklı tip verileri de bir arada tutan yapılardır. 
            //using System.Collections.Generic;
            //using System.Collections; 
            #endregion
            #region ArrayList
            //ArrayList ar = new ArrayList();
            //ar.Add("Emir");
            //ar.Add(10);
            //ar.Add('E');
            //ar.Add(10.5);
            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------");
            //ar.Remove("Emir");
            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------");
            //ar.RemoveAt(2);
            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------");
            //ar.Clear();
            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Hashtable
            //Hashtable ht = new Hashtable();
            //ht.Add("Ank", "Ankara");
            //ht.Add(34, "İstanbul");
            //ht.Add(35, "İzmir");
            ////Console.WriteLine(ht[34]);
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            //Console.WriteLine("----------------");
            //ht.Remove(34);
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            //Console.WriteLine("----------------");
            //ht.Remove("Ank");
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //} 
            #endregion
            #region Queue
            //Queue qu = new Queue();

            //qu.Enqueue("Bibi-769");
            //qu.Enqueue("Hakan");
            //qu.Enqueue("Tuğgen");
            //qu.Enqueue("Okan");
            //qu.Enqueue("İrem");
            //qu.Enqueue("Emirhan");
            //foreach (var item in qu)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------");
            //qu.Dequeue();
            //foreach (var item in qu)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(qu.Peek()); 
            #endregion
            #region Stack
            //Stack st = new Stack();
            //st.Push(1);
            //st.Push(2);
            //st.Push(3);
            //st.Push(4);
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------");
            //st.Pop();
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(st.Peek()); 
            #endregion
            #region Queue<>
            //Queue<int> qu = new Queue<int>();
            //qu.Enqueue(10);
            //qu.Enqueue(20);
            //qu.Enqueue(30);
            //qu.Enqueue(40);
            //foreach (var item in qu)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Stack<>
            //Stack<string> st = new Stack<string>();
            //st.Push("10");
            //st.Push("Ali");
            //st.Push("Ayşe");
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Hashtable<>
            //Dictionary<int, string> ht = new Dictionary<int, string>();
            //ht.Add(10, "gdfgfd");
            //foreach (KeyValuePair<int,string> item in ht)
            //{
            //    Console.WriteLine(item.Key + item.Value);
            //} 
            #endregion
            #region List
            //List<int> sayilar = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine(); 
            #endregion
        }
    }
}
