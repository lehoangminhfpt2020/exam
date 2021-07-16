using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web;
using System.Data.Entity;
using okem.Models;

namespace okem.Datacontent
{
    public class Datacontext : DbContext
    {
        public Datacontext() : base("okem")
        {

        }

        public DbSet<Examok> exams { get; set; }
    }
}