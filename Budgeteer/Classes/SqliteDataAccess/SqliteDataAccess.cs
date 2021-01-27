using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Budgeteer.Classes.Expense;

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
            // Load Expense object from DB
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Expense.Expense>("select * from Expense", new DynamicParameters());
                return output.ToList();
            }
        }
        public static double LoadFromDbToDouble(string sqlCommand)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return (double)cnn.ExecuteScalar($"SELECT sum(Amount) FROM Expense", new DynamicParameters());
            }
        }


        public static double FullLoadExpenseSumByCategory(string category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return (double)cnn.ExecuteScalar($"SELECT sum(Amount) FROM Expense Where Category = '{category}'", new DynamicParameters());
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<Expense.Expense> LoadExpenceByMonthAndYear(string month, string year)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Expense.Expense>($"SELECT * FROM Expense WHERE Month = '{month}' AND Year = '{year}'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static double getExpenseSumByMonthAndYear(string month, string year)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return (double)cnn.ExecuteScalar($"SELECT sum(Amount) FROM Expense WHERE Month = '{month}' AND Year = '{year}'", new DynamicParameters());
            }
        }
    }
}
