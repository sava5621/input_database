using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_database.InsecticidesFolder
{
    class InsecticidesContext : DbContext
    {
        public InsecticidesContext()
            : base("DbConnection")
        { }
        public DbSet<Insecticides> insec { get; set; }
    }
}
