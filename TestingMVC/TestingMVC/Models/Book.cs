using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
    }
}