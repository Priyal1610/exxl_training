using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10

{
    class User
    {
        public int Id;
        public string Name;
        public string city;
        public string dateOfBirth;
    }

    class Employee
    {
        public string name;
        public string gender;
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            //here is sample LINQ demo
            //var words = new string[] { "flower", "elephant", "sugar", "tree", "waffer" };

            /*//what is var : var is a keyword in C# that automatically determines the data type
            //of object. using var u don't have to specify datatype of object explicitly
            //u can use var for ALLLLLLL objects

            //Here is a LINQ syntax
            //from <Variable> in <collection> select <variable>

            var result = from element in words select element;

            //let us print all the elements using foreach loop

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/


            //Filtering
            /*var result = from element in words where element.Contains("a") select element;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            /*var result = words.Where(element => element.Contains("a"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            /*Console.WriteLine(words.ElementAt(1));
            Console.WriteLine(words.First());
            Console.WriteLine(words.Last());

            Console.WriteLine(words.First(element => element.Length == 5));
            Console.WriteLine(words.Last(element => element.Length == 5));*/

            //prepend or append
            /*int[] luckynumbers = { 47, 91, 88 };

            //prepend to add value at the beginnning of array
            var result1 = luckynumbers.Prepend(60);

            //append to add the value at the end
            var result2 = result1.Append(33);

            //.join() converts array to string
            Console.WriteLine(string.Join("-", result2));*/

            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            var result = numbers.Select(x => x * x);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }*/

            // wt pound to kg
            /*int[] wt = { 228, 190, 120, 150, 160, 165 };

            var result = wt.Select(x => x * 0.454);

            foreach( var i in result)
            {
                Console.WriteLine(i);
            }*/

            //increment
            /*int[] salary = { 34000, 24000, 31000, 28000, 29000, 33000 };

            var result = salary.Select(x => x * 0.03 + x);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }*/


            /*User[] users = { new User {Id= 1, Name="John", city="London", dateOfBirth="2001-05-21"},
                new User {Id= 2, Name="Windy", city="singapore", dateOfBirth="2002-06-23"},
                new User {Id= 3, Name="Barbara", city="hongkong", dateOfBirth="2003-08-07"},
                new User {Id= 4, Name="nick", city="hongkong", dateOfBirth="2001-04-09"},
                new User {Id= 5, Name="paul", city="singapore", dateOfBirth="2004-02-23"},
                new User {Id= 6, Name="andika", city="singapore", dateOfBirth="2001-05-23"},
                new User {Id= 7, Name="herman", city="London", dateOfBirth="2001-07-21"},
                new User {Id= 8, Name="sadiq", city="London", dateOfBirth="2004-03-23"},
                new User {Id= 9, Name="casseylyn", city="singapore", dateOfBirth="2004-05-21"},
                new User {Id= 10, Name="mick", city="hongkong", dateOfBirth="2008-05-21"}
            };

            var result = from usr in users where usr.city == "hongkong" select usr;
            foreach(var usr in result)
            {
                Console.WriteLine(usr.Name+" "+usr.city);
            }*/

            /*String wish = "One #Day I'll make Onions #Cry";

            //objective : to extract hashtag
            String[] words = wish.Split(' ');

            var result = words.Where(w => w.StartsWith("#"));

            foreach(var word in result)
            {
                Console.WriteLine(word);
            }*/

            /*var numbers = new List<int> { 6, 2, -3, 4, -5, 9, 7, 8};
            int length = numbers.Count();
            Console.WriteLine($"total elements {length}");

            //Count even numbers
            int length2 = numbers.Count(e => e%2 == 0);
            Console.WriteLine($"even numbers are {length2}");

            //find sum
            int total = numbers.Sum();
            Console.WriteLine($"total sum is {total}");

            //find sum of even numbers
            int evenSum = numbers.Sum(e => e%2 ==0 ? e : 0);
            Console.WriteLine($"Sum of even numbers is {evenSum}");

            //find average
            double mean = numbers.Average();
            Console.WriteLine($"Average is {mean}");

            //min
            Console.WriteLine($"Minimum value is {numbers.Min()}");

            //max
            Console.WriteLine($"Maximum value is {numbers.Max()}");

            //sorting
            var result = from num in numbers orderby num ascending select num;
            foreach (int num in result) Console.WriteLine(num + " ");*/

            /* Employee[] employees = { new Employee{ name = "windy", gender = "female"},
                 new Employee{ name = "james", gender = "male"},
                 new Employee{ name = "casseylyn", gender = "female"},
                 new Employee{ name = "armanta", gender = "female"},
                 new Employee{ name = "jonSeto", gender = "male"}
             };

             var empGroups = from emp in employees group emp by emp.gender;
             foreach(var grp  in empGroups)
             {
                 Console.WriteLine("Group ->"+grp.Key); 
                 foreach(var e in grp)
                 {
                     Console.WriteLine(e.name + " " + e.gender);
                 }
                 Console.WriteLine("====================");
             }*/

            string[] lines = File.ReadAllLines("d:\\youtube.csv");
           /* foreach (string line in lines)
            {
                Console.WriteLine(line);
            }*/
            //find count of total records of data
            int length = lines.Count()-1;
            Console.WriteLine($"count is {length}");

            //how many unique channels are present in data
            var result = lines.Distinct();
            /*foreach (var i in result)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
