using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Products(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
