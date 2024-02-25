using CourseProject.DataAccess.Abstract;
using CourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{ Id=1,Name="Back-end"},
                new Category{ Id=2,Name="Front-end"},
            };
        }
        public void Add(Category t)
        {
            try
            {
                _categories.Add(t);
                Console.WriteLine(t.Name+ " kategorisi eklendi.");
            }
            catch (Exception)
            {
                Console.WriteLine("Kategori eklenirken hata oluştu: " + Exception.Equals) ;
            }
        }

        public void Delete(Category t)
        {
            var result=_categories.Remove(t);
            if (result)
            {
                Console.WriteLine("Kategori başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Kategori silinemedi.");
            }
        }

        public List<Category> GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine("Kategor adı: "+category.Name);
            }
            return _categories;
        }

        public void Update(Category t)
        {
            var result=_categories.FirstOrDefault(item=>item.Id==t.Id);
            if (result!=null)
            {
                result.Id = t.Id;
                result.Name = t.Name;
                Console.WriteLine(result.Name+" kategorisi güncellendi.");
            }
            else
            {
                Console.WriteLine("Kategor güncellenemedi.");
            }

        }
    }
}
