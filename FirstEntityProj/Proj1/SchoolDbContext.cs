using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    public class SchoolDbContext : DbContext
    {
        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-AFRCPMNE\\SQLEXPRESS;Initial Catalog=SchoolDb;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
