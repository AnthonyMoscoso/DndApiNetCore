using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF.DungeonsDb.Configurations
{
    public class RelationShipTypeConfig : IEntityTypeConfiguration<RelationShipType>
    {
        public void Configure(EntityTypeBuilder<RelationShipType> builder)
        {
            builder.HasKey(w=> w.IdRelationType);
            builder.Property(w => w.RelationName).IsRequired().HasMaxLength(75);
            builder.Property(w => w.Description).IsRequired();
            builder.Property(w => w.CreateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();
            builder.Property(w => w.LastUpdateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();
        }
    }
}
