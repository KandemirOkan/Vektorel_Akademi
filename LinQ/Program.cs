using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>
        {
            new Products{ProductID=1,ProductName="Telefon",ProductBrand="Samsung",UnitinStock=10,UnitPrice=5000,ReservationState=true},
            new Products{ProductID=2,ProductName="Bilgisayar",ProductBrand="Acer",UnitinStock=5,UnitPrice=10000,ReservationState=true},
            new Products{ProductID=3,ProductName="Tablet",ProductBrand="Apple",UnitinStock=0,UnitPrice=15000,ReservationState=false},
            new Products{ProductID=4,ProductName="Televizyon",ProductBrand="Vestel",UnitinStock=20,UnitPrice=7000,ReservationState=true},
            new Products{ProductID=5,ProductName="Buzdolabı",ProductBrand="Bosch",UnitinStock=2,UnitPrice=5000,ReservationState=false},
            new Products{ProductID=6,ProductName="Fırın",ProductBrand="Siemens",UnitinStock=13,UnitPrice=6000,ReservationState=true},
            new Products{ProductID=7,ProductName="Printer",ProductBrand="Hp-Jet",UnitinStock=7,UnitPrice=5000,ReservationState=true},
        };
            Console.WriteLine("--------------Select-------------");
            var p = products.Select(x=>x.ProductName).ToList();
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------Where-------------");
            
            var p1 = products.Where(x=>x.UnitPrice<10000&&x.ReservationState==true).ToList();
            foreach (var item in p1)
            {
                Console.WriteLine("Ürün Adı= {0}\tFiyatı={1}",item.ProductName,item.UnitPrice);
            }
            Console.WriteLine("--------------SelectMany-------------");
            var p2 = products.SelectMany(y => y.ProductName).ToList();
            foreach (var item in p2)
            {
                Console.Write(item);
            }
            Console.WriteLine("--------------Thenby-------------");
            var p3 = products.OrderBy(x => x.UnitPrice).ThenBy(x=>x.ProductName).ToList();
            foreach (var item in p3)
            {
                Console.WriteLine("Product Id = {0}\tP.Name={1}",item.UnitPrice,item.ProductName);
            }
            Console.WriteLine("--------------Aggregate-------------");
            var p4 = products.Sum(x => x.UnitinStock);
            Console.WriteLine("Stoktaki toplam ürün sayısı = {0}", p4);
            var p5 = products.Where(x=>x.ReservationState==true).Count();
            var p6 = products.Where(x => x.ReservationState == true);
            Console.WriteLine("Rezerve edilebilir durumdaki ürün çeşitlerinin toplamı = {0}\nBu Ürünler:", p5);
            foreach (var item in p6)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.ReadLine();
        }
        
    }
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitinStock { get; set; }

        public bool ReservationState { get; set; }
    }
}
