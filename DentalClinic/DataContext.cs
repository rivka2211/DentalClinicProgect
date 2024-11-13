using DentalClinic.Classes;

namespace DentalClinic
{
    public class DataContext
    {
         public List<Client> Clients { get; set; }
         public List<Room> Rooms { get; set; }
         public List<Worker> Workers { get; set; }
         public List<Appointment> Appointments { get; set; }

        public DataContext()
        {
            DateOnly dd = new DateOnly(2000, 10, 23);
            Client c1 = new Client(123, "rivki", "bb", MedicalInsuranceEnum.Klalit,dd);
            Clients = new List<Client>();
            Clients.Add(c1);
            Rooms = new List<Room>();
            Workers = new List<Worker>();
            Appointments = new List<Appointment>();
            Appointment a1 = new Appointment(dd, new TimeOnly(), new Worker(), c1, new Room(), 20);
            Appointments.Add(a1);
        }
    }
}
