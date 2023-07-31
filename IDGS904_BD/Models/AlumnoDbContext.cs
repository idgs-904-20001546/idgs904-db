using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IDGS904_BD.Models
{
    public class AlumnoDbContext : DbContext
    {
        private static string connection = "defaultConnection";

        public AlumnoDbContext():base(connection)
        {

        }

        public DbSet<Alumno> Alumno { get; set; }
    }
}