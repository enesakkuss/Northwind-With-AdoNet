using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    // Repository Pattern
    // Repository => Depo anlamına gelir
    // Projelerin veriye erişen katmanlarında, Sql'de bir tabloyu temsilen koleksiyon tipindeki nesnelerin
    // ve bir satırlık kayıdı temsilen Entitiy nesnelerinin oluşturulduğu, çözümlendiği katman

    // Kategori tablosu ile ilgili veri işlemleri bu sınıfta yer alacak
    // Veri işlemleri? CRUD
    // Create
    // Read
    // Update
    // Delete
    public class CategoryRepository
    {
        // Creat, Insert
        public void Add (Category category)
        {
            
            using (var connection=new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "insert into Categories (CategoryName,Description) values (@name, @description)";

                connection.Open();

                command.Parameters.AddWithValue("@name", category.Name);
                command.Parameters.AddWithValue("@description", category.Description);

                command.ExecuteNonQuery();


                connection.Close();
                // Önce Parametreler Sonra Execute Sonra Close 
            }

        }
        public void Update (Category category) 
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
update Categories 
    set CategoryName=@name,
        Description=@description
where CategoryID=@id";

                command.Parameters.AddWithValue("@id", category.Id);
                command.Parameters.AddWithValue("@name", category.Name);
                command.Parameters.AddWithValue("@description", category.Description);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
        
            }


        }

        // Delete
        public void Remove (Category category) 
        {
            Remove(category.Id);
        }
        public void Remove (int id) 
        {
            using (var connection = new SqlConnection(DbSetting.ConntectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete  from Categories where CategoryID=@id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Open();
            }
        }

        public Category GetById(int id)
        {
            var category = default (Category);
            using (var connection=new SqlConnection(DbSetting.ConntectionString))
            using (var command=connection.CreateCommand())
            {
                command.CommandText = ("select * from Categories where CategoryID=@id");
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (var dr = command.ExecuteReader())
                {
                    if(dr.HasRows && dr.Read())
                    {
                            category = new Category()
                            {
                                Id = dr.GetInt32("CategoryID"),
                                Name=dr.GetString("CategoryName"),
                                Description=dr.GetString("Description")
                            };
                    }
                }
                connection.Close();
            }
                return category;
        }
        public List<Category> GetAll()
        {
            using (var conn = new SqlConnection(DbSetting.ConntectionString))
            using (var comm = new SqlCommand())
            {
                try
                {
                    comm.Connection = conn;
                    comm.CommandText =
                        @"select CategoryID,CategoryName,Description from Categories";

                    conn.Open();

                    var categoryList = new List<Category>();

                    using (var dataReader = comm.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            var category = new Category()
                            {
                                // datareader, Result Set içindeki kolon isimleri
                                // ile ilgilenir, onları bilir
                                // Eğer sorguda kolon isimleri alias ile değiştirildiyse
                                // dataReader["Kolon_Adı"] kısmında yazılacak kolon adı da
                                // alias ile aynı olmalıdır
                                Id = (int)dataReader["CategoryID"],
                                Name = (string)dataReader["CategoryName"],
                                Description = (string)dataReader["Description"]
                            };
                            categoryList.Add(category);
                        }
                    }
                    conn.Close();

                    return categoryList;
                }
                catch (Exception )
                {
                    throw;
                }

            }
        }
    }
}
