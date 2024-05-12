namespace AnimalHotel.Model
{
    public class Details
    {
        public int ID { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public int AnimalID { get; set; }
        public Animal Animal { get; set; }
    }
}