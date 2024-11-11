namespace DentalClinic.Classes
{
    public class Room
    {
        public int Floor { get; set; }
        public int Number { get; set; }
        public int Id { get { return Floor * 100 + Number; } }
        public string Suitable { get; set; }
      
        public Room()
        {
            
        }

        public Room(int floor, int number, string suitable)
        {
            Floor = floor;
            Number = number;
            Suitable = suitable;
        }

        public override string? ToString()
        {
            return $"room number:{Number}, floor:{Floor}, suitable:{Suitable} \n";
        }
    }
}
