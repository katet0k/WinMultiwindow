using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMultiwindow.Core
{
    public class GoodCollection
    {
        public List<Good> Goods { get; set; }

        public GoodCollection()
        {
            Goods = new List<Good>();
        }

        public void Add(Good good)
        {
            Goods.Add(good);
        }

        public void Remove(Good good)
        {
            Goods.Remove(good);
        }

        public void RemoveAt(int index)
        {
            Goods.RemoveAt(index);
        }

        public Good Get(int index)
        {
            return Goods[index];
        }
        public void Edit(int index, Good newGood)
        {
            Goods[index] = newGood;
        }

        public int Count()
        {
            return Goods.Count;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Good good in Goods)
            {
                result += good.ToString() + "\n";
            }
            return result;
        }   
    }
}
