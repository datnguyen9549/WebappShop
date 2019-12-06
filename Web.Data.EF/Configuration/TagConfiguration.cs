using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Data.EF.Extensions;
using Web.Data.Entities;

namespace Web.Data.EF.Configuration
{
    // Fluent API, config Id trong Tags class = varchar(50)
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(b => b.Id)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
