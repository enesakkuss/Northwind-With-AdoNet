using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class ProductService
    {
        private ProductRepository _repository = new ProductRepository();

        public List<Product> GetAll()
        {
            try
            {
                return _repository.GetAll();
                    
            }
            catch (Exception)
            {

                return new List<Product>();
            }
        }

        public Product Find(int id)
        {
            try
            {
                return _repository.Find(id);
            }
            catch (Exception)
            {

                return default;
            }
        }

        public CommandResult Creat(Product product)
        {
            try
            {
                _repository.Add(product);
                return CommandResult.Success("Yeni Ürün Eklendi");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Yeni Ürün Eklenemedi",ex);
            }
        }

        public CommandResult Update(Product product)
        {
            try
            {
                _repository.Update(product);
                return CommandResult.Success("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Güncelleme Bşarısız", ex);
            }
        }

        public CommandResult Delete (Product product)
        {
            try
            {
                _repository.Delete(product);
                return CommandResult.Success("Silme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Silme İşlemi Başarısız", ex);
            }
        }

        public CommandResult UpdatePricesBySupplier(int supplierId,decimal changeRate, bool isDiscount) 
        {
            try
            {
                var allProduct = GetAll();
                var productToUpdate=new List<Product>();

                foreach (var product in allProduct)
                {
                    if(product.SupplierId==supplierId)
                    {
                        productToUpdate.Add(product);
                    }
                }
                changeRate = isDiscount? -changeRate: changeRate;

                for (int i = 0; i < productToUpdate.Count; i++)
                {
                    productToUpdate[i].UnitPrice *= 1 + changeRate;

                    // UnitOfWork
                    // Aşağıdaki iişlem biraz hantal bir ilerleyiş
                    // update metodu her çağırıldığında yeni baştan SqlConnection, SqlCommand
                    // nesnelerin oluşturulup, işleö sonunda yıkılıyor
                    // Bu toplu güncelleme işlmei tek bir Transaction (bkz, inceleyiniz)
                    // altında yapabilmek için UnitOfWork patternına ihtiyacımız var
                    _repository.Update(productToUpdate[i]);
                }

                return CommandResult.Success("Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("İşlem Başarısız", ex);
            }
            
        }

        public List<Product> GetBySupplierId(int supplierId)
        {
            var allProduct = GetAll();
            var productToUpdate = new List<Product>();

            foreach (var product in allProduct)
            {
                if (product.SupplierId == supplierId)
                {
                    productToUpdate.Add(product);
                }
            }

            return productToUpdate;
        }
    }
}
