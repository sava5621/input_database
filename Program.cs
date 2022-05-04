using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using input_database.InsecticidesFolder;
using input_database.YearFolder;
using input_database.СonnectionFolder;
using Microsoft.Office.Interop.Excel;
namespace input_database
{
    class Program
    {
        public static void Main()
        {
            add_db_years.start();
            add_db_connection.start();

        }
          
    }
}
