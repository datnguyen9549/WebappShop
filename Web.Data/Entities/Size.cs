using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Sizes")]
    public class Size: DomainEntity<int>
    {
        [StringLength(250)]
        public string Name { get; set; }
    }
}