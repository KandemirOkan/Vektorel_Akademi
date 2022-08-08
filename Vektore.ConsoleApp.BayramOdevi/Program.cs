using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektore.ConsoleApp.BayramOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            double toplam = 0;
            Console.WriteLine("Decathl0n.com'a Hoşgeldiniz...\nLütfen Yapmak istediğiniz işlemi seçiniz:\n");
            Futbol futbol = new Futbol();
            Basketbol basketbol = new Basketbol();
            Tenis tenis = new Tenis();
            Sepet[] sepet = new Sepet[0];
            Sepet urun = new Sepet();
            try
            {
                while (true)
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
                        for (byte k = 1; k < 4; k++)
                        {
                            urun.Seviye(k);
                            Console.WriteLine($"***************************\n{urun.Seviyesi} için fiyatlar: ");
                            double coef = Math.Pow(2, k) / 2;
                            for (byte i = 1; i < 4; i++)
                            {
                                urun.Sportip(i);
                                Console.WriteLine($"\n{urun.Sportipi} Ürün Çeşitleri: ");
                                for (byte j = 1; j < 5; j++)
                                {
                                    if (i == 1)
                                    {
                                        futbol.Uruntip(j);
                                        futbol.Fiyati(j);
                                        Console.WriteLine($"{futbol.Uruntipi} {futbol.Fiyat * coef} TL");
                                    }
                                    else if (i == 2)
                                    {
                                        basketbol.Uruntip(j);
                                        basketbol.Fiyati(j);
                                        Console.WriteLine($"{basketbol.Uruntipi} {basketbol.Fiyat * coef} TL");
                                    }
                                    else
                                    {
                                        tenis.Uruntip(j);
                                        tenis.Fiyati(j);
                                        Console.WriteLine($"{tenis.Uruntipi} {tenis.Fiyat * coef} TL");
                                    }
                                }
                            }
                            Console.WriteLine();
                        }
                       
                    }
                    else if (answer == 2)
                    {
                        toplam = 0;
                        Console.WriteLine("\nSepetinizdeki Ürünler:");
                        foreach (var item in sepet)
                        {
                            Console.Write($"{item.Adet} adet ");
                            Console.Write("\n" + item.Sportipi + " ");
                            Console.Write(item.Uruntipi + " ");
                            Console.WriteLine(item.Seviyesi);
                            Console.WriteLine(item.Fiyat * item.Adet + " TL");
                            toplam += item.Adet*item.KdvliFiyat();
                        }
                        Console.WriteLine($"\nToplam Fiyat KDV dahil {toplam} TL'dir.");
                        Console.ReadLine();
                        
                    }
                    else if (answer == 3)
                    {
                        Console.WriteLine("\nBir kategori seçiniz.\n1)Futbol 2)Basketbol 3)Tenis");
                        byte answer2 = byte.Parse(Console.ReadLine());
                        urun.Sportip(answer2);
                        switch (answer2)
                        {
                            case 1:
                                futbol.Tip(answer2);
                                byte answer3 = byte.Parse(Console.ReadLine());
                                futbol.Uruntip(answer3);
                                urun.Uruntipi = futbol.Uruntipi;
                                futbol.Fiyati(answer3);
                                urun.Fiyat = futbol.Fiyat;
                                break;
                            case 2:
                                basketbol.Tip(answer2);
                                byte answer31 = byte.Parse(Console.ReadLine());
                                basketbol.Uruntip(answer31);
                                urun.Uruntipi = basketbol.Uruntipi;
                                basketbol.Fiyati(answer31);
                                urun.Fiyat = basketbol.Fiyat;
                                break;
                            case 3:
                                tenis.Tip(answer2);
                                byte answer32 = byte.Parse(Console.ReadLine());
                                tenis.Uruntip(answer32);
                                urun.Uruntipi = tenis.Uruntipi;
                                tenis.Fiyati(answer32);
                                urun.Fiyat = tenis.Fiyat;
                                break;
                            default:
                                Console.WriteLine("Maalesef stoklarımızda mevcut olmayan bir ürün tipi seçtiniz.");
                                break;
                        }
                        Console.WriteLine("\nÜrünün seviyesini seçiniz: 1)Başlangıç Seviyesi 2)Orta 3)İleri Seviye");
                        byte answer4 = byte.Parse(Console.ReadLine());
                        urun.Seviye(answer4);
                        Console.Write("\nAdet Sayısı: ");
                        int adet = int.Parse(Console.ReadLine());
                        Array.Resize(ref sepet, sepet.Length + 1);
                        sepet[a] = new Sepet(urun.Sportipi, urun.Uruntipi, urun.Seviyesi, urun.Fiyat, adet);
                        
                        
                        
                        Console.WriteLine($"{adet} adet {urun.Sportipi} {urun.Uruntipi} {urun.Seviyesi} ({urun.Fiyat} TL)*{adet} sepetinize eklendi.");
                        //Başına new Sepet eklemezsek dizideki tüm elemanları sepete eklenen en son eleman şeklinde tutuyor neden ???
                        //İlk önce (1) ürün fiyatlarını listeleyince, bu aşamada hata veriyor, nedenini henüz çözemedim ?
                        Console.WriteLine();
                        a++;
                    }
                   
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
        }
    }
    public abstract class SporUrunleri
    {
        public string Sportipi { get; set; }

        public string Uruntipi { get; set; }

        public string Seviyesi { get; set; }
        public int Adet { get; set; }

        public double Fiyat { get; set; }

        public abstract double KdvliFiyat();
        public abstract void Tip(byte answer2);
        public abstract void Seviye(byte answer4);
    }
    public class Sepet : SporUrunleri
    {
        public Sepet()
        {

        }
        public Sepet(string sportipi,string uruntipi,string seviyesi,double fiyat,int adet)
        {
            Sportipi = sportipi;
            Uruntipi = uruntipi;
            Seviyesi = seviyesi;
            Fiyat = fiyat;
            Adet = adet;
        }
        public virtual void Uruntip(byte answer3)
        {
        }
        public string Uruntipi1 = "Forması";

        public string Uruntipi2 = "Ayakkabısı";

        public string Uruntipi3 = "Topu";

        public string Uruntipi4;

        const double kdvorani = 1.18;
        public override double KdvliFiyat()
        {
            return Fiyat*kdvorani;
        }
        public override void Tip(byte answer2)
        {
            if (answer2 == 1)
            {
                Console.WriteLine("\nBir ürün seçiniz: 1)Forma 2)Ayakkabı 3)Top 4)Hakem Düdüğü");
            }
            else if (answer2 == 2)
            {
                Console.WriteLine("\nBir ürün seçiniz: 1)Forma 2)Ayakkabı 3)Top 4)Pota Filesi");
            }
            else if (answer2 == 3)
            {
                Console.WriteLine("\nBir ürün seçiniz: 1)Forma 2)Ayakkabı 3)Top 4)Tenis Raketi");
            }
            else
            {
                Console.Write("\nHatalı bir işlem yaptınız");
            }
        }
        public void Sportip(byte answer2)
        {
            if (answer2 == 1)
            {
                Sportipi = "Futbol";
            }
            else if (answer2 == 2)
            {
                Sportipi = "Basketbol";
            }
            else if (answer2 == 3)
            {
                Sportipi = "Tenis";
            }
            else
            {
                Sportipi = "Hata!";
            }
        }
        public override void Seviye(byte answer4)
        {
            if (answer4 == 1)
            {
                Seviyesi = "Başlangıç Seviyesi";
            }
            else if (answer4 == 2)
            {
                Seviyesi = "Orta Seviye";
                Fiyat = Fiyat * 2;
            }
            else if (answer4 == 3)
            {
                Seviyesi = "İleri Seviye";
                Fiyat = Fiyat * 4;
            }
            else
            {
                Console.Write("\nHatalı bir işlem yaptınız");
            }
        }
    }
    public class Futbol:Sepet
    {
        public override void Uruntip(byte answer3)
        {
            switch (answer3)
            {
                case 1:
                    Uruntipi = Uruntipi1;
                    break;
                case 2:
                    Uruntipi = Uruntipi2;
                    break;
                case 3:
                    Uruntipi = Uruntipi3;
                    break;
                case 4:
                    Uruntipi = "Hakem Düdüğü";
                    break;
                default:
                    Console.WriteLine("HaTALI bir seçim!");
                    break;
            }
        }
        public void Fiyati(byte answer3)
        {
            switch (answer3)
            {
                case 1:
                    Fiyat = 300;
                    break;
                case 2:
                    Fiyat = 500;
                    break;
                case 3:
                    Fiyat = 200;
                    break;
                case 4:
                    Fiyat = 150;
                    break;
                default:
                    Console.WriteLine("HaTALI bir seçim!");
                    break;
            }
        }
        const double kdvorani = 1.18;
            public override double KdvliFiyat()
            {
                return Fiyat*kdvorani;
            }
        }
    public class Basketbol : Sepet
    {
        const double kdvorani = 1.18;
        public override double KdvliFiyat()
        {
            return Fiyat * kdvorani;
        }
        public override void Uruntip(byte answer3)
        {
            switch (answer3)
            {
                case 1:
                    Uruntipi = Uruntipi1;
                    break;
                case 2:
                    Uruntipi = Uruntipi2;
                    break;
                case 3:
                    Uruntipi = Uruntipi3;
                    break;
                case 4:
                    Uruntipi = "Pota Filesi";
                    break;
                default:
                    Console.WriteLine("HaTALI bir seçim!");
                    break;
            }
        }
        public void Fiyati(byte answer3)
        {
            switch (answer3)
            {
                case 1:
                    Fiyat = 250;
                    break;
                case 2:
                    Fiyat = 400;
                    break;
                case 3:
                    Fiyat = 275;
                    break;
                case 4:
                    Fiyat = 450;
                    break;
                default:
                    break;
            }
        }
    }
    public class Tenis : Sepet
    {
        const double kdvorani = 1.18;
        public override double KdvliFiyat()
        {
            return Fiyat * kdvorani;
        }
        public override void Uruntip(byte answer3)
        {
            switch (answer3)
            {
                case 1:
                    Uruntipi = Uruntipi1;
                    break;
                case 2:
                    Uruntipi = Uruntipi2;
                    break;
                case 3:
                    Uruntipi = Uruntipi3;
                    break;
                case 4:
                    Uruntipi = "Raketi";
                    break;
                default:
                    Console.WriteLine("HaTALI bir seçim!");
                    break;
            }
        }
        public void Fiyati(byte answer3)
        {
            switch (answer3)
            {
                case 1:
                    Fiyat = 250;
                    break;
                case 2:
                    Fiyat = 600;
                    break;
                case 3:
                    Fiyat = 50;
                    break;
                case 4:
                    Fiyat = 470;
                    break;
                default:
                    Console.WriteLine("HaTALI bir seçim!");
                    break;
            }
        }
    }
}
