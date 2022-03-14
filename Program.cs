using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz ilosc przedmiotow" + Environment.NewLine);
            int n = int.Parse(Console.ReadLine()); //konwertuje w int
            Console.WriteLine("Wpisz liczbe do losowania" + Environment.NewLine);
            int seed = int.Parse(Console.ReadLine());

            Items problem = new Items(n, seed); //stworz przedmioty

            Console.WriteLine("Wpisz wielkość plecaka" + Environment.NewLine);
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(problem.ToString());

            string str = problem.solution(capacity);
            Console.WriteLine("Pojemnosc = " + capacity);
            Console.WriteLine("Waga przedmiotow = " + problem.itemWeight);
            Console.WriteLine("Wartość przedmiotow = " + problem.itemValue);
            Console.WriteLine("Przedmioty: " + str);


        }
    }
}