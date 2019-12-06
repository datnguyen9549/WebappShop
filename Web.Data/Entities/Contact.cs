using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Data.Enums;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Contacts")]
    public class Contact: DomainEntity<string>
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Addrress { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Website { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public double? lng { get; set; }
        public double? Lat { get; set; }
        public Status Status { get; set; }
    }
}