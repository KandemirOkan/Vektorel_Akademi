using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample_Library;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products("Canon Fotoğraf Makinesi", 1500M, 3);
            products.ProductFinalPrice();
            int a = 23;
            decimal maas = 19000;
            string isim = "Okan";
            Console.WriteLine("23'ün karesi = {0}",a.Karesi());
            Console.WriteLine("Net Maaş = {0}",maas.NetMaas());
            Console.WriteLine(products.ProductName.Name());
            isim.WChardizisi();
            Console.ReadLine();

        }
    }
    public static class Extension
    {
        public static void ProductFinalPrice(this Products products)
        {
            Console.WriteLine(products.IncludeTax());
        }
        public static int Karesi(this int a)
        {
            return a * a;
        }
        public static decimal NetMaas(this decimal brutmaas)
        {
            return brutmaas * 0.67M;
        }
        public static string Name(this string name)
        {
            return name.ToUpper();
        }
        public static string WChardizisi(this string chars)
        {
            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }
            return null;
        }
    }
}
