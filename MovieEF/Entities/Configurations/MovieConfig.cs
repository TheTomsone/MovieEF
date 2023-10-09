using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEF.Entities.Configurations
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable(nameof(Movie));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasIndex(x => x.Title).IsUnique();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);

            builder.Property(x => x.ReleaseDate).IsRequired();
            builder.HasCheckConstraint("CK_Year", "ReleaseDate > 1975");

            builder.Property(x => x.Maker).IsRequired().HasMaxLength(100);

            builder.Property(x => x.MainActor).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Genre).IsRequired().HasMaxLength(100);
        }
    }
}
