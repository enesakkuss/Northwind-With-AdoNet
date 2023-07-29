using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    public class EmployeeRepository
    {
        public void Creat (Employee employee) 
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Employees
(LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,
Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo,PhotoPath)
values 
(@LastName,@FirstName,@Title,@TitleOfCourtesy,@BirthDate,@HireDate,@Address,
@City,@Region,@PostalCode,@Country,@HomePhone,@Extension,@Notes,@ReportsTo,@PhotoPath)
";
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@Title", employee.Title);
                command.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourtesy);
                command.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                command.Parameters.AddWithValue("@HireDate", employee.HireDate);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@City", employee.City);
                command.Parameters.AddWithValue("@Region", employee.Region);
                command.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
                command.Parameters.AddWithValue("@Country", employee.Country);
                command.Parameters.AddWithValue("@HomePhone", employee.HomePhone);
                command.Parameters.AddWithValue("@Extension", employee.Extension);
                command.Parameters.AddWithValue("@Notes", employee.Notes);
                command.Parameters.AddWithValue("@ReportsTo", employee.ReportsTo);
                command.Parameters.AddWithValue("@PhotoPath", employee.PhotoPath);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Updade(Employee employee)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
UPDATE [dbo].[Employees]
   SET 
        LastName = @LastName,
        FirstName = @FirstName,
        Title = @Title,
        TitleOfCourtesy = @TitleOfCourtesy,
        BirthDate = @BirthDate,
        HireDate = @HireDate,
        Address = @Address,
        City = @City,
        Region = @Region, ,
        PostalCode = @PostalCode,
        Country = @Country,
        HomePhone = @HomePhone,
        Extension = @Extension,
        Notes = @Notes,
        ReportsTo = @Reports,
        PhotoPath = @PhotoPath
where EmployeeID=@id";

                command.Parameters.AddWithValue("@id", employee.ID);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@Title", employee.Title);
                command.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourtesy);
                command.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                command.Parameters.AddWithValue("@HireDate", employee.HireDate);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@City", employee.City);
                command.Parameters.AddWithValue("@Region", employee.Region);
                command.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
                command.Parameters.AddWithValue("@Country", employee.Country);
                command.Parameters.AddWithValue("@HomePhone", employee.HomePhone);
                command.Parameters.AddWithValue("@Extension", employee.Extension);
                command.Parameters.AddWithValue("@Notes", employee.Notes);
                command.Parameters.AddWithValue("@ReportsTo", employee.ReportsTo);
                command.Parameters.AddWithValue("@PhotoPath", employee.PhotoPath);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(Employee employee)
        {
            Delete(employee.ID);
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"delete from Employees where EmployeeID=@id";

                command.Parameters.AddWithValue("id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Employee GetById(int id)
        {
            var employee = default(Employee);
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"select *
from Employees where EmployeeID=@id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();

                using (var reader = command.ExecuteReader()) 
                {
                    if(reader.Read()) 
                    {
                        employee = new Employee()
                        {
                            ID = reader.GetInt32("EmployeeID"),
                            LastName=reader.GetString("LastName"),
                            FirstName=reader.GetString("FirstName"),
                            Title=reader.GetStringNullable("Title"),
                            TitleOfCourtesy=reader.GetStringNullable("TitleOfCourtesy"),
                            BirthDate= reader.GetDateTimeNullable("BirthDate"),
                            HireDate=reader.GetDateTimeNullable("HireDate"),
                            Address=reader.GetStringNullable("Address"),
                            City=reader.GetStringNullable("City"),
                            Region=reader.GetStringNullable("Region"),
                            PostalCode=reader.GetStringNullable("PostalCode"),
                            Country=reader.GetStringNullable("Country"),
                            HomePhone=reader.GetStringNullable("HomePhone"),
                            Extension=reader.GetStringNullable("Extension"),
                            Notes=reader.GetStringNullable("Notes"),
                            ReportsTo=reader.GetInt32Nullable("ReportsTo"),
                            PhotoPath=reader.GetStringNullable("PhotoPath")
                        };
                    }
                }
                connection.Close();
            }
            return employee;
        }

        public List<Employee> GetAll()
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"select 
      EmployeeID,
      LastName,
      FirstName,
      Title,
      TitleOfCourtesy,
      BirthDate,
      HireDate,
      Address,
      City,
      Region,
      PostalCode,
      Country,
      HomePhone,
      Extension,
      Notes,
      ReportsTo,
      PhotoPath
from Employees";
                connection.Open();

                var employeeList=new List<Employee>();

                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read()) 
                    {
                        var employee = new Employee()
                        {
                            ID=reader.GetInt32("EmployeeID"),
                            LastName = reader.GetString("LastName"),
                            FirstName = reader.GetString("FirstName"),
                            Title = reader.GetStringNullable("Title"),
                            TitleOfCourtesy = reader.GetStringNullable("TitleOfCourtesy"),
                            BirthDate = reader.GetDateTimeNullable("BirthDate"),
                            HireDate = reader.GetDateTimeNullable("HireDate"),
                            Address = reader.GetStringNullable("Address"),
                            City = reader.GetStringNullable("City"),
                            Region = reader.GetStringNullable("Region"),
                            PostalCode = reader.GetStringNullable("PostalCode"),
                            Country = reader.GetStringNullable("Country"),
                            HomePhone = reader.GetStringNullable("HomePhone"),
                            Extension = reader.GetStringNullable("Extension"),
                            Notes = reader.GetStringNullable("Notes"),
                            ReportsTo = reader.GetInt32Nullable("ReportsTo"),
                            PhotoPath = reader.GetStringNullable("PhotoPath")
                        };
                        employeeList.Add(employee);
                    }
                }
                connection.Close();
                return employeeList;
            }
        }
    }
}
