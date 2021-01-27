using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeteer.Classes.Expense
{
    public class Expense
    {
        public int id { get; set; }
        public double amount { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string article { get; set; }
        public string category { get; set; }

        public string FullExpense
        {
            get
            {
                return $"Price: {amount}, Article {article}, Category: {category} Month: {month}, Year {year} .";
            }
        }
    }
}
