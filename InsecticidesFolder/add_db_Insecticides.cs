using input_database.YearFolder;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace input_database.InsecticidesFolder
{
    public static class add_db_Insecticides
    {
        public static void start()
        {
            var db = new InsecticidesContext();
            Console.WriteLine("Считывание данных");
            var app = new Application();
            //Открываем книгу.                                                                                                                                                        
            var inbook = app.Workbooks.Open(@"C:\Users\sava5621\Desktop\db_inspec.xlsx");
            List<Insecticides> dataExel = new List<Insecticides>();
            object[,] buff;
            for (int i = 1; i < 116; i++)
            {
                buff = ((object[,])app.Sheets[1].Range["A" + i.ToString() + ":B" + i.ToString()].Value);
                db.insec.Add(new Insecticides { title = buff[1, 1].ToString(), standard = get_standart( buff[1, 2] ?? "0" )});
            }
            db.SaveChanges();
            Console.WriteLine(dataExel.ToString());
         

        }

        private static string get_standart(object v)
        {
            string vv = v.ToString();
            string[] buff_str = vv.Split('-');
            if (buff_str.Length == 2)
            {
                float[] double_standart = { (float)Convert.ToDouble(buff_str[0]), (float)Convert.ToDouble(buff_str[1]) };
                return JsonConvert.SerializeObject(double_standart);
            }
            else
            {
                return vv;
            }
        }
    }
}
