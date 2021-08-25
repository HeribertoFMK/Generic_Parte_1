using System;
using System.Collections.Generic;


namespace Curso_generics
{
    class Program
    {
        static void Main(string[] args)
        {

            // HashSet<int> a = new HashSet<int>() { 4, 6, 7, 9, 3 };
            // HashSet<int> b = new HashSet<int>() { 15, 87, 95, 103 };

            // HashSet<int> resultado = new HashSet<int>(a);
            // resultado.UnionWith(b);
            // PrintColletion(resultado);

            // SortedSet<int> c = new SortedSet<int>() { 4, 6, 7, 9, 3 };
            // HashSet<int> d = new HashSet<int>() { 15, 87, 95, 103 };

            // HashSet<int> resultado2 = new HashSet<int>(c);
            // resultado2.UnionWith(d);
            // PrintColletion(resultado2);






            // HashSet<string> g = new HashSet<string>();
            // g.Add("Ricardo");
            // g.Add("jose");
            // g.Add("marcos");
            // g.Add("marcelo");

            // System.Console.WriteLine(g.Contains("marcelo"));

            // foreach (string n in g)
            // {
            //     System.Console.WriteLine(n);
            // }

            // PrintService printservice = new PrintService();
            // System.Console.WriteLine("How many Values?");
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 0; i < n; i++)
            // {
            //     int x = int.Parse(Console.ReadLine());
            //     printservice.AddValue(x);

            // }

            // printservice.Print();
            // System.Console.WriteLine("Firt : " + printservice.Firt);

            PrintService<int> printservice = new PrintService<int>();
            System.Console.WriteLine("How many Values?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printservice.AddValue(x);

            }

            printservice.Print();
            System.Console.WriteLine("Firt : " + printservice.Firt());





        }

        // static void PrintColletion<T>(IEnumerable<T> colletion)
        // {

        //     foreach (T obj in colletion)
        //     {

        //         System.Console.Write(obj + " ");
        //         System.Console.WriteLine();
        //     }
        // }
    }
}
