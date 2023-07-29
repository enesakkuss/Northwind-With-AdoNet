using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;

namespace TheNorthwind.DataAccess
{
    public class CustomerRepository
    {
        public void Creat(Customer customer)
            {
                using (var connection = new SqlConnection(DbSetting.ConntectionString))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into Customers
    (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)
    values(@CustomerID,@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Fax)
    ";
                    connection.Open();
    
                    command.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
                    command.Parameters.AddWithValue("@ContactName", customer.ContactName);
                    command.Parameters.AddWithValue("@ContactTitle", customer.ContactTitle);
                    command.Parameters.AddWithValue("@Address", customer.Address);
                    command.Parameters.AddWithValue("@City", customer.City);
                    command.Parameters.AddWithValue("@Region", customer.Region);
                    command.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
                    command.Parameters.AddWithValue("@Country", customer.Country);
                    command.Parameters.AddWithValue("@Phone", customer.Phone);
                    command.Parameters.AddWithValue("@Fax", customer.Fax);
    
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        public void Update(Customer customer)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"update Customers
SET
      CustomerID = @CustomerID,
      CompanyName = @CompanyName,
      ContactName = @ContactName,
      ContactTitle = @ContactTitle,
      Address = @Address,
      City = @City,
      Region = @Region,
      PostalCode = @PostalCode,
      Country = @Country,
      Phone = @Phone,
      Fax = @Fax
where CustomerID=@id";

                connection.Open();

                command.Parameters.AddWithValue("@id", customer.Id);
                command.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
                command.Parameters.AddWithValue("@ContactName", customer.ContactName);
                command.Parameters.AddWithValue("@ContactTitle", customer.ContactTitle);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@City", customer.City);
                command.Parameters.AddWithValue("@Region", customer.Region);
                command.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
                command.Parameters.AddWithValue("@Country", customer.Country);
                command.Parameters.AddWithValue("@Phone", customer.Phone);
                command.Parameters.AddWithValue("@Fax", customer.Fax);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Delete(int id) 
            {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"delete from Customers where CustomerID=@id";

                connection.Open();
                command.Parameters.AddWithValue ("@id",id);

                command.ExecuteNonQuery();
                connection.Close();
            }
            }
        public void Delete(Customer customer)
        {
            Delete(customer.Id);
        }
        public Customer GetById(int id)
        {
            var customer=default(Customer);
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select from Customers where CustomerID=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (var reader=command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        customer = new Customer()
                        {
                            Id = reader.GetChar("ID"),
                            CompanyName=reader.GetStringNullable("CompanyName"),
                            ContactName =reader.GetStringNullable("ContactName"),
                            ContactTitle=reader.GetStringNullable("ContactTitle"),
                            Address=reader.GetStringNullable("Address"),
                            City=reader.GetStringNullable("City"),
                            Region=reader.GetStringNullable("Region"),
                            PostalCode=reader.GetStringNullable("PostalCode"),
                            Country=reader.GetStringNullable("Country"),
                            Phone=reader.GetStringNullable("Fax"),
                            Fax=reader.GetStringNullable("Fax")
                        };
                    }
                }
                connection.Close();
            }
                return customer;
        }
        public List<Customer> GetAll()
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Customers";
                connection.Open();
                var customerList=new List<Customer>();

                using (var reader=command.ExecuteReader())
                {
                    while(reader.Read()) 
                    {
                        var customer = new Customer()
                        {
                            Id = reader.GetChar("ID"),
                            CompanyName = reader.GetStringNullable("CompanyName"),
                            ContactName = reader.GetStringNullable("ContactName"),
                            ContactTitle = reader.GetStringNullable("ContactTitle"),
                            Address = reader.GetStringNullable("Address"),
                            City = reader.GetStringNullable("City"),
                            Region = reader.GetStringNullable("Region"),
                            PostalCode = reader.GetStringNullable("PostalCode"),
                            Country = reader.GetStringNullable("Country"),
                            Phone = reader.GetStringNullable("Fax"),
                            Fax = reader.GetStringNullable("Fax")
                        };
                        customerList.Add(customer);
                    }
                }
                connection.Close();
                return customerList;
            }
        }
    }
}
