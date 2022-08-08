using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("C# Kursu Sınıf 179 - Öğrenci Dedikodu Grubu Üyelik Sayfası: ");
            while (true)
            {
                Console.WriteLine("Yeni Üye Kaydı ");
                Console.Write("Ad-Soyad: ");
                string name = Console.ReadLine();
                if (name.ToLower() == "feyza esertepe")
                {
                    Console.WriteLine("Hocanın girmesi yasaktır!");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Telefon numarası ");
                string phone_number = Console.ReadLine();
                Console.WriteLine("Yaş: ");
                byte age = byte.Parse(Console.ReadLine());
                Console.WriteLine("Üyelik kaydınız başarıyla tamamlanmıştır.");
                Console.WriteLine();
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format hatası.");
                Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Uygun aralıkta bir yaş giriniz.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Beklenmedik bir hata oluştu.");
                Console.ReadLine();
            }
        }
    }
}
