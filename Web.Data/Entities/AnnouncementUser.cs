using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("AnnouncementUser")]
    public class AnnouncementUser: DomainEntity<int>
    {
        [StringLength(450)]
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
        public bool? HasRead { get; set; }
        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }
        [ForeignKey("AnnouncementId")]
        public virtual Announcement Announcement { get; set; }
    }
}
