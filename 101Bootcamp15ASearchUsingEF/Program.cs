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
                

                // TODO : search for customer and employee table from NORTHWIND

                var custs = context.Customers.Select(row => row).ToList();

                Console.WriteLine("-------------------- CUSTOMERS -----------------------");
                foreach (var item in custs)
                {
                    Console.WriteLine("Contact Name: {0}", item.ContactName);
                }

                var employees = context.Employees.Select(row => row).ToList();



             
            }


        }
    }
}
