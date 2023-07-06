using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ERCTest.UI.Models
{
    /// <summary>
    /// Работа с БД
    /// </summary>
    class DBConnect
    {
        /// <summary>
        /// Запись показаний в БД
        /// </summary>
        /// <param name="inputText1"></param>
        /// <param name="inputText2"></param>
        /// <param name="inputText3"></param>
        /// <param name="inputText4"></param>
        public void AddData(double inputText1, double inputText2, double inputText3, double inputText4)
        {

            using (SqliteConnection db =
              new SqliteConnection("Data Source=userdata.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO ERC VALUES (NULL, @Entry1, @Entry2, @Entry3, @Entry4);";
                insertCommand.Parameters.AddWithValue("@Entry1", inputText1);
                insertCommand.Parameters.AddWithValue("@Entry2", inputText2);
                insertCommand.Parameters.AddWithValue("@Entry3", inputText3);
                insertCommand.Parameters.AddWithValue("@Entry4", inputText4);

                insertCommand.ExecuteReader();
            }

        }

        /// <summary>
        /// Извлечение данных из БД по номеру столбца (ХВС, ГВС, ЭЭ день, ЭЭ ночь)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double GetData(int num)
        {
            List<double> list = new List<double>();
            using (SqliteConnection db =
               new SqliteConnection("Data Source=userdata.db"))
            {
                db.Open();

                SqliteCommand command = new SqliteCommand("SELECT * FROM ERC", db);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var cws = reader.GetValue(1);
                            var hws = reader.GetValue(2);
                            var electDay = reader.GetValue(3);
                            var electNight = reader.GetValue(4);

                            list.Add((double)cws);
                            list.Add((double)hws);
                            list.Add((double)electDay);
                            list.Add((double)electNight);
                        }
                    }
                    else
                    {
                        list.Add(0);
                        list.Add(0);
                        list.Add(0);
                        list.Add(0);
                    }
                }
            }
            list.Reverse();
            return list[num];
        }
    }
}
