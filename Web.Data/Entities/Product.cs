using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData, ISortable
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int ParentId { get; set; }
        public string Alias { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        [Required]
        [DefaultValue(0)]
        public int Price { get; set; }
        public int PromotionPrice { get; set; }
        [Required]
        public int OriginalPrice { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [StringLength(255)]
        public string Tag { get; set; }
        [StringLength(255)]
        public string Unit { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
        public Status status {get;set;}
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public string SeopageTitle {get;set;}
        public string SeoAlias {get;set;}
        public string SeoKeywords {get;set;}
        public string SeoDescription {get;set;}
        int ISortable.SortOrder { get ; set ; }
    }
}
