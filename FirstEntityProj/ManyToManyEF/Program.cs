using Microsoft.EntityFrameworkCore;

namespace ManyToManyEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //creates db if not exists 
                context.Database.EnsureCreated();
                var studentCourses = from sc in context.StudentCourses
                                     join s in context.Students on sc.StudentId equals s.StudentId
                                     join c in context.Courses on sc.CourseId equals c.CourseId
                                     select new
                                     {
                                         StudentName = s.Name,
                                         CourseName = c.CourseName
                                     };
                foreach (var item in studentCourses)
                {
                    Console.WriteLine("Student name: {0} ; Course name: {1}", item.StudentName, item.CourseName);
                }               
            }
        }
    }
}