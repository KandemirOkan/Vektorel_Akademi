using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yıldızdan Üçgen
            //try
            //{
            //    Console.WriteLine("Yapmak istediğiniz yıldızın satır büyüklüğünü giriniz: ");
            //    byte raw = byte.Parse(Console.ReadLine());
            //    int a = 1;
            //    for (int i = 1; i < raw + 1; i++)
            //    {
            //        a = i;
            //        while (a >= 1)
            //        {
            //            Console.Write("*");
            //            a--;
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format Hatası yaptınız..");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası bir sayı giriniz..");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmeyen bir hata oluştu..");
            //}
            //Console.ReadLine(); 
            #endregion
            #region Yıldızdan Kare
            //try
            //{
            //    Console.WriteLine("Yapmak istediğiniz yıldızdan dikdörtgenin satır büyüklüğünü giriniz(Max.55): ");
            //    byte row = byte.Parse(Console.ReadLine());
            //    if (row <= 55&row>0)
            //    {
            //        if (row % 2 == 0)
            //        {
            //            row++;
            //        }
            //        int a;
            //        int b = row;
            //        while (b >= 1)
            //        {
            //            a = 2*row-1;
            //            while (a >= 1)
            //            {
            //                if (b == row || b == 1)
            //                {
            //                    if (a % 2 == 1)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //                else
            //                {
            //                    if ((a == 2*row-1 || a == 2))
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    Console.Write(" ");
            //                }
            //                a--;
            //            }
            //            Console.WriteLine();
            //            b--;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Min=1 , Max=55 satırlık kare yapılabilmektedir. ");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format Hatası yaptınız..");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("1-55 arası bir sayı giriniz..");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmeyen bir hata oluştu..");
            //}
            //Console.ReadLine();
            #endregion
            #region Feyza Esertepe Giremesin Ödevi
            //try
            //{
            //    Console.WriteLine("C# Kursu Sınıf 179 - Öğrenci Dedikodu Grubu Üyelik Sayfası: ");
            //    while (true)
            //    {
            //        Console.WriteLine("Yeni Üye Kaydı ");
            //        Console.Write("Ad-Soyad: ");
            //        string name = Console.ReadLine();
            //        if (name.ToLower() == "feyza esertepe")
            //        {
            //            break;
            //        }
            //        Console.WriteLine("TC. Kimlik numaranız: ");
            //        string kimlik_no = Console.ReadLine();
            //        double kimlik_no2 = double.Parse(kimlik_no);
            //        while (true)
            //        {
            //            if (kimlik_no.Length < 11)
            //            {
            //                Console.WriteLine("TC. Kimlik numarası 11 haneden küçük olamaz. Tekrar Deneyiniz...\n ");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Telefon numarası ");
            //                string phone_number = Console.ReadLine();
            //                Console.WriteLine("Yaş: ");
            //                byte age = byte.Parse(Console.ReadLine());
            //                Console.WriteLine("Üyelik kaydınız başarıyla tamamlanmıştır.");
            //                Console.WriteLine();
            //                Console.ReadLine();
            //                break;
            //            }
            //        }
            //        break;
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format hatası.");
            //    Console.ReadLine();
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Uygun aralıkta bir yaş giriniz.");
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmedik bir hata oluştu.");
            //    Console.ReadLine();
            //    // Hocam biliyorum bir sürü Console.ReadLine kullanmamızı istemiyorusunuz ama Feyza Esertepe verdiğininde programın komple kapanması için böyle yaptım. 
            //}
            #endregion
            #region Random - Aynı sayıyı seçtirmeme
            //try
            //{
            //    Random random = new Random();
            //    Console.Write("1 ile 100 arasında kaç tane rasgele sayı seçmek istiyorsunuz: ");
            //    byte tane = byte.Parse(Console.ReadLine());
            //    int[] dizi = new int[tane];
            //    for (int i = 0; i < tane; i++)
            //    {
            //        int a = random.Next(1, 100);
            //        if (dizi.Contains(a))
            //        {
            //            Console.WriteLine($"{i + 1}. sayı daha önceki sayılardan birine eşittir.");
            //        }
            //        else
            //        {
            //            dizi[i] = a;
            //        }
            //        if (dizi[i] != 0)
            //        {
            //            Console.WriteLine($"{i + 1}. sayı = {dizi[i]}");
            //        }
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format Hatası.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Uygun aralıkta bir sayı giriniz.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmedik bir hata oluştu.");
            //}
            //Console.ReadLine(); 
            #endregion
        }
    }
}
