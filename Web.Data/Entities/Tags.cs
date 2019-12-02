using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    public class Tags: DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}
