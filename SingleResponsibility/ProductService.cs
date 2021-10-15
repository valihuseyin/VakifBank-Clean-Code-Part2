using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        
        private string connectionString = @"Data Source=(localdb)\MssqlLocaldb;Initial Catalog=VakifDb1;Integrated Security=True";
        public int AddProduct(string name, double price)
        {
         

            string commandText = "INSERT into  Products (Name,Price) values (@name, @price)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            SqlDbHelper sqlDbHelper = new SqlDbHelper(connectionString);
            var affectedRows = sqlDbHelper.ExecuteCommand(commandText, parameters);

            return affectedRows;
        }
    }
}
