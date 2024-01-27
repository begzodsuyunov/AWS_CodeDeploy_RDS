using _00010358.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00010358.DBContext
{
    public class DatabaseContext : DbContext
    {
        //Context object is responsible for saving and querying data

        //configuration of object which will be injected CRUD dependency
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        //collection of books
        public DbSet<Student> Student { get; set; }

    }
}
