using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day39CaseStudy.DataAccess.Models;

[Table("brands", Schema = "production")]
public class Brand
{    
    [Key]
    [Column("brand_id")]    
    public int? BrandId { get; set; }       // Check why this worked without ?.

    [Column("brand_name")]
    public string BrandName { get; set; }

    public List<Product> Products { get; set; }
    public static string Header => "BrandId, BrandName";

    public override string ToString()
    {
        return $"{BrandId ,13 },{BrandName,33}  {Products.Count,10}";
    }
}
