using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF.DungeonsDb.Configurations
{
    public class RelationShipConfig : IEntityTypeConfiguration<RelationShip>
    {
        public void Configure(EntityTypeBuilder<RelationShip> builder)
        {
            builder.HasKey(w => w.IdRelation);
            builder.HasOne(w => w.RelationType).WithMany(w => w.RelationShip).HasForeignKey(w=> w.IdRelationType).IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Property(w => w.CreateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();
            builder.Property(w => w.LastUpdateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();


        }
    }
}
