using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EFCoreOwnedEntitiesError.Entities;

namespace EFCoreOwnedEntitiesError.EntityTypeConfigurations;

internal sealed class FooEntityTypeConfiguration : IEntityTypeConfiguration<Foo>
{
    public void Configure(EntityTypeBuilder<Foo> builder)
    {
        builder.OwnsOne(foo => foo.FooStatistics, statisticsBuilder =>
        {
            statisticsBuilder.OwnsOne(statistics => statistics.Percentile25En75);
            statisticsBuilder.OwnsOne(statistics => statistics.Percentile10En90);
        });

        builder.OwnsOne(foo => foo.BarStatistics, statisticsBuilder =>
        {
            statisticsBuilder.OwnsOne(statistics => statistics.Percentile25En75);
            statisticsBuilder.OwnsOne(statistics => statistics.Percentile10En90);
        });
    }
}