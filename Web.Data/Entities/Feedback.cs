using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback : DomainEntity<int>, IDateTracking, ISwitchable
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Phone { get; set; }
        [StringLength(550)]
        public string Message { get; set; }
        public Status Status {get; set;}
        public DateTime DateCreated {get; set;}
        public DateTime DateModified {get; set;}
    }
}