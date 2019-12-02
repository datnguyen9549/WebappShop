using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Data.EF.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, DbEntityConfiguration<TEntity> configuration)
            where TEntity : class
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
            //modelBuilder.Entity<TEntity>(configuration.Configure);
        }
    }
    public abstract class DbEntityConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> entity);
    }
}
