using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Data.Entities
{
    [Table("AppRoles")]
    class AppRole : IdentityRole<Guid>
    {
        public AppRole(): base()
        {

        }
        public AppRole(string name, string description):base(name)
        {
            this.Discription = description;
        }
        public string Discription { get; set; }
    }
}
