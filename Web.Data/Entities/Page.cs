using System.ComponentModel.DataAnnotations.Schema;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Pages")]
    public class Page: DomainEntity<int>, ISwitchable
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public Status Status {get; set;}
    }
}