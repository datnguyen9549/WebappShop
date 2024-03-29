﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Advertistments")]
    public class Advertistment : DomainEntity<int>, ISwitchable, ISortable, IDateTracking
    {
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        [StringLength(250)]
        public string Url { get; set; }
        [StringLength(20)]
        public string PositionId { get; set; }
        public int SortOrder {get;set;}
        public Status Status {get;set;}
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        [ForeignKey("PositionId")]
        public virtual AdvertisetmentPosition AdvertisetmentPosition { get; set; }
    }
}
