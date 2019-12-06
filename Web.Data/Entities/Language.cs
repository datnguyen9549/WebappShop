using System.ComponentModel.DataAnnotations.Schema;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Languages")]
    public class Language: DomainEntity<int>, ISwitchable
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public Status Status { get; set; }
    }
}