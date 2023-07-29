using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class SupplierService
    {
		private SupplierRepository _repository = new SupplierRepository();
        public List<Supplier> GetAll ()
        {
			try
			{
				return _repository.GetAll();
			}
			catch (Exception)
			{
				return new List<Supplier> ();
			}
        }

		public Supplier GetById(int id)
		{
			try
			{
				return _repository.GetById(id);
			}
			catch (Exception ex)
			{
				return default;
			}
		}

		public CommandResult Create(Supplier supplier)
		{
			try
			{
				_repository.Add(supplier);
				return CommandResult.Success("Kaydetme İşlemi Başarılı");
			}
			catch (Exception ex)
			{
				return CommandResult.Failed("Bir Hata Meydana Geldi",ex);
			}
		}

		public CommandResult Update (Supplier supplier)
		{
			try
			{
				_repository.Update(supplier);
				return CommandResult.Success("Güncelleme Başarılı");
			}
			catch (Exception ex)
			{
				return CommandResult.Failed("Bir Hata Meydana Geldi", ex);
			}
		}

		public CommandResult Delete (Supplier supplier )
		{
			try
			{
				_repository.Delete(supplier);
				return CommandResult.Success("Silme Başarılı");
			}
			catch (Exception ex)
			{
				return CommandResult.Failed("Bir Hata Meydana Geldi", ex);
			}
		}
    }
}
