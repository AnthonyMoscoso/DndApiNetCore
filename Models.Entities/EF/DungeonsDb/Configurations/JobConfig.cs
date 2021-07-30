using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF.DungeonsDb.Configurations
{
    public class JobConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(w=> w.IdJob);
            builder.Property(w => w.JobTittle).IsRequired().IsUnicode().HasMaxLength(75);
            builder.Property(w => w.JobDescription).IsRequired();
            builder.Property(w => w.CreateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();
            builder.Property(w => w.LastUpdateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();

        }
    }
}
