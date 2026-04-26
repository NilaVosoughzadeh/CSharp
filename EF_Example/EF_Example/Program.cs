using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            EF_DBEntities db=new EF_DBEntities();
            
            
            //insert
            //Person p1=new Person()
            //{
            //    Name = "Reza",
            //    Family = "Rezaei",
            //    Age = 57
            //};
            //db.People.Add(p1);


            Person res = db.People.SingleOrDefault(p => p.PersonID == 4);
            if (res != null)
            {
                res.Age = 55;
            }

            db.People.Remove(res);

            db.SaveChanges();

            var list = db.People.OrderByDescending(p=>p.Age).ToList();
            //var list = db.People.Where(p => p.Age > 30).ToList();
            foreach (Person person in list)
            {
                Console.WriteLine($"ID : {person.PersonID} Name : {person.Name} Family : {person.Family} Age : {person.Age}");
            }

            Console.ReadKey();
        }
    }
}
