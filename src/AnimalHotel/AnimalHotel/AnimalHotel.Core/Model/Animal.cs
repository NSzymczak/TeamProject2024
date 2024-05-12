namespace AnimalHotel.Model;

public class Animal
{
    public int ID { get; set; }
    public string? Name { get; set; }

    public Details? Details { get; set; }
    public FeedingRules? FeedingRules { get; set; }
    public Health? Health { get; set; }
    public WalksRules? WalkRules { get; set; }

    public Owner? Owner { get; set; }

    public List<Visit> Visits { get; set; }
}