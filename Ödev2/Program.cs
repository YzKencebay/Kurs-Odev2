using Ödev2.Business.Concretes;
using Ödev2.DataAccess.Abstracts;
using Ödev2.DataAccess.Concretes;
using Ödev2.Entities;

namespace HomeWorkIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new  CategoryDal());
            List<Category> categories = categoryManager.GetAll();
            foreach(var category in categories)
            {
                Console.WriteLine(category.CategoryId+" = "+category.CategoryName);

            }
            Console.WriteLine("----------");

            categories.Add(new Category { CategoryId = 3, CategoryName = "Algoritmalara" });

            List<Category> categories1 = categoryManager.GetAll();

            foreach(var category in categories)
            {
                Console.WriteLine(category.CategoryId + " = " + category.CategoryName);
            }
            Console.ReadLine();
        }
    }


}
