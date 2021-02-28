using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}