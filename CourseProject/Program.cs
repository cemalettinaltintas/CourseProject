using CourseProject.Business.Concrete;
using CourseProject.DataAccess.Concrete;

public class Program
{
    public static void Main(string[] args)
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        var category = categoryManager.GetAll().FirstOrDefault(c => c.Id == 2);
        categoryManager.Delete(category);
        categoryManager.GetAll();

    }
}