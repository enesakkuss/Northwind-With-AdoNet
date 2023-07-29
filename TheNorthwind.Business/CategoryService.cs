using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    // CategoryBusiness
    // CategoryBLL (Business Layer Logic)
    // CategoryManager
    //CategoryFacade
    public class CategoryService
    {
        private CategoryRepository _repository = new CategoryRepository();
        public List<Category> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                // TODO: hata mesajını logla
                return new List<Category>();
            }
        }
        public Category GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch(Exception ex) 
            {
                // TODO: HAata mesajını Logla
                return default;
            }
        }

        public CommandResult Create(Category category)
        { 
            try
            {
                _repository.Add(category);
                return CommandResult.Success("Yeni Kategori Oluşturuldu");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Bir Hata Meydana Geldi", ex);
            }
        }
        public CommandResult Update(Category category)
        {
            try
            {
                 _repository.Update(category);
                return CommandResult.Success("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {

                return CommandResult.Failed("Bir Hata Meydana Geldi", ex);
            }
        }
        public CommandResult Delete(Category category) 
        {
            try
            {
                _repository.Remove(category);
                return CommandResult.Success("Silme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failed("Bir Hata Meydana Geldi", ex);
            }
        }
    }
    

}
