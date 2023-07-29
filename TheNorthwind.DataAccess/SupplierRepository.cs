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
    public class SupplierRepository
    {
        public void Add(Supplier supplier)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Suppliers 
(CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage)
values(@companyName,@contactName,@contactTitle,@adress,@city,@region,@postalCode,@country,@phone,@fax,@homePage)";
                connection.Open();

                command.Parameters.AddWithValue("@companyName", supplier.CompanyName);
                command.Parameters.AddWithValue("@contactName", supplier.ContactName);
                command.Parameters.AddWithValue("@contactTitle", supplier.ContactTitle);
                command.Parameters.AddWithValue("@adress", supplier.Address);
                command.Parameters.AddWithValue("@city", supplier.City);
                command.Parameters.AddWithValue("@region", supplier.Region);
                command.Parameters.AddWithValue("@postalCode", supplier.PostalCode);
                command.Parameters.AddWithValue("@country", supplier.Country);
                command.Parameters.AddWithValue("@phone", supplier.Phone);
                command.Parameters.AddWithValue("@fax", supplier.Fax);
                command.Parameters.AddWithValue("@homePage", supplier.HomePage);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Update(Supplier supplier)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
update Suppliers
    SET   CompanyName = @companyName,
      ContactName = @contactName,
      ContactTitle = @contactTitle,
      Address = @address,
      City = @city,
      Region = @region,
      PostalCode = @postalCode,
      Country = @country,
      Phone = @phone,
      Fax = @fax,
      HomePage = @homePage
where SupplierID=@id";

                command.Parameters.AddWithValue("@id", supplier.Id);
                command.Parameters.AddWithValue("@companyName", supplier.CompanyName);
                command.Parameters.AddWithValue("@contactName", supplier.ContactName);
                command.Parameters.AddWithValue("@contactTitle", supplier.ContactTitle);
                command.Parameters.AddWithValue("@address", supplier.Address);
                command.Parameters.AddWithValue("@city", supplier.City);
                command.Parameters.AddWithValue("@region", supplier.Region);
                command.Parameters.AddWithValue("@postalCode", supplier.PostalCode);
                command.Parameters.AddWithValue("@country", supplier.Country);
                command.Parameters.AddWithValue("@phone", supplier.Phone);
                command.Parameters.AddWithValue("@fax", supplier.Fax);
                command.Parameters.AddWithValue("@homePage", supplier.HomePage);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete (Supplier supplier)
        {
            Delete(supplier.Id);
        }

        public void Delete (int id)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete from Suppliers where SupplierID=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // GetById metodu repository sınıflarında Find Olarakta İsimlendirilebilir
        public Supplier GetById(int id)
        {
            var supplier = default(Supplier);
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Suppliers where SupplierID=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (var dr = command.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        supplier = new Supplier()
                        {
                            Id=dr.GetInt32("SupplierID"),
                            CompanyName=dr.GetString("CompanyName"),
                            ContactName=dr.GetStringNullable("ContactName"),
                            ContactTitle= dr.GetStringNullable("ContactTitle"),
                            Address= dr.GetStringNullable("Address"),
                            City= dr.GetStringNullable("City"),
                            Region=dr.GetStringNullable("Region"),
                            PostalCode= dr.GetStringNullable("PostalCode"),
                            Country= dr.GetStringNullable("Country"),
                            Phone= dr.GetStringNullable("Phone"),
                            Fax= dr.GetStringNullable("Fax"),
                            HomePage= dr.GetStringNullable("Homepage")
                        };
                    }     
                }
                connection.Close();
            }
            return supplier;
        }

        public List<Supplier> GetAll ()
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                    command.CommandText = "select * from Suppliers";
                    connection.Open();

                    var supplierList= new List<Supplier>();

                    using(var dr= command.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            supplierList.Add(MapSupplier(dr));
                        }
                    }
                    connection.Close();

                    return supplierList;
            }
        }

        private static Supplier MapSupplier(SqlDataReader dr)
        {
            return new Supplier()
            {
                Id = dr.GetInt32("SupplierID"),
                CompanyName = dr.GetStringNullable("CompanyName"),
                ContactName = dr.GetStringNullable("ContactName"),
                ContactTitle = dr.GetStringNullable("ContactTitle"),
                Address = dr.GetStringNullable("Address"),
                City = dr.GetStringNullable("City"),
                Region = dr.GetStringNullable("Region"),
                PostalCode = dr.GetStringNullable("PostalCode"),
                Country = dr.GetStringNullable("Country"),
                Phone = dr.GetStringNullable("Phone"),
                Fax = dr.GetStringNullable("Fax"),
                HomePage = dr.GetStringNullable("HomePage")
            };
        }
    }
}
