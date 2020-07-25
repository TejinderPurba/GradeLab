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
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Task>("Select * from Grades", new DynamicParameters());
                return output.ToList();
            }   
            
        }

        public static void SaveTask(Task task)
        {
            // FUNCTIONALITY TO BE CHANGED
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Grades (CourseCode, CourseWeight, TaskName, TaskMark, TaskWeight) " +
                    "values (@CourseCode, @CourseWeight, @TaskName, @TaskMark, @TaskWeight)", task);
            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
