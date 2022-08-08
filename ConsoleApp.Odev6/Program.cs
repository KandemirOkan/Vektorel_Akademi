using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Odev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer;
            //string brand;
            //byte adet;
            //int i = 0;
            Console.WriteLine("HepsiOrada.com'a Hoşgeldiniz.");
            Console.WriteLine("Satın almak istediğiniz ürün tipini giriniz.\nGömlek(1),Pantolon(2),T-Shirt(3),Kazak(4),Etek(5)\nSatın almadan çıkış yapmak istiyorsanız 0'ı , sepete gitmek istiyorsanız 9'u tuşlayın.");
            Console.ReadLine();
            Fiyat_Listesi();
            Console.ReadLine();
            answer = int.Parse(Console.ReadLine());

            #region MyRegion
            //while (true)
            //{

            //    if (answer == 0)
            //    {
            //        break;
            //    }
            //    else if (answer == 9)
            //    {

            //    }
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Gömlek için; Marka Seçiniz (LCW, Mavi, Lacoste)");
                    brand = Console.ReadLine();
                    Console.WriteLine("Almak istediğiniz adet sayısını giriniz: ");
                    adet = byte.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Pantolon için; Marka Seçiniz (LCW, Mavi, Lacoste)");
                    brand = Console.ReadLine();
                    adet = byte.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("T-Shirt için; Marka Seçiniz (LCW, Mavi, Lacoste)");
                    brand = Console.ReadLine();
                    adet = byte.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Kazan için; Marka Seçiniz (LCW, Mavi, Lacoste)");
                    brand = Console.ReadLine();
                    adet = byte.Parse(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Etek için; Marka Seçiniz (LCW, Mavi, Lacoste)");
                    brand = Console.ReadLine();
                    adet = byte.Parse(Console.ReadLine());
                    break;
            }
        }
        #endregion
    }
        //static void Sepet(string urun, string marka, string adet)
        //{
        //    Console.WriteLine($"Sepetinizde {adet} adet {marka} marka {urun} var.");
        //}
        //static void Fiyat(string urun, string marka, string adet)
        //{
        //    double fiyat;
        //    if (urun.ToLower() == "gomlek"|| urun.ToLower() == "gömlek")
        //    {
        //        fiyat = 150;
        //    }
        //    else if (urun.ToLower() == "pantolon" || urun.ToLower() == "pantalon")
        //    {
        //        fiyat = 200;
        //    }
        //    else if (urun.ToLower() == "t-shirt" || urun.ToLower() == "t shirt" || urun.ToLower() == "tişört")
        //    {
        //        fiyat = 100;
        //    }
        //    else if (urun.ToLower() == "kazak")
        //    {
        //        fiyat = 180;
        //    }
        //    else if (urun.ToLower() == "etek")
        //    {
        //        fiyat = 220;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Aradığınız ürün stoklarımızda bulunmamaktadır.");
        //    }
        public static void Fiyat_Listesi()
        {
            string[] urun_dizisi = { "Gömlek", "Pantolon", "T-Shirt", "Kazak", "Etek" };
            string[] fiyat_dizisi = { "120", "250", "90", "130", "150" };
            string[,] final_dizi = new string[15,3];
            for (int i = 0; i < 5; i++)
            {
                final_dizi[i, 0] = "LCW";
                final_dizi[i, 1] = urun_dizisi[i];
                final_dizi[i, 2] = fiyat_dizisi[i];
            }
            for (int i = 5; i < 10; i++)
            {
                final_dizi[i, 0] = "Mavi";
                final_dizi[i, 1] = urun_dizisi[i];
                final_dizi[i, 2] = fiyat_dizisi[i*2];
            }
            for (int i = 10; i < 15; i++)
            {
                final_dizi[i, 0] = "Lacoste";
                final_dizi[i, 1] = urun_dizisi[i];
                final_dizi[i, 2] = fiyat_dizisi[i*4];
            }
        for (int i = 0; i < final_dizi.GetLength(0); i++)
        {
            for (int j = 0; j < final_dizi.GetLength(1); j++)
            {
                Console.Write(final_dizi[i, j]);
            }
            Console.WriteLine();    
        }
        Console.ReadLine();
        }
    }
}
