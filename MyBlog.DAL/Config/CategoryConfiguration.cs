using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DAL.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.CategoryName)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(x => x.Description)
                .IsRequired(false);
        }
    }
}
