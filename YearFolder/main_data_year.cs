using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_database.YearFolder
{
    class data_year
    {
        public int id { get; set; }
        public DateTime Date { get; set;}  
        public int Count_day { get; set; }  
        public float Temperature { get; set; }
        public float SOE_Temperature { get; set; }
        public int Individuals_in_trap { get; set; }
       
    }
}
