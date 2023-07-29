using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class EmployeeService
    {
        private EmployeeRepository _repository=new EmployeeRepository();

        public CommandResult Creat(Employee employee)
        {
            try
            {
                _repository.Creat(employee);
                return CommandResult.Success("Yeni Kayıt Oluşturuldu");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed(" Yeni Kayıt Oluşturulamadı", ex);
            }
        }

        public CommandResult Delete(Employee employee) 
        {
            try
            {
                _repository.Delete(employee);
                    return CommandResult.Success("Silme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Silme İşlemi Başarısız", ex);
            }
        }
        public CommandResult Update(Employee employee) 
        {
            try
            {
                _repository.Updade(employee);
                return CommandResult.Success("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Güncelleme Başarısız", ex);
            }
        }
        public Employee GetById(int id)
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
        public List<Employee> GetAll() 
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception)
            {
                return new List<Employee>();
            }
        }
    }
}
