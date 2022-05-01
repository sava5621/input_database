using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_database.СonnectionFolder
{
    public class add_db_connection
    {
        public static void start()
        {
            using (var db = new connectionContext())
            {
                Console.WriteLine("Считывание данных");
                var app = new Application();
                //Открываем книгу.                                                                                                                                                        
                var inbook = app.Workbooks.Open(@"C:\Users\sava5621\Desktop\db_conn.xlsx");
                object[,] buff;
                for (int i = 1; i < 14; i++)
                {
                    buff = ((object[,])app.Sheets[1].Range["A" + i.ToString() + ":B" + i.ToString()].Value);
                    db.conn.Add(new Connection { id_stage = buff[1, 1].ToString(), id_insecticides = buff[1, 2].ToString() });
                }
                db.SaveChanges();
               
            }
        }
    }
}
