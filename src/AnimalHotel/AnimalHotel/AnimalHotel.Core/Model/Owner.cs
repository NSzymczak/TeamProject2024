namespace AnimalHotel.Model;

public class Owner
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }

    public List<Animal> Animals { get; set; }
}