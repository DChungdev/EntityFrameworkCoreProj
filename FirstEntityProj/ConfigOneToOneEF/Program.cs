﻿using System.Diagnostics.Metrics;
using System.Net;

namespace ConfigOneToOneEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //creates db if not exists 
                context.Database.EnsureCreated();

                ////create entity objects
                var grd1 = new StudentAddress() { Address = "PL", City = "Hanam", State = "Vietnamese", Country = "VN"};
                var std1 = new Student() { Name = "Chung", Address = grd1 };

                //add entitiy to the context
                context.Students.Add(std1);

                //save data to the database tables
                context.SaveChanges();
                //var vd1 = context.Grades.Where(p => p.GradeName == "1st Grade");
                //context.Grades.RemoveRange(vd1);
                //context.SaveChanges();
                //retrieve all the students from the database
                foreach (var s in context.Students)
                {
                    Console.WriteLine($"First Name: {s.Name}");
                }
            }
        }
    }
}