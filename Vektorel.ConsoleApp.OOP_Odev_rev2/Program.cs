using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.OOP_Odev_rev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HepsiOrada.com'a Hoşgeldiniz...\nLütfen Yapmak istediğiniz işlemi seçiniz:\n");
            Mavi mavi = new Mavi();
            LCW lcw = new LCW();
            Lacoste lacoste = new Lacoste();
            string[] markadizisi = new string[0];
            string[] tipdizisi = new string[0];
            decimal[] fiyatdizisi = new decimal[0];
            int[] adetdizisi = new int[0];
            int a = 0;
            decimal result = 0;
            while (true)
            {
                try
                {
                    Console.Write("0) Satın almadan çıkış yapmak istiyorsanız 0'ı ,\n1) Ürünleri ve Fiyatlarını Listelemek istiyorsanız 1'i,\n2) Sepete gitmek istiyorsanız 2'yi\n3) Sepetinize yeni bir üren eklemek istiyorsanız 3'ü tuşlayın: ");
                    byte answer = byte.Parse(Console.ReadLine());
                    if (answer == 0)
                    {
                        break;
                    }
                    else if (answer == 1)
                    {

                        {
                            Console.WriteLine($"\nMavi Marka Ürünlerin listesi:\n{lcw.Gömlek} {mavi.Fiyatlar(1)}\n{mavi.Kazak} {mavi.Fiyatlar(2)}\n{mavi.Pantolon} {mavi.Fiyatlar(3)}\n{mavi.T_Shirt} {mavi.Fiyatlar(4)}\n{mavi.Etek} {mavi.Fiyatlar(5)}\n\nLCW Marka Ürünlerin listesi:\n{lcw.Gömlek} {lcw.Fiyatlar(1)}\n{lcw.Kazak} {lcw.Fiyatlar(2)}\n{lcw.Pantolon} {lcw.Fiyatlar(3)}\n{lcw.T_Shirt} {lcw.Fiyatlar(4)}\n{lcw.Ayakkabı} {lcw.Fiyatlar(6)}\n\nLacoste Marka Ürünlerin listesi:\n{lacoste.Gömlek} {lacoste.Fiyatlar(1)}\n{lacoste.Kazak} {lacoste.Fiyatlar(2)}\n{lacoste.Pantolon} {lacoste.Fiyatlar(3)}\n{lacoste.T_Shirt} {lacoste.Fiyatlar(4)}\n{lacoste.Şapka} {lacoste.Fiyatlar(7)}");
                        }
                        Console.WriteLine();
                    }
                    else if (answer == 2)
                    {
                        if (adetdizisi.Length == 0)
                        {
                            Console.WriteLine("\nSepetinizde hiç ürün bulunmamaktadır.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nSepetinizde bulunan ürünler: ");
                            for (int i = 0; i < a; i++)
                            {
                                Console.Write($"{adetdizisi[i]} adet {markadizisi[i]} {tipdizisi[i]} {fiyatdizisi[i] * adetdizisi[i]} TL\n");

                            }
                            Console.WriteLine("\nSepetinizdeki Ürünlerin Toplam Tutarı: ");
                            for (int i = 0; i < a; i++)
                            {
                                result = result + fiyatdizisi[i] * adetdizisi[i];
                            }
                            Console.WriteLine($"{result} TL (KDV dahildir).");
                            Console.ReadLine();
                            break;
                        }
                    }
                    else if (answer == 3)
                    {
                        Console.Write("\nAlmak istediğiniz Markayı Girin: (1)LCW (2)MAVİ (3)LACOSTE: ");
                        byte marka = byte.Parse(Console.ReadLine());
                        if (marka>3)
                        {
                            Console.WriteLine("\nHatalı bir seçim yaptınız.\n");
                        }
                        else
                        {
                        Console.Write("\nSatın almak istediğiniz ürün tipini giriniz.\nGömlek(1),Kazak(2),Pantolon(3),T-Shirt(4),Etek(5),Ayakkabı(6),Şapka(7): ");
                        byte dress = byte.Parse(Console.ReadLine());
                        Console.Write("Almak istediğiniz adet sayısını Girin: ");
                        int tane = int.Parse(Console.ReadLine());
                        Array.Resize(ref adetdizisi, adetdizisi.Length + 1);
                        Array.Resize(ref markadizisi, markadizisi.Length + 1);
                        Array.Resize(ref tipdizisi, tipdizisi.Length + 1);
                        Array.Resize(ref fiyatdizisi, fiyatdizisi.Length + 1);
                        if (marka == 1)
                        {
                            if (lcw.Tip(dress) == "hata")
                            {
                                Console.WriteLine("\nHatalı bir seçin yaptınız.\n");
                            }
                            else
                            {
                                adetdizisi[a] = tane;
                                markadizisi[a] = "LCW";
                                tipdizisi[a] = lcw.Tip(dress);
                                fiyatdizisi[a] = lcw.Fiyatlar(dress);
                                Console.WriteLine($"\nSepetinize {adetdizisi[a]} adet {lcw.Markalar(marka)} marka {tipdizisi[a]} ürün eklenmiştir.\n");
                            }
                        }
                        else if (marka == 2)
                        {
                            if (mavi.Tip(dress) == "hata")
                            {
                                Console.WriteLine("\nHatalı bir seçin yaptınız.\n");
                            }
                            else
                            {
                                adetdizisi[a] = tane;
                                markadizisi[a] = "Mavi";
                                tipdizisi[a] = mavi.Tip(dress);
                                fiyatdizisi[a] = mavi.Fiyatlar(dress);
                                Console.WriteLine($"\nSepetinize {adetdizisi[a]} adet {mavi.Markalar(marka)} marka {tipdizisi[a]} ürün eklenmiştir.\n");
                            }
                        }
                        else if (marka == 3)
                        {
                            if (lacoste.Tip(dress) == "hata")
                            {
                                Console.WriteLine("\nHatalı bir seçim yaptınız.\n");
                            }
                            else
                            {
                                adetdizisi[a] = tane;
                                markadizisi[a] = "Lacoste";
                                tipdizisi[a] = lacoste.Tip(dress);
                                fiyatdizisi[a] = lacoste.Fiyatlar(dress);
                                Console.WriteLine($"\nSepetinize {adetdizisi[a]} adet {lacoste.Markalar(marka)} marka {tipdizisi[a]} ürün eklenmiştir.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı bir işlem yaptınız.");
                        }
                        a++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nHatalı bir seçim yaptınız.\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format Hatası yaptınız.\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Makul aralıkta bir sayı giriniz.\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("Beklenmeyen bir hata oluştu.\n");
                }
            }
        }
    }
        public class TumMarkalar
        {
            public string Gömlek { get { return "Gömlek"; } }
            public string Kazak { get { return "Kazak"; } }
            public string Pantolon { get { return "Pantolon"; } }
            public string T_Shirt { get { return "T-Shirt"; } }
            public virtual decimal Fiyatlar(byte tip)
            {
                switch (tip)
                {
                    case 1:
                        return 120;
                    case 2:
                        return 150;
                    case 3:
                        return 200;
                    case 4:
                        return 130;
                    default:
                        return -1;
                }
            }
            public virtual string Tip(byte tip)
            {
                switch (tip)
                {
                    case 1:
                        return "Gömlek";
                    case 2:
                        return "Kazak";
                    case 3:
                        return "Pantolon";
                    case 4:
                        return "T-Shirt";
                    default:
                        return "Bilinmeyen bir ürün.";
                }
            }
            public string Markalar(byte markaa)
            {
                switch (markaa)
                {
                    case 1:
                        return "LCW";
                    case 2:
                        return "MAVİ";
                    case 3:
                        return "LACOSTE";
                    default:
                        return "Hatalı bir marka seçimi yaptınız.";
                }
            }
        }
        public class Mavi : TumMarkalar
        {
            public string Etek { get { return "Etek"; } }
            public override string Tip(byte tip)
            {
                if (tip <= 4)
                {
                    return base.Tip(tip);
                }
                else if (tip == 5)
                {
                    return "Etek";
                }
                else
                {
                    return "hata";
                }
            }
            public override decimal Fiyatlar(byte tip)
            {
                if (tip <= 4)
                {
                    return base.Fiyatlar(tip) * 2;
                }
                else if (tip == 5)
                {
                    return 200*2;
                }
                else
                {
                    return -1;
                }
            }
        }
        public class LCW : Mavi
        {
            public string Ayakkabı { get { return "Ayakkabı"; } }
            public override string Tip(byte tip)
            {
                if (tip <= 4)
                {
                    return base.Tip(tip);
                }
                else if (tip == 6)
                {
                    return "Ayakkabı";
                }
                else
                {
                    return "hata";
                }
            }
            public override decimal Fiyatlar(byte tip)
            {
                if (tip <= 5)
                {
                    return base.Fiyatlar(tip)/2;
                }
                else if (tip == 6)
                {
                    return 250;
                }
                else
                {
                    return -1;
                }
            }
        }
        public class Lacoste : TumMarkalar
        {
            public string Şapka { get { return "Şapka"; } }
            public override string Tip(byte tip)
            {
                if (tip <= 4)
                {
                    return base.Tip(tip);
                }
                else if (tip == 7)
                {
                    return "Şapka";
                }
                else
                {
                    return "hata";
                }
            }
            public override decimal Fiyatlar(byte tip)
            {
                if (tip <= 4)
                {
                    return base.Fiyatlar(tip)*4;
                }
                else if (tip == 7)
                {
                    return 400;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
