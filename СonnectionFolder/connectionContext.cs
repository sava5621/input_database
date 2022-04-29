using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_database.СonnectionFolder
{
    class connectionContext : DbContext
    {
        public connectionContext()
          : base("DbConnection")
        { }
        public DbSet<Connection> conn { get; set; }
    }
}
