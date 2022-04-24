using _101Bootcamp15ASearchUsingEF.Models;
using System;
using System.Linq;

namespace _101Bootcamp15ASearchUsingEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NORTHWNDContext())
            {

                //var std = new Student()
                //{
                //    Name = "Bill"
                //};

                //context.Students.Add(std);
                //context.SaveChanges();


                var custs = context.Customers.Select(row => row).ToList();

                foreach (var item in custs)
                {
                    Console.WriteLine("Contact Name: {0}", item.ContactName);
                }
             
            }


        }
    }
}
