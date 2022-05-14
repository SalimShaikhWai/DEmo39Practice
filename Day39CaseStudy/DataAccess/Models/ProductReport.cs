using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39CaseStudy.DataAccess.Models
{
    public class ProductReport
    {
       
       
        [Key]
        public int ProductId { get; set; }  
        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        public short ModelYear { get; set; }

        public decimal ListPrice { get; set; }

        public static string Header => "ProductId, ProductName, BrandName, CategoryName, ModelYear, ListPrice";



    }
}
