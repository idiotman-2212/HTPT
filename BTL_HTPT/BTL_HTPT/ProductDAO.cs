using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_HTPT
{
    class ProductDAO
    {
        private SQLConnector connector;
        private string connectionString;
        
        public string ConnectionString
        {
            get => connectionString;

            set
            {
                connectionString = value;
                connector = new SQLConnector(value);
            }
        }

        public ProductDAO(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool InsertProduct(Product product)
        {
            string spInsertProductName = "SP_Insert_Product";

            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", product.ProductID),
                new SqlParameter("@ProductName", product.ProductName),
                new SqlParameter("@Price", product.Price),
                new SqlParameter("@ManufactureDate", product.ManufactureDate),
                new SqlParameter("@IsAvailable", product.IsAvailable)
            };

            bool isSuccess = connector.ExecuteStoredProcedure(spInsertProductName, parameters);

            return isSuccess;
        }

        public bool UpdateProduct(Product product)
        {
            string spUpdateProductName = "SP_Update_Product";

            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", product.ProductID),
                new SqlParameter("@ProductName", product.ProductName),
                new SqlParameter("@Price", product.Price),
                new SqlParameter("@ManufactureDate", product.ManufactureDate),
                new SqlParameter("@IsAvailable", product.IsAvailable)
            };

            bool isSuccess = connector.ExecuteStoredProcedure(spUpdateProductName, parameters);

            return isSuccess;
        }

        public bool DeleteProduct(Product product)
        {
            string spDeleteProductName = "SP_Delete_Product";

            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", product.ProductID)
            };

            bool isSuccess = connector.ExecuteStoredProcedure(spDeleteProductName, parameters);

            return isSuccess;
        }

        public DataTable GetProductTable()
        {
            string query = "SELECT * FROM dbo.Product";
            return connector.GetTable(query);
        }
    }
}
