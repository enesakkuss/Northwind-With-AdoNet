using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class CustomerService
    {
        private CustomerRepository _repository=new CustomerRepository();

        public CommandResult Creat(Customer customer) 
        {
            try
            {
                _repository.Creat(customer);
                return CommandResult.Success("Yeni Müşteri Oluşturuldu");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Müşteri Oluşturulamadı", ex);
            }
        }
        public CommandResult Delete(Customer customer) 
        {
            try
            {
                _repository.Delete(customer);
                return CommandResult.Success("Müşteri Silindi");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Müşteri Silinemedi", ex);
            }
        }

        public CommandResult Update(Customer customer) 
        {
            try
            {
                _repository.Update(customer);
                return CommandResult.Success("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Güncellenemedi", ex);
            }
        }

        public Customer GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception)
            {
                return default;
            }
        }
        public List<Customer> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception)
            {
                return new List<Customer>();
            }
        }

    }
}
