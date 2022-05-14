using Day39CaseStudy.DataAccess;
using Day39CaseStudy.DataAccess.Models;
using Day39CaseStudy.Services.DbService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Day39CaseStudy.Services.DbService;

public class CrudBrandService : ICrudService<Brand>
{
    public void Add(Brand brand)
    {
        using var context = new SampleStoreDbContext();

        context.Brands.Add(brand);
        context.SaveChanges();
    }

    public IEnumerable<Brand> GetAll()
    {
        using var context = new SampleStoreDbContext();
        var data = (from b in context.Brands
                   select b).Include("Products"); //chnage method to Expression
                 
        return data.ToList();
    }

    public void Update(Brand brand)
    {
        using var context = new SampleStoreDbContext();

        context.Brands.Update(brand);
        context.SaveChanges();
    }

    public Brand GetByName(string brandName)
    {
        using var context = new SampleStoreDbContext();

        var brand = (from b in context.Brands.ToList() 
                     where b.BrandName == brandName 
                     select b).FirstOrDefault();
        
        
    
            //context.Brands.SingleOrDefault(b => b.BrandName == brandName);
        return  brand; 
    }

    public void Delete(int brandId)
    {
        using var context = new SampleStoreDbContext();

        var brand = (from b in context.Brands
                    where b.BrandId==brandId
                    select b).FirstOrDefault();

        if (brand == null)
        {
            Console.WriteLine($"BrandId {brandId} not found");
            return;
        }

        context.Brands.Remove(brand);
        context.SaveChanges();
    }
}
