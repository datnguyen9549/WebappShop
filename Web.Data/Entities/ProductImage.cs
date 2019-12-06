using System.ComponentModel.DataAnnotations.Schema;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("ProductImages")]
    public class ProductImage: DomainEntity<int>
    {
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public string Path { get; set; }
        public string Caption { get; set; }
    }
}