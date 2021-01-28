using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Budgeteer.Classes.SqliteDataAccess
{
    public static class SqliteDataAccess
    {
        public static void SaveToDb(Expense.Expense expense)
            // Save Expense object to the DB
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Expense (Amount, Article,Month,Year,Category) values (@amount, @article,@month,@year,@category)", expense);
            }
        }
        public static List<Expense.Expense> LoadFromDbToList(string sqlCommand)
        {
            // Load Expense object from DB to List
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Expense.Expense>(sqlCommand, new DynamicParameters());
                return output.ToList();
            }
        }
        public static double LoadFromDbToDouble(string sqlCommand)
        {
            // Load from Expense DB to single value par
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return Convert.ToDouble(cnn.ExecuteScalar(sqlCommand, new DynamicParameters()));
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            // Connection String
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public static void deleteAllDataFromTable()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Expense");
            }
        }
        public static void ExecuteSql(string sql)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(sql);
            }
        }
    }
}
