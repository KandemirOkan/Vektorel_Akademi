using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("İsim: ");
            string name = Console.ReadLine();
            Console.Write("Soyisim: ");
            string lastname = Console.ReadLine();
            Console.Write("Yaş: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Doğum Yeri: ");
            string bplace = Console.ReadLine();
            Console.Write("Meslek: ");
            string job = Console.ReadLine();
            Console.Write("İşe Giriş Yılı: ");
            ushort year = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Maaş: ");
            int salary = Convert.ToUInt16(Console.ReadLine());
            Console.Write($"\n\n\nTebrikler!!!\nOnline Finans Firmamızın İlk Müşterisi {name} {lastname} Websitemize Hoşgeldiniz!!!\n{age} yaşındaki {bplace} doğumlu müşterimiz,\n{job} gibi güzel bir mesleğe sahipsiniz.\n{year} yılından beri de çalışıyormuşsunuz.\n{salary} Lira hiç fena bir maaş değil.\n\nZamlı maaş hesaplaması kısmına geçmek istiyorsanız lütfen bir tuşa basınız...");
            Console.ReadLine();
            Console.WriteLine("Yıllık enflasyon miktarı(%): ");
            float inf = Convert.ToSingle(Console.ReadLine());
                inf = inf / 100;
            Console.WriteLine("Enflasyona ilaveten refah payı beklentiniz: ");
            float raiseratio = Convert.ToSingle(Console.ReadLine());
            float newsalary;
            float newraisedsalary;
            newsalary = salary * (1+inf);
            newraisedsalary = salary * (1 +inf + (raiseratio / 100));
            Console.WriteLine($"Eğer enflasyon kadar zam alırsanız yeni maaşınız: {newsalary}\nEğer enflasyon üzerine, girdiğiniz refah payı kadar zam daha alırsanız; Yeni maaşınız: {newraisedsalary} olacaktır.");
            Console.WriteLine(newsalary);
            Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Bir hata ile karşılaşıldı.\nLütfen bilgileri yazım ve mantık kurallarına uygun bir şekilde giriniz.");
                Console.ReadLine();
            }
        }
    }
}
