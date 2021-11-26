using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressTest.Models
{
    public class UserDetail
    {
        public string ImagePath { get; set; }
        public string Year { get; set; }
        public string Desctiption { get; set; }
        public double Record { get; set; }
        public double Average { get; set; }
        public double General { get; set; }
        public List<Product> Products { get; set; }

    }

    public class Product
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
