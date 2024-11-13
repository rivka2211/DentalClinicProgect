using DentalClinic.Classes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly DataContext _context = new DataContext();

        public AppointmentController()
        {

        }

        // GET: api/<AppointmentController>
        [HttpGet]
        public List<Appointment> Get()
        {
            return _context.Appointments;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{code}")]
        public ActionResult Get(int code)
        {
            Appointment a = _context.Appointments.Find(c => c.Code == code);
            if (a is null)
                return NotFound();
            return Ok(a);
        }

        //[HttpGet("{client}")]
        //public ActionResult Get(Client client)
        //{
        //    List<Appointment> a = _context.Appointments.FindAll(a => a.Client == client);
        //    if (a is null)
        //        return NotFound();
        //    return Ok(a);
        //}

        [HttpGet("{date}")]
        public ActionResult Get(DateOnly? date, TimeOnly? time, Worker? worker, Room? room, Client client)
        {
            List<Appointment> ap = _context.Appointments;
            string s = "";
            if (date != null)
            {
                ap = ap.FindAll(a => a.Date.Equals(date));
                s += " date,";
            }

            if (time != null)
            {
                ap = ap.FindAll(a => a.Time.Equals(time));
                s += " time,";
            }
            if (worker != null)
            {
                ap = ap.FindAll(a => a.Worker.Equals(worker));
                s += " worker,";
            }
            if (room != null)
            {
                ap = ap.FindAll(a => a.Room.Equals(room));
                s += " room,";
            }
            if (client != null)
            {
                ap = ap.FindAll(a => a.Client.Equals(client));
                s += " client,";
            }
            if (ap.First() == null)
                return NotFound("did not found an object that fit in all" + s + "\b");
            Console.WriteLine("search of all this: " + s + "\b");
            return Ok(ap);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public ActionResult Post([FromBody] Appointment ap)
        {
            _context.Appointments.Add(new Appointment(ap.Date, ap.Time, ap.Worker, ap.Client, ap.Room, ap.Duration, ap.FirstAid));
            return Ok("The object was successfully added");
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{code}")]
        public ActionResult Put(int code, [FromBody] Appointment value)
        {
            var ap = _context.Appointments.Find(c => c.Code == code);
            if (ap == null)
                return NotFound();
            if (ap.Equals(value))
                return Ok("same");
            ap.Date = value.Date;
            ap.Time = value.Time;
            ap.Room = value.Room;
            ap.Worker = value.Worker;
            ap.Client = value.Client;
            ap.Duration = value.Duration;
            ap.FirstAid = value.FirstAid;
            return Ok("The object has been successfully updated");
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{code}")]
        public ActionResult Delete(int code)
        {
            var ap = _context.Appointments.Find(c => c.Code == code);
            if (ap == null)
                return NotFound();
            return Ok("The object was successfully deleted");
        }
    }
}
