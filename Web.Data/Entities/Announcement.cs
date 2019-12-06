using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Announcements")]
    public class Announcement: DomainEntity<string>, IDateTracking, ISwitchable
    {
        public Announcement()
        {
            AnnouncementUsers = new List<AnnouncementUser>();
        }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Content { get; set; }
        [StringLength(450)]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
        public Status Status {get;set;}
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }
    }
}
