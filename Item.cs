using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1._0
{
    public class Item
    {
        public int name;
        public int value;
        public int weight;
        public float ratio;

        public Item(int n, Random r)
        {   
            name = n + 1;
            value = r.Next(1, 50);
            weight = r.Next(1, 50);

            ratio = (float)value / weight;

        }
    }
}