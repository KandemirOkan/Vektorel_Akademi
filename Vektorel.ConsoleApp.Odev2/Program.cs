using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Okan Kandemir - Ödev 2
            #region 1) Canlı İddia Sitesi Üyelik Sayfası
            //try
            //{
            //Console.WriteLine("18 yaşından büyük müsünüz? ");
            //string answer = Console.ReadLine();
            //if (answer.ToLower() == "hayır")
            //{
            //    Console.WriteLine("Maalesef siteye giriş yetkiniz yoktur.");
            //    Console.ReadLine();
            //}
            //else if (answer.ToLower() == "evet")
            //{
            //    Console.WriteLine("Ad-Soyad: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Yaşınız: ");
            //    byte age = byte.Parse(Console.ReadLine());
            //        if (age<18)
            //        {
            //            Console.WriteLine("Yakalandınız! 18 yaşından küçükler yasal olarak iddia oynayamazlar.");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //    Console.WriteLine("Tuttuğunuz takım? ");
            //    string team = Console.ReadLine();
            //    Console.WriteLine($"Üye kaydınınız tamamlanmıştır.\nÜyelik bilgileri:\n{name}\nYaş: {age}\nFavori Takımı: {team}");
            //    Console.ReadLine();
            //        }
            //    }
            //else
            //{
            //    Console.WriteLine("Yanlış bir işlem yaptınız. ");
            //    Console.ReadLine();
            //}
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Lütfen yaşınızı 0-255 arası bir değer giriniz.");
            //    Console.ReadLine();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Bir format hatası yaptınız.");
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmeyen bir hata oluştu.");
            //    Console.ReadLine();
            //} 
            #endregion
            #region 2) Hesap Makinesi
            //try
            //{
            //Console.WriteLine("Hesap Makinesi\nYapmak İstediğiniz İşlemi Giriniz: 1)Toplama 2)Çıkarma 3)Çarpma 4)Bölme");
            //byte operation = byte.Parse(Console.ReadLine());
            //if (operation==1||operation==2||operation==3||operation==4)
            //{
            //Console.WriteLine("Birinci sayıyı Giriniz: ");
            //float answer1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı Giriniz: ");
            //float answer2 = float.Parse(Console.ReadLine());
            //switch (operation)
            //{
            //    case 1:
            //        Console.WriteLine($"Toplama işleminin sonucu: {answer1 + answer2}");
            //        Console.ReadLine();
            //        break;
            //    case 2:
            //        if (answer1 > answer2)
            //        {
            //            Console.WriteLine($"Çıkarma işleminin sonucu: {answer1 - answer2}");
            //            Console.ReadLine();
            //        }
            //        else if (answer1 < answer2)
            //        {
            //            Console.WriteLine($"Çıkarma işleminin sonucu: {answer2 - answer1}");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayılar birbirine eşittir, dolayısıyla sonuç 0'dır");
            //            Console.ReadLine();
            //        }
            //        break;
            //    case 3:
            //        Console.WriteLine($"Çarpma işleminin sonucu: {answer1*answer2}");
            //        Console.ReadLine();
            //        break;
            //    case 4:
            //        Console.WriteLine($"Bölme işleminin sonucu: {answer1 / answer2}");
            //        Console.ReadLine();
            //        break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Programımız geliştirilme aşamasında. Maalesef; şimdilik 4 işlem dışında başka bir işlem yapamazsınız.");
            //    Console.ReadLine();
            //}

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Bir sayıyı 0'a bölemezsiniz.");
            //    Console.ReadLine();
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Uygun aralıkta bir sayı değeri giriniz.");
            //    Console.ReadLine();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format hatası, bir sayı girmelisiniz.");
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bir hata ile karşılaşıldı.");
            //    Console.ReadLine();
            //} 
            #endregion
            #region 3) Geometrik Şekil Hesaplama
            //try
            //{
            //    Console.WriteLine("Hesaplatmak istediğiniz geotmerik şekil hangisi ?\n1)Kare,2)Üçgen,3)Daire? ");
            //    byte geometry = byte.Parse(Console.ReadLine());
            //    if (geometry == 1 || geometry == 2 || geometry == 3)
            //    {
            //        Console.WriteLine("Hesaplanmasını istediğiniz özellik hangisi?\n1)Alan, 2)Çevresi? ");
            //        byte answer = byte.Parse(Console.ReadLine());
            //        if (answer==1||answer==2)
            //        {
            //        switch (geometry)
            //        {
            //            case 1:
            //                switch (answer)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Kenar boyunu Giriniz: ");
            //                        float a = float.Parse(Console.ReadLine());
            //                        Console.WriteLine($"Karenin alanı = {a * a}");
            //                        Console.ReadLine();
            //                        break;
            //                    case 2:
            //                        Console.WriteLine("Dik Kenar boyunu Giriniz: ");
            //                        float b = float.Parse(Console.ReadLine());
            //                        Console.WriteLine($"Karenin çevresi = {b * 4}");
            //                        Console.ReadLine();
            //                        break;
            //                    default:
            //                        Console.WriteLine("Hatalı bir giriş yaptınız. Sadece Alan yada Çevre hesaplayabilirsiniz.");
            //                        break;
            //                }
            //                break;
            //            case 2:
            //                switch (answer)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Üçgenin dik kenarlarından birini giriniz: ");
            //                        float c = float.Parse(Console.ReadLine());
            //                        Console.WriteLine("Üçgenin dik kenarlarından diğerini giriniz: ");
            //                        float d = float.Parse(Console.ReadLine());
            //                        Console.WriteLine($"Üçgenin alanı = {c * d / 2}");
            //                        Console.ReadLine();
            //                        break;
            //                    case 2:
            //                        Console.WriteLine("Üçgenin dik kenarlarından birini giriniz: ");
            //                        float e = float.Parse(Console.ReadLine());
            //                        Console.WriteLine("Üçgenin dik kenarlarından diğerini giriniz: ");
            //                        float f = float.Parse(Console.ReadLine());
            //                        Console.WriteLine($"Üçgenin çevresi = {e + f + Math.Sqrt(e * e + f * f)}");
            //                        Console.ReadLine();
            //                        break;
            //                    default:
            //                        Console.WriteLine("Hatalı bir giriş yaptınız. Sadece Alan yada Çevre hesaplayabilirsiniz.");
            //                        break;
            //                }
            //                break;
            //            case 3:
            //                switch (answer)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Dairenin yarıçapını giriniz: ");
            //                        double r = float.Parse(Console.ReadLine());
            //                        const double pi = 3.14;
            //                        Console.WriteLine($"Dairenin alanı = {pi * r * r}");
            //                        Console.ReadLine();
            //                        break;
            //                    case 2:
            //                        Console.WriteLine("Dairenin yarıçapını giriniz: ");
            //                        double r2 = float.Parse(Console.ReadLine());
            //                        const double pi2 = 3.14;
            //                        Console.WriteLine($"Dairenin çevresi = {pi2 * r2 * 2}");
            //                        Console.ReadLine();
            //                        break;
            //                    default:
            //                        Console.WriteLine("Hatalı bir giriş yaptınız. Sadece Alan yada Çevre                            hesaplayabilirsiniz.");
            //                        break;
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("Sadece Daire,Kare yada Diküçgen hesaplayabilirsiniz. ");
            //                Console.ReadLine();
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Alan yada Çevre hesaplamasından birini seçmelisiniz...");
            //            Console.ReadLine();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kare,Üçgen yada Daire seçmelisiniz...");
            //        Console.ReadLine();
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Uygun aralıkta bir sayı giriniz... ");
            //    Console.ReadLine();

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Hatalı format girişi yaptınız... ");
            //    Console.ReadLine();

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmedik bir hata oluştu.... ");
            //    Console.ReadLine();
            //} 
            #endregion
            #region 4) Market Uyguluması
            //Console.WriteLine("Almak istediğiniz ürünü giriniz.\nKıyma, Tavuk eti, Hamsi, Mezgit, Domates, Patates, Soğan, Süt, Mısır, Zeytinyağı");
            //try
            //{


            //    string product = Console.ReadLine();
            //    string product2 = product.ToLower();
            //    switch (product2)
            //    {
            //        case "kıyma":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount} kg Kıyma Toplam {amount * 140} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "tavuk eti":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount2 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount2} kg Tavuk eti Toplam {amount2 * 50} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "hamsi":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount3 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount3} kg Hamsi Toplam {amount3 * 25} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "mezgit":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount4 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount4} kg Mezgit Toplam {amount4 * 40} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "domates":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount5 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount5} kg Domates Toplam {amount5 * 10} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "patates":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount6 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount6} kg Patates Toplam {amount6 * 8} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "soğan":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount7 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount7} kg Soğan Toplam {amount7 * 14} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "süt":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (lt):");
            //            float amount8 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount8} lt Süt Toplam {amount8 * 140} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "mısır":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount9 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount9} kg Mısır Toplam {amount9 * 20} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        case "zeytinyağı":
            //            Console.WriteLine("Almak istediğiniz Miktarı Giriniz (kg):");
            //            float amount10 = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"{amount10} lt Zeytinyağı Toplam {amount10 * 50} TL Tutar.");
            //            Console.ReadLine();
            //            break;
            //        default:
            //            Console.WriteLine("Aradığınız ürün stoklarda bulunmamaktadır.");
            //            Console.ReadLine();
            //            break;
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format hatası oluştu.");
            //    Console.ReadLine();
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Girilen miktar stoklarda bulunmamakta.");
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Beklenmedik bir hata oluştu.");
            //    Console.ReadLine();
            //}
            #endregion
        }

}
}
