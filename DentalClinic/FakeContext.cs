using DentalClinic.Classes;

namespace DentalClinic
{
    public class FakeContext
    {
        public List<Client> Clients { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Worker> Workers { get; set; }

        public FakeContext()
        {
            Clients = new List<Client>();
            Rooms = new List<Room>();
            Workers = new List<Worker>();
        }
    }
}
