using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage: DomainEntity<string>
    {
        [StringLength(250)]
        public string Name { get; set; }
        public virtual ICollection<AdvertisetmentPosition> AdvertisetmentPositions { get; set; }
    }
}
