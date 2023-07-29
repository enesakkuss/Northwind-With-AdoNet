using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class ShipperService
    {
        private ShipperRepository _repository = new ShipperRepository();
        
        public CommandResult Creat(Shipper shipper)
        {
            try
            {
                _repository.Add(shipper);
                return CommandResult.Success("Yeni Kayıt Oluşturuldu");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Yeni Kayıt Oluşturulamadı", ex);
            }
        }

        public CommandResult Delete(Shipper shipper) 
        {
            try
            {
                _repository.Delete(shipper);
                return CommandResult.Success("Silme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Kayıt Silinemedi", ex);
            }
        }

        public CommandResult Update(Shipper shipper)
        {
            try
            {
                _repository.Update(shipper);
                return CommandResult.Success("Kayıt Güncellendi");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Kayıt Güncellenemedi", ex);
            }
        }

        public List<Shipper> GetAll() 
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception)
            {
                return new List<Shipper>();
            }
        }

        public Shipper GetById(int id)
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
    }
}
