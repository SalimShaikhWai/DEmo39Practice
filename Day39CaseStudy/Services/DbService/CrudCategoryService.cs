using Day39CaseStudy.DataAccess;
using Day39CaseStudy.DataAccess.Models;
using Day39CaseStudy.Services.DbService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39CaseStudy.Services.DbService
{
    internal class CrudCategoryService : ICrudService<Category>
    {
        public void Add(Category category)
        {
           
                using var context = new SampleStoreDbContext();

                context.Categories.Add(category);
                context.SaveChanges();
            
        }

        public void Delete(int categoryId)
        {
            using var context = new SampleStoreDbContext();

            var category = (from c in context.Categories
                         where c.CategoryId == categoryId
                         select c).FirstOrDefault();

            if (category == null)
            {
                Console.WriteLine($"BrandId {categoryId} not found");
                return;
            }

            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            using var context = new SampleStoreDbContext();
            var data = from c in context.Categories.ToList()
                       select c; //chnage method to Expression

            return data;
        }

        public Category GetByName(string categoryName)
        {
            using var context = new SampleStoreDbContext();

            var category = (from b in context.Categories.ToList()
                         where b.CategoryName == categoryName
                            select b).FirstOrDefault();



            //context.Brands.SingleOrDefault(b => b.BrandName == brandName);
            return category;
        }

        public void Update(Category category)
        {
            using var context = new SampleStoreDbContext();
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}
