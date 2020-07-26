using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTrackerV3
{
    public class SqliteDataAccess
    {
        public static List<Task> LoadTask()
        {
            // FUNCTIONALITY TO BE CHANGED
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Grades", cnn);
                    cnn.Open();
                    SQLiteDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read()) { Console.WriteLine("Course Code: {0}\n", rdr["CourseCode"]); }
                    rdr.Close();
                }
                finally { cnn.Close(); }

                return null; // TO BE CHANGED
            }   
            
        }

        public static void SaveTask(Task task)
        {
            // FUNCTIONALITY TO BE CHANGED
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    cnn.Execute("INSERT INTO Grades (CourseCode, CourseWeight, TaskName, TaskMark, TaskWeight) " +
                        "values (@CourseCode, @CourseWeight, @TaskName, @TaskMark, @TaskWeight)", task);
                }
                catch
                {
                    // Pop-up that entry already exists
                }
                finally { cnn.Close(); }
            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
