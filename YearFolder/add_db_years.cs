using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_database.YearFolder
{
    public static class add_db_years
    {
        static public void start()
        {
            using (dataContext db = new dataContext())
            {
                Console.WriteLine("Считывание данных");
                var app = new Application();
                //Открываем книгу.                                                                                                                                                        
                var inbook = app.Workbooks.Open(@"D:\test.xlsx");


                List<data_year> data_Years = new List<data_year>();
                int year = 2005;
                for (int sheet = 1; sheet <= 10; sheet++)
                {
                    for (int i = 1; i < 30; i++)
                    {
                        object[,] arrData1 = (object[,])app.Sheets[sheet].Range["A" + i.ToString() + ":F" + i.ToString()].Value;
                        data_Years.Add(checked_Data(arrData1, year));
                    }
                    year++;
                }
                year = 2005;
                List<data_year> buff = new List<data_year>();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 29 * i; j < 29 * (i + 1); j++)
                    {
                        buff.Add(data_Years[j]);
                    }
                    data input_db = normal_data(buff.ToArray(), year, "first");
                    buff = new List<data_year>();
                    year++;
                    db.main_data_year.Add(input_db);
                }
                db.SaveChanges();
                Console.WriteLine("Завершено");
            }
            Console.Read();
        }
        static data normal_data(data_year[] input, int yearr, string titlee)
        {
            return new data
            {
                year = yearr,
                title = titlee,
                _1 = data_year_to_str(input[0]),
                _2 = data_year_to_str(input[1]),
                _3 = data_year_to_str(input[2]),
                _4 = data_year_to_str(input[3]),
                _5 = data_year_to_str(input[4]),
                _6 = data_year_to_str(input[5]),
                _7 = data_year_to_str(input[6]),
                _8 = data_year_to_str(input[7]),
                _9 = data_year_to_str(input[8]),
                _10 = data_year_to_str(input[9]),
                _11 = data_year_to_str(input[10]),
                _12 = data_year_to_str(input[11]),
                _13 = data_year_to_str(input[12]),
                _14 = data_year_to_str(input[13]),
                _15 = data_year_to_str(input[14]),
                _16 = data_year_to_str(input[15]),
                _17 = data_year_to_str(input[16]),
                _18 = data_year_to_str(input[17]),
                _19 = data_year_to_str(input[18]),
                _20 = data_year_to_str(input[19]),
                _21 = data_year_to_str(input[20]),
                _22 = data_year_to_str(input[21]),
                _23 = data_year_to_str(input[22]),
                _24 = data_year_to_str(input[23]),
                _25 = data_year_to_str(input[24]),
                _26 = data_year_to_str(input[25]),
                _27 = data_year_to_str(input[26]),
                _28 = data_year_to_str(input[27]),
                _29 = data_year_to_str(input[28])
            };

        }
        static string data_year_to_str(data_year input)
        {
            return "[" + input.Date.ToString() + ","
                + input.Count_day.ToString() + ","
                + input.Temperature.ToString() + ","
                + input.SOE_Temperature.ToString() + ","
                + input.Individuals_in_trap.ToString() + ","
                + input.Criterion_sum_effective_temperatures.ToString()+"]" ;

        }
        static data_year checked_Data(object[,] data, int year)
        {



            data_year resulst = new data_year();
            if (data[1, 1] != null)
            {
                data[1, 1] = data[1, 1].ToString() + year.ToString();
                resulst.Date = DateTime.ParseExact(data[1, 1].ToString(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                resulst.Date = DateTime.ParseExact(System.Data.SqlTypes.SqlDateTime.MinValue.ToString(), "dd.MM.yyyy h:mm:s", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (data[1, 2] != null)
                resulst.Count_day = Convert.ToInt32(data[1, 2].ToString());
            if (data[1, 3] != null)
                resulst.Temperature = (float)Convert.ToDouble(data[1, 3].ToString());
            if (data[1, 4] != null)
                resulst.SOE_Temperature = (float)Convert.ToDouble(data[1, 4].ToString());
            if (data[1, 5] != null)
                resulst.Individuals_in_trap = Convert.ToInt32(data[1, 5].ToString());
            if (data[1, 6] != null)
                resulst.Criterion_sum_effective_temperatures = Convert.ToInt32(data[1, 6].ToString());
            return resulst;
        }
    }
}
