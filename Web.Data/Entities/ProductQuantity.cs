using System;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("ProductQuantitys")]
    public class ProductQuantity : DomainEntity<int>, IDateTracking
    {
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public int ProductSize { get; set; }
        [ForeignKey("ProductSize")]
        public virtual Size Size { get; set; }
        public string ColorId { get; set; }
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}