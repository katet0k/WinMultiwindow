using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMultiwindow.Core
{
    public class Good
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public Good() { }

        public Good(string name, string description, string price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} : {Description}\t\t| {Price}$";
        }

    }
}
