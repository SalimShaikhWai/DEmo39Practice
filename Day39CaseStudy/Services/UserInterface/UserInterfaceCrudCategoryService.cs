using Day39CaseStudy.DataAccess.Models;
using Day39CaseStudy.Services.DbService.Interfaces;
using Day39CaseStudy.Services.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39CaseStudy.Services.UserInterface
{
    public class UserInterfaceCrudCategoryService
    {

        readonly ICrudService<Category> _categoryService;

        public UserInterfaceCrudCategoryService()
        {
            _categoryService = CrudFactory.Create<Category>();
        }

        public void Add()
        {
            var category = new Category();

            Console.WriteLine("Adding New Category");
            Console.WriteLine("----------------");

            Console.Write("Enter Category Name: ");
            var categoryNameText = Console.ReadLine();
            category.CategoryName = categoryNameText;

         

            try
            {
                _categoryService.Add(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Adding product: {ex.Message}");
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        public void Update()
        {
            Console.WriteLine("Updating existing Category");
            Console.WriteLine("-----------------------");

            Console.Write("Enter Product Name to Update: ");
            var categoryNameText = Console.ReadLine();

            var category = _categoryService.GetByName(categoryNameText);

            if (category == null)
            {
                Console.WriteLine($"Category Name {categoryNameText} not found!!");
                return;
            }

            Console.WriteLine($"Found Category: {category}");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Enter Category  Name to change: ");
            category.CategoryName = Console.ReadLine();

        }

        public void Delete()
        {
            Console.WriteLine("Deleting existing Category");
            Console.WriteLine("-----------------------");

            Console.Write("Enter the Category Id to delete: ");
            var categoryIdText = Console.ReadLine();
            var categoryId = int.Parse(categoryIdText);

            _categoryService.Delete(categoryId);
        }

        public void Show()
        {
            var categories = _categoryService.GetAll();

            Console.WriteLine("Product List");
            Console.WriteLine("----------");

            Console.WriteLine(Product.Header);
            Console.WriteLine("------------------");
            foreach (var category in categories)
            {
                Console.WriteLine(category );
            }
            Console.WriteLine("------------------");
        }

    }
}
