using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    public class ProductRepository
    {
        public Product Find(int id)
        {
            var product = default(Product);
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = " select * from Products where ProductID=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (var reader = command.ExecuteReader()) 
                { 
                    if(reader.Read()) 
                    {
                        product = new Product()
                        {
                            Id = reader.GetInt32("ProductID"),
                            Name = reader.GetString("ProductName"),
                            SupplierId=reader.GetInt32("SupplierID"),
                            CategoryID=reader.GetInt32("CategoryID"),
                            QuantityPerUnit=reader.GetString("QuantityPerUnit"),
                            UnitPrice=reader.GetDecimal("UnitPrice"),
                            UnitsInStock=reader.GetInt16("UnitsInStock"),
                            UnitsOnOrder=reader.GetInt16("UnitsOnOrder"),
                            ReorderLevel=reader.GetInt16("ReorderLevel"),
                            Discontinued=reader.GetBoolean("Discontinued")
                        };
                    }
                }
                connection.Close();
            }
            return product;
        }

        public List<Product> GetAll() 
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand()) 
            {
                command.CommandText="select * from Products";
                connection.Open();

                var productsList=new List<Product>();

                using (var reader= command.ExecuteReader())
                {
                    while(reader.Read()) 
                    {
                        productsList.Add(MappingProduct(reader));
                    }
                }
                connection.Close();

                return productsList;
            }
        }

        public void Add(Product product)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @" insert into Products
(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)
values (@productName,@supplierID,@categoryID,@quantityPerUnit,@unitPrice,@unitsInStock,@unitsOnOrder,@reorderLevel,@discontinued)";

                connection.Open();

                command.Parameters.AddWithValue("@productName", product.Name);
                command.Parameters.AddWithValue("@supplierID", product.SupplierId);
                command.Parameters.AddWithValue("@categoryID", product.CategoryID);
                command.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit);
                command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
                command.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
                command.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder);
                command.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
                command.Parameters.AddWithValue("@discontinued", product.Discontinued);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Product product) 
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
update Products
set
    ProductName  = @Name,
    SupplierID  = @SupplierID,
    CategoryID = @CategoryID,
    QuantityPerUnit  = @QuantityPerUnit,
    UnitPrice  = @UnitPrice,
    UnitsInStock  = @UnitsInStock,
    UnitsOnOrder  = @UnitsOnOrder,
    ReorderLevel  = @ReorderLevel,
    Discontinued  = @Discontinued
where ProductID=@id";

                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@SupplierID", product.SupplierId);
                command.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                command.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
                command.Parameters.AddWithValue("@UnitPrice",product.UnitPrice);
                command.Parameters.AddWithValue("@UnitsInStock",product.UnitsInStock);
                command.Parameters.AddWithValue("@UnitsOnOrder",product.UnitsOnOrder);
                command.Parameters.AddWithValue("@ReorderLevel",product.ReorderLevel);
                command.Parameters.AddWithValue("@Discontinued",product.Discontinued);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public void Delete (Product product)
        {
            Delete((int)product.Id);
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete * from Products where ProductID=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static Product MappingProduct(SqlDataReader reader)
        {
            return new Product()
            {
                Id = reader.GetInt32("ProductID"),
                Name = reader.GetString("ProductName"),
                SupplierId = reader.GetInt32Nullable("SupplierID"),
                CategoryID = reader.GetInt32Nullable("CategoryID"),
                QuantityPerUnit = reader.GetStringNullable("QuantityPerUnit"),
                UnitPrice = reader.GetDecimalNullable("UnitPrice"),
                UnitsInStock = reader.GetInt16Nullable("UnitsInStock"),
                UnitsOnOrder = reader.GetInt16Nullable("UnitsOnOrder"),
                ReorderLevel = reader.GetInt16Nullable("ReorderLevel"),
                Discontinued = reader.GetBoolean("Discontinued")
            };
        }
    }
}
