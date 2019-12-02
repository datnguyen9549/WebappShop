using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("AdvertistmentPosition")]
    public class AdvertisetmentPosition: DomainEntity<string>
    {
        [StringLength(50)]
        public int PositionId { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [ForeignKey("PageId")]
        public virtual AdvertistmentPage AdvertistmentPage { get; set; }
        public virtual ICollection<Advertistment> Advertistments { get; set; }
    }
}
