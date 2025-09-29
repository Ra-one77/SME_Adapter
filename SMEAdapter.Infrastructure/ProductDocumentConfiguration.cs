using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMEAdapter.Domain.Entities;   



namespace SMEAdapter.Infrastructure
{
    public class ProductDocumentConfiguration : IEntityTypeConfiguration<ProductDocument>
    {
        public void Configure(EntityTypeBuilder<ProductDocument> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.FileName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(d => d.ContentType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.Data)
            .HasColumnType("varbinary(max)");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.Documents)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.OwnsOne(d => d.Version, v =>
            {
                v.Property(x => x.Language).HasMaxLength(50);
                v.Property(x => x.Version).HasMaxLength(50);
                v.Property(x => x.Title).HasMaxLength(255);
                v.Property(x => x.Summary);
                v.Property(x => x.Keywords);
                v.Property(x => x.State).HasMaxLength(50);
                v.Property(x => x.StateDate);
                v.Property(x => x.OrganisationName).HasMaxLength(200);
                v.Property(x => x.OrganisationOfficialName).HasMaxLength(200);
            });

            builder.OwnsOne(d => d.Identifier, i =>
            {
                i.Property(x => x.ValueId).HasMaxLength(100);
                i.Property(x => x.DomainId).HasMaxLength(100);
            });

            builder.OwnsOne(d => d.Classification, c =>
            {
                c.Property(x => x.ClassificationSystem).HasMaxLength(100);
                c.Property(x => x.ClassName).HasMaxLength(100);
                c.Property(x => x.ClassLang).HasMaxLength(50);
                c.Property(x => x.ClassDescription).HasMaxLength(255);
                c.Property(x => x.ClassId).HasMaxLength(100);
            });
        }
    }
}
