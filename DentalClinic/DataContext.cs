using DentalClinic.Classes;

namespace DentalClinic
{
    public class DataContext
    {
         public List<Client> Clients { get; set; }
         public List<Room> Rooms { get; set; }
         public List<Worker> Workers { get; set; }

        public DataContext()
        {
            Client c1 = new Client(123, "rivki", "bb", MedicalInsuranceEnum.Klalit, new DateOnly(2000, 10, 23));
            Clients = new List<Client>();
            Clients.Add(c1);
            Rooms = new List<Room>();
            Workers = new List<Worker>();
        }
    }
}
