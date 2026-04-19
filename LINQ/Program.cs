using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ = Language Integrated Query

            // Select * From Table as T
            // From T in Table Select T

            int[] numbers = { 5, 10, 15, 20 };

            int[] result1 = (from n in numbers select n).ToArray();
            //Lambda Extenssion
            var lambda1 = numbers.ToArray();

            int[] result2 = (from n in numbers
                             orderby n descending
                             select n).ToArray();
            var lambda2 = numbers.OrderByDescending(n => n).ToArray();

            int[] result3 = (from n in numbers
                             where n > 10 && n < 20
                             select n).ToArray();
            var lambda3 = numbers.Where(n => n > 30 && n > 80).OrderByDescending(n => n).ToArray();

            int result4 = (from n in numbers
                           where n == 5
                           select n).First();
            var lambda4 = numbers.First(n => n == 5);

            int result5 = (from n in numbers
                           where n == 5
                           select n).FirstOrDefault();
            var lambda5 = numbers.FirstOrDefault(n => n == 5);

            int result6 = (from n in numbers
                           where n > 10 && n < 20
                           select n).Single();
            var lambda6 = numbers.Single(n => n > 10 && n < 20);

            int result7 = (from n in numbers
                           where n == 5
                           select n).SingleOrDefault();
            var lambda7 = numbers.SingleOrDefault(n => n == 5);

            bool result8 = (from n in numbers
                            where n == 25
                            select n).Any();
            var lambda8 = numbers.Any(n => n == 25);

            int count = (from n in numbers
                         select n).Count();
            var lambda9 = numbers.Count();

            int max = (from n in numbers
                       select n).Max();
            var lambda10 = numbers.Max();

            int min = (from n in numbers
                       select n).Min();
            var lambda11 = numbers.Min();

            int sum = (from n in numbers
                       select n).Sum();
            var lambda12 = numbers.Sum();

            List<string> Names = new List<string>();
            Names.Add("Nila");
            Names.Add("Arash");
            Names.Add("Vania");
            Names.Add("Rosana");
            var res1 = (from n in Names
                        select n).ToList();
            var lam1 = Names.ToList();

            var res2 = (from n in Names
                        where n.ToLower().Contains("n")
                        select n).ToList();
            var lam2 = Names.Where(n => n.ToLower().Contains("n"));

            var res3 = (from n in Names
                        where n.ToLower().StartsWith("a")
                        select n).ToList();
            var lam3 = Names.Where(n => n.ToLower().StartsWith("a"));

            var res4 = (from n in Names
                        where n.ToLower().EndsWith("a")
                        select n).ToList();
            var lam4 = Names.Where(n => n.ToLower().EndsWith("a"));

            //LINQ
            List<Person> people = new List<Person>();
            Person p1 = new Person();
            p1.PersonId = 1;
            p1.Name = "Nila";
            p1.Family = "Vo";
            p1.Age = 20;
            people.Add(p1);

            Person p2 = new Person()
            {
                PersonId = 2,
                Name = "Arash",
                Family = "Vo",
                Age = 14
            };
            people.Add(p2);

            people.Add(new Person() { PersonId = 3, Name = "Ros", Family = "Na", Age = 12 });

            /*var resultQuery = people.ToList();
            var result = people.Where(p => p.Name.ToLower() == "Nila").ToList();
            var result = people.Where(p => p.Age > 10 || p.Age < 20).ToList();*/
            var resultQuery = people.OrderByDescending(p => p.Age);
            var resultQuery2 = people.Select(p => p.Name).ToList();
            var resultQuery3 = people.Select(p => new { p.Name, p.Age }).ToList();
            foreach (var p in resultQuery)
            {
                Console.WriteLine($"Id : {p.PersonId} Name : {p.Name} Family : {p.Family} Age : {p.Age}");
            }
            List<PersonCar> Cars = new List<PersonCar>();
            new PersonCar() { PersonID = 1, CarName = "Pride", CarModel = "1384" };
            new PersonCar() { PersonID = 3, CarName = "Peykan", CarModel = "1380" };
            var join = (from p in people
                        join c in Cars on p.PersonId equals c.PersonID
                        select new
                        {
                            p.PersonId,
                            p.Name,
                            p.Family,
                            p.Age,
                            c.CarName,
                            c.CarModel
                        });

            int[] numbersArray = { 1, 2, 6, 15, 15, 65 };
            var numRes = numbersArray.Distinct().ToArray();
            var numRes2 = numbersArray.OrderByDescending(n => n).Take(3).ToArray();
            var numRes3 = numbersArray.OrderByDescending(n => n).Skip(3).ToArray();
            Console.ReadKey();
        }
    }
}
