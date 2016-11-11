using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SchoolFun.Models;

namespace SchoolFun.DAL
{
    public class HardKnoxContext : DbContext
    {
        public HardKnoxContext(): base("HardKnoxContext")
        {
           
        }

        public DbSet<Student_Majors> Students_Majors { get; set; }
        public DbSet<Majors> Major { get; set; }

        public System.Data.Entity.DbSet<SchoolFun.Models.Student> Students { get; set; }

    }
}