using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Cname="Kamera",Description="Kamera Ürünleri"},
                new Category(){Cname="Telefon",Description="Telefon Ürünleri"},
                new Category(){Cname="Bilgisayar",Description="Bilgisayar Ürünleri"}

            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var ürünler = new List<Product>()
            {
                new Product(){Pname="Canon",Description="Kamera Ürünleri",Price=2500,Stock=30,IsHome=true,IsApproaved=true,IsFeatured=false,CaTegoryId=1,Image="1.jpg"},
                new Product(){Pname="Apple",Description="Telefon Ürünleri",Price=1500,Stock=30,IsHome=true,IsApproaved=true,IsFeatured=false,CaTegoryId=2,Image="2.jpg"},
                new Product(){Pname="Samsung",Description="Telefon Ürünleri",Price=500,Stock=30,IsHome=true,IsApproaved=true,IsFeatured=false,CaTegoryId=2,Image="3.jpg"},
                new Product(){Pname="Lenova",Description="Bilgisayar Ürünleri",Price=3500,Stock=30,IsHome=true,IsApproaved=true,IsFeatured=false,CaTegoryId=3,Image="4.jpg"}
            };
            foreach (var ürün in ürünler)
            {
                context.Products.Add(ürün);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}