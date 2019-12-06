using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData, ISortable
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public bool? HomeFlag { get; set; }
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public string SeopageTitle {get;set;}
        public string SeoAlias {get;set;}
        public string SeoKeywords {get;set;}
        public string SeoDescription {get;set;}
        Status ISwitchable.Status {get;set;}
        int ISortable.SortOrder { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
