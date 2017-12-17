using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Product
    {
        public int Id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public bool AttFanValue { get; set; }
        public int AttFanType { get; set; }
        public string AttFanName { get; set; }
        public string RatingName { get; set; }
        public string RatingType { get; set; }
        public float RatingValue { get; set; }
    }
}
