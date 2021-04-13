using System;
using System.Collections.Generic;

namespace JamesStuartMediaLImited
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            SortedList<string, string> all = new SortedList<string, string>(){};
            // SortedList

            all.Add("Tom Lee", "Training");
            all.Add("James Anderson", "HR");
            all.Add("Michael Chan", "Content Development");
            all.Add("Jackie Jackson", "Training");
            all.Add("Bruce Douglas", "Graphics");
            all.Add("Kim Date", "HR");
            all.Add("Joseph Matthews", "Content Development");
            all.Add("Rose Dorson", "Marketing");
            all.Add("Andrews Stephan", "Graphics");

            foreach (var item in all)
            {
                Console.WriteLine(item);
            }

            if (all.ContainsKey("Andrews Stephan"))
            {
                all.Remove("Andrews Stephan");
            }

            Console.WriteLine("\nAfter removing Andrews Stephan\n");

            foreach (var item in all)
            {
                Console.WriteLine(item);
            }


        }
    }
}
