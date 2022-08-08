using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.OOP_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //int i = 0;
                //string[] my_sepet = new string[0];
                Console.WriteLine("HepsiOrada.com'a Hoşgeldiniz.");
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
                        Fiyat_Listesi();
                        Console.WriteLine();
                    }
                    else if (answer == 2)
                    {
                        Console.WriteLine("\nBu özellik maalesef henüz tamamlanmadı. En kısa sürede sitemiz güncellenecektir.\n***********************************************************************************\n");
                        //Sepetim(my_sepet);
                    }
                    else if (answer == 3)
                    {
                        Console.Write("Satın almak istediğiniz ürün tipini giriniz.\nGömlek(1),Pantolon(2),T-Shirt(3),Kazak(4),Etek(5): ");
                        byte tip = byte.Parse(Console.ReadLine());
                        if (tip <=5)
                        {
                        Console.Write("Almak istediğiniz Markayı Girin: (1)LCW (2)MAVİ (3)LACOSTE: ");
                        byte marka = byte.Parse(Console.ReadLine());
                            if (marka <=3)
                            {
                        Console.Write("Almak istediğiniz adet sayısını Girin: ");
                        byte tane = byte.Parse(Console.ReadLine());
                        Console.WriteLine($"\n{tane} adet {Marka(marka)} marka {Tip(tip)} ürün sepetinize eklenmiştir...\n\n***********************************************************\n");
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
                        //Array.Resize(ref my_sepet, my_sepet.Length + 1);
                        //my_sepet[İ] = "{tane} adet {Marka(marka)} marka {Tip(tip)}";
                        //i++;
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
        //public static void Sepetim(mysepet)
        //{
        //    for (int i = 0; i < mysepet.Length; i++)
        //    {
        //        Console.WriteLine(mysepet[i]);
        //    }
        //}
        public static string Marka(byte mark)
        {
            switch (mark)
            {
                case 1:
                    return "LCW";
                case 2:
                    return "Mavi";
                case 3:
                    return "Lacoste";
                default:
                    return "Bu marka mağazamızda mevcut değildir.";
            }
        }
        public static string Tip(byte tip)
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
                    return "Bu ürün mağazamızda mevcut değildir.";
            }
        }
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
                final_dizi[i, 1] = urun_dizisi[i-5];
                final_dizi[i, 2] = (fiyat_dizisi[(i-5)]*2).ToString();
            }
            for (int i = 10; i < 15; i++)
            {
                final_dizi[i, 0] = "Lacoste ";
                final_dizi[i, 1] = urun_dizisi[i-10];
                final_dizi[i, 2] = (fiyat_dizisi[(i-10)]*4).ToString();
            }
            
            for (int i = 0; i < final_dizi.GetLength(0); i++)
            {
                if (i==0||i==5||i==10)
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
    }
}
