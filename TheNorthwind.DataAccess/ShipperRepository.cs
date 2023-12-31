﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    public class ShipperRepository
    {
        public void Add(Shipper shipper)
        {
            using(var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Shippers (CompanyName,Phone) 
values (@companyName, @phone)";

                command.Parameters.AddWithValue("@companyName", shipper.CompanyName);
                command.Parameters.AddWithValue("@phone", shipper.Phone);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Shipper shipper) 
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"update Shippers  
set 
    CompanyName=@companyName,
    Phone=@phone
where ShipperID=@id";

                command.Parameters.AddWithValue("@id", shipper.Id);
                command.Parameters.AddWithValue("@companyName", shipper.CompanyName);
                command.Parameters.AddWithValue("@phone", shipper.Phone);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(Shipper shipper)
        {
            Delete(shipper.Id);
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"delete  from Shippers where ShipperID=@id";

                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Shipper GetById(int id)
        {
            var shipper = default(Shipper);
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"select * from Shippers where ShipperID=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        shipper = new Shipper()
                        {
                            Id= reader.GetInt32("ShipperID"),
                            CompanyName=reader.GetString("CompanyName"),
                            Phone=reader.GetStringNullable("Phone")
                        };
                    }
                }
                connection.Close();
            }
            return shipper;
        }

        public List<Shipper> GetAll()
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Shippers";

                connection.Open();

                var shipperList=new List<Shipper>();

                using(var reader = command.ExecuteReader()) 
                { 
                    while(reader.Read()) 
                    {
                        var shipper = new Shipper()
                        {
                            Id = reader.GetInt32("ShipperID"),
                            CompanyName = reader.GetString("CompanyName"),
                            Phone = reader.GetStringNullable("Phone")
                        };
                        shipperList.Add(shipper);
                    }
                }
                connection.Close();
                return shipperList;
            }
        }
    }
}
