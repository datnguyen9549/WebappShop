using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    public class ProductTag:DomainEntity<int>
    {
        public int productId { get; set; }

        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string TagId { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag tag { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product product { get; set; }
    }
}
