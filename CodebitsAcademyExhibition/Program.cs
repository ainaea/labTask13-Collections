using System;
using System.Collections.Generic;

namespace CodebitsAcademyExhibition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<List<string>> allList = new List<List<string>>(){
                new List<string>(){"C# turbine", "James Smith", "C#", "Second floor", "Primary"},
                new List<string>(){"JavaScript turbine", "Mike Fowler", "JavaScript", "Fourth floor", "Higher"},
                new List<string>(){"Python turbine", "Janet Smith", "Python", "Ground floor", "Labs"},

                new List<string>(){"C# flow control", "Williams Carpenter", "C#", " floor", "Primary"},
                new List<string>(){"JavaScript flow control", "Carpenter Armstrong", "JavaScript", "Third floor", "Higher"},
                new List<string>(){"Python flow control", "Jordan Jaden", "Python", "Second floor", "Labs"},

                new List<string>(){"C# price modulator", "David Akintola", "C#", "Second floor", "Primary"},
                new List<string>(){"JavaScript price modulator", "Ahmadu Bello", "JavaScript", "Fourth floor", "Higher"},
                new List<string>(){"Python price modulator", "JOhn Cena", "Python", "Ground floor", "Labs"},

                new List<string>(){"C# flow control", "Michael Scofield", "C#", "Ground floor", "Primary"},
                new List<string>(){"JavaScript flow control", "Taraji Henson", "JavaScript", " floor", "Higher"},
                new List<string>(){"Python flow control", "Mike Adenuga", "Python", "Third floor", "Labs"},


                new List<string>(){"C# Stock Predictor", "Angelina Jolie", "C#", "Fifth", "Primary"},
                new List<string>(){"JavaScript Stock Predictor", "Denzel Washington", "JavaScript", "Fourth floor", "Higher"},
                new List<string>(){"Python Stock Predictor", "Shola Areogun", "Python", "Last floor", "Labs"}            
            };

            foreach (var item in allList)
            {
                Console.WriteLine($"{item[0]}\t{item[1]}\t{item[2]}\t{item[3]}\t{item[4]}");
            }

            allList.RemoveAt(8);
            Console.WriteLine("\nAfter removing element of index 8\n");


            foreach (var item in allList)
            {
                Console.WriteLine($"{item[0]}\t{item[1]}\t{item[2]}\t{item[3]}\t{item[4]}");
            }

            
            //b
            var daniel = new List<string>(){"Ifechukwu Daniel", "93% (2021)", "JavaScript"};

            HashSet<List<string>> students = new HashSet<List<string>>(){
                new List<string>(){"Adams Abraham", "89% (2020)", "C#"},
                new List<string>(){"Adazor Happiness", "85% (2020)", "JavaScript"},
                new List<string>(){"Usman Danjuma", "91% (2020)", "HTML/CSS"},
                new List<string>(){"Oladipo Sheriff", "87% (2021)", "C#"},
                daniel,
                new List<string>(){"AbdulKareem AbdulRaheem", "82% (2021)", "HTML/CSS"}            

            };

            foreach (var student in students)
            {
                Console.WriteLine($"{student[0]}\t{student[1]}\t{student[2]}");                
            }

            if (students.Contains(daniel))
            {
                Console.WriteLine($"\n{daniel[0]} is an Alumnus who has been a admitted into one of the top colleges in the state");
            }

        }
    }
}
