
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

        public override bool Equals(object? obj)
        {
            return obj is Room room &&
                   Floor == room.Floor &&
                   Number == room.Number &&
                   Id == room.Id &&
                   Suitable == room.Suitable;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Floor, Number, Id, Suitable);
        }
    }
}
