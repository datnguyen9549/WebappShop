using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Footers")]
    public class Footer: DomainEntity<int>
    {
        [Required]
        public string Content { get; set; }
    }
}