using EFCoreOwnedEntitiesError.Entities;

namespace EFCoreOwnedEntitiesError;

internal class Program
{
    private static void Main(string[] args)
    {
        TestFoo();
    }

    private static void TestFoo()
    {
        var percentileRange = new PercentileRange
        {
            Low = 1,
            High = 2,
        };

        var statistics = new Statistics
        {
            Median = 99,
            Percentile25En75 = percentileRange,
            Percentile10En90 = percentileRange,
        };

        var foo = new Foo
        {
            FooStatistics = statistics,
            BarStatistics = statistics,
        };

        using var context2 = new TestDbContext();
        {
            context2.Foos.Add(foo);

            // SaveChanges throws:
            //System.InvalidOperationException: 'Cannot save instance of 'Foo.BarStatistics#Statistics.Percentile25En75#PercentileRange' because it is an owned entity without any reference to its owner. Owned entities can only be saved as part of an aggregate also including the owner entity.'
            context2.SaveChanges();
        }
    }
}