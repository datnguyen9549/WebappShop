using System;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    public class Color: DomainEntity<int>
    {
        public String Name { get; set; }
        public string Code { get; set; }
    }
}