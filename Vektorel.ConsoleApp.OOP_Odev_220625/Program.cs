using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.OOP_Odev_220625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] markalar = new string[0];
            string[] urunler = new string[0];
            int[] adetler = new int[0];
            int[] fiyatlar = new int[0];
            int a = 0;
            int result=0;
            Urun urun1 = new Urun();
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
                        Console.WriteLine();
                        Urun.Fiyat_Listesi();
                        Console.WriteLine();
                    }
                    else if (answer == 2)
                    {  
                        if (adetler[0] ==0)
                        {
                            Console.WriteLine("Sepetinizde hiç ürün bulunmamaktadır.")
                        }
                        else
                        {
                            Console.WriteLine("\nSepetinizde bulunan ürünler: ");
                            Console.WriteLine(adetler.Length());
                        }
                        for (int i = 0; i < a; i++)
                        {
                            Console.Write($"{adetler[i]} adet {markalar[i]} {urunler[i]} {fiyatlar[i]}\n");

                        }
                        Console.WriteLine("\nSepetinizdeki Ürünlerin Toplam Tutarı: ");
                        for (int i = 0; i < a; i++)
                        {
                            result = result + fiyatlar[i];
                        }
                        Console.WriteLine($"{result} TL (KDV dahildir).");
                        Console.ReadLine();
                        break;
                    }
                    else if (answer == 3)
                    {
                        Console.Write("Satın almak istediğiniz ürün tipini giriniz.\nGömlek(1),Pantolon(2),T-Shirt(3),Kazak(4),Etek(5): ");
                        byte tip = byte.Parse(Console.ReadLine());
                        urun1.Cesit = urun1.Tip(tip);

                        if (tip <= 5)
                        {
                            Console.Write("Almak istediğiniz Markayı Girin: (1)LCW (2)MAVİ (3)LACOSTE: ");
                            byte marka = byte.Parse(Console.ReadLine());
                            urun1.Marka = urun1.Brand(marka);
                            if (marka <= 3)
                            {
                                Console.Write("Almak istediğiniz adet sayısını Girin: ");
                                int tane = int.Parse(Console.ReadLine());
                                urun1.Adet = tane;
                                Console.WriteLine($"\n{tane} adet {urun1.Marka} marka {urun1.Cesit} sepetinize eklenmiştir...\n\n***********************************************************\n");
                                Array.Resize(ref markalar, markalar.Length + 1);
                                Array.Resize(ref urunler, urunler.Length + 1);
                                Array.Resize(ref adetler, adetler.Length + 1);
                                Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                                markalar[a] = urun1.Marka;
                                urunler[a] = urun1.Cesit;
                                adetler[a] = tane;
                                if (urun1.Marka=="LCW")
                                {
                                    fiyatlar[a] = urun1.Price(tip) * tane;
                                }
                                else if (urun1.Marka=="Mavi")
                                {
                                    fiyatlar[a] = urun1.Price(tip) * tane*2;
                                }
                                else
                                {
                                    fiyatlar[a] = urun1.Price(tip) * tane*4;
                                }
                                a++;
                            }
                            else
                            {
                                Console.WriteLine("Yanlış bir işlem yaptınız.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlış bir işlem yaptınız.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış bir işlem yaptınız.");
                        break;
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
    public class Urun
    {
        public Urun()
        {

        }
        public Urun(string marka, string cesit, decimal fiyat, int adet)
        {
            Marka = marka;
            Cesit = cesit;
            Fiyat = fiyat;
            Adet = adet;
        }
        public string Marka { get; set; }
        public string Cesit { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }

        public static void Fiyat_Listesi()
        {
            string[] urun_dizisi = { "Gömlek ", "Pantolon ", "T-Shirt ", "Kazak ", "Etek " };
            int[] fiyat_dizisi = { 120, 250, 90, 130, 150 };
            string[,] final_dizi = new string[15, 3];
            for (int i = 0; i < 5; i++)
            {
                final_dizi[i, 0] = "LCW ";
                final_dizi[i, 1] = urun_dizisi[i];
                final_dizi[i, 2] = fiyat_dizisi[i].ToString();
            }
            for (int i = 5; i < 10; i++)
            {
                final_dizi[i, 0] = "Mavi ";
                final_dizi[i, 1] = urun_dizisi[i - 5];
                final_dizi[i, 2] = (fiyat_dizisi[(i - 5)] * 2).ToString();
            }
            for (int i = 10; i < 15; i++)
            {
                final_dizi[i, 0] = "Lacoste ";
                final_dizi[i, 1] = urun_dizisi[i - 10];
                final_dizi[i, 2] = (fiyat_dizisi[(i - 10)] * 4).ToString();
            }

            for (int i = 0; i < final_dizi.GetLength(0); i++)
            {
                if (i == 0 || i == 5 || i == 10)
                {
                    Console.WriteLine("**************************");
                }
                for (int j = 0; j < final_dizi.GetLength(1); j++)
                {
                    Console.Write(final_dizi[i, j]);
                }
                Console.WriteLine();
            }
        }
        public string Tip(byte tip)
        {
            switch (tip)
            {
                case 1:
                    return "Gömlek";
                case 2:
                    return "Pantolon";
                case 3:
                    return "T-Shirt";
                case 4:
                    return "Kazak";
                case 5:
                    return "Etek";
                default:
                    return "Bilinmeyen bir ürün.";
            }
        }
        public int Price(byte tip)
        {
            switch (tip)
            {
                case 1:
                    return 120;
                case 2:
                    return 250;
                case 3:
                    return 90;
                case 4:
                    return 130;
                case 5:
                    return 150;
                default:
                    return -1;  
            }
        }
        public string Brand(byte marka)
        {
            switch (marka)
            {
                case 1:
                    return "LCW";
                case 2:
                    return "Mavi";
                case 3:
                    return "Lacoste";
                default:
                    return "Bilinmeyen bir marka.";
            }
        }
    }
}
