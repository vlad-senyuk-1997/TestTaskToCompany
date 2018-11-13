using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Mode { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}