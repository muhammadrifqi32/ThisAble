using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ThisAble.Models;

namespace ThisAble.MyContext
{
    public class myContext : DbContext
    {
        public myContext() : base("ThisAble") { }

        public DbSet<Department> Departments { get; set; }
    }
}