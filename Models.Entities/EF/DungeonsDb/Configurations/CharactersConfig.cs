using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.EF.DungeonsDb.Configurations
{
    public class CharactersConfig : IEntityTypeConfiguration<Characters>
    {
        public void Configure(EntityTypeBuilder<Characters> builder)
        {
            builder.HasKey(w => w.IdCharacter);
            builder.Property(w => w.CharacterType).HasColumnType("TinyInt");
            builder.Property(w => w.Name).IsRequired().HasMaxLength(75); 
            builder.Property(w => w.Details).IsRequired();
            builder.Property(w => w.CreateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();
            builder.Property(w => w.LastUpdateDate).HasColumnType("DateTime").HasDefaultValueSql("getDate()").IsRequired();
            builder.HasOne(w => w.Job).WithMany(w=> w.Characters).HasForeignKey(t=> t.IdJob).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(w => w.RelationShip).WithOne(w => w.Character).HasForeignKey(w=> w.IdCharacter);
            builder.HasMany(w => w.RelationShip1).WithOne(w => w.Character1).HasForeignKey(w => w.IdCharacter1).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
