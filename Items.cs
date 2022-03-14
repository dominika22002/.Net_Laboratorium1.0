using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1._0
{
    public class Items
    {
        public List<Item> items;
        public int itemValue;
        public int itemWeight;

        public Items(int n, int seed)
        {
            itemValue = 0;
            itemWeight = 0;
            items = new List<Item>();
            Random r = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                Item a = new Item(i, r);
                items.Add(a);
            }
        }

        public override string ToString()
        {
            string str = "dla " + items.Count.ToString() + " przedmiotow \n";
            for (int i = 0; i < items.Count; i++)
            {
                str += items[i].name.ToString() + "\t" + items[i].value.ToString() + "\t" + items[i].weight.ToString() + "\t" + items[i].ratio.ToString("n2") + "\n";
            }
            return str;
        }

        public string solution(int capacity)
        {
            items.Sort((u1, u2) => u1.ratio.CompareTo(u2.ratio));
            items.Reverse();
            string str = "";

            for (int i = 0; i < items.Count; i++)
            {
                if (itemWeight + items[i].weight < capacity)
                {
                    itemWeight += items[i].weight;
                    itemValue += items[i].value;
                    str += items[i].name.ToString() + " ";
                }
            }
            // Console.WriteLine(str);
            return str;
        }
    }
}