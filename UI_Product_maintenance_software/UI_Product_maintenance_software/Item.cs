using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Product_maintenance_software
{
    public class Item
    {
        public Item()
        {
            // this is something 
            Id = new Random().Next(1, 10000);
        }
       public int Id { get; set; }
       public string Name { get; set; }
       public string Price { get; set; }
       public string Available { get; set; }
    }
}
