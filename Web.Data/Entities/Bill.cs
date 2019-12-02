using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill()
        {

        }
        public Bill(string )
        {

        }
        [StringLength(250)]
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual AppUser User { get; set; }
        [Required]
        [StringLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(256)]
        public String CustomerAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        [DefaultValue(Status.Active)]
        public Status status { get; set; } = Status.Active;
    }
}
