using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication1.Models;

namespace ConsoleApplication1.Context
{
    class ConsoleApplicationContext:DbContext
    {
        //This will create the POST table for our database.
        public DbSet<Post> Posts { get; set; }
        
    }
}
