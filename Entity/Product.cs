using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace E_Commerce_MVC.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Pname { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int  Stock { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsApproaved { get; set; }
        public int CaTegoryId { get; set; }
        public Category category { get; set; }


    }
}