using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("AppUser")]
    public class AppUser : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public String Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public int Balance { get; set; }
        public string Avatar { get; set; }
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public Status status {get;set;}
    }
}
