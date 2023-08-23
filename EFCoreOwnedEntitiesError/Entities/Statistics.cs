namespace EFCoreOwnedEntitiesError.Entities;

public class Statistics
{
    public PercentileRange Percentile25En75 { get; set; }

    public PercentileRange Percentile10En90 { get; set; }

    public double Median { get; set; }
}