using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_database.InsecticidesFolder
{
    public class Insecticides
    {
        public int id { get; }
        public string title { get; set; }
        public string standard { get; set; }
        public float price { get; set; }
        public string about { get; set; }
    }
}
