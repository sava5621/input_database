using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_database.YearFolder
{
        class dataContext : DbContext
    {
            public dataContext()
                : base("DbConnection")
            { }
            public DbSet<data> main_data_year { get; set; }
        }
}
