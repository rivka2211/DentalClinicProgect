using DentalClinic.Classes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DataContext _context = new DataContext();
        public ClientController()
        {
            
        }
        // GET: api/<Client>
        [HttpGet]
        public List<Client> Get()
        {
            return _context.Clients;
        }

        // GET api/<Client>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return ""+ _context.Clients.Find(c=>c.Id==id).ToString();
        }

        //GET by medicalInsurance
        [HttpGet("{medicalInsurance}")]
        public string Get(MedicalInsuranceEnum medicalInsurance)
        {
            return "" + _context.Clients.All(c => c.MedicalInsurance == medicalInsurance).ToString();
        }
        // POST api/<Client>
        [HttpPost]
        public void Post([FromBody] Client c)
        {
            _context.Clients.Add(new Client(c.Id, c.Name, c.Address, c.MedicalInsurance, c.BirthDate));
        }

        // PUT api/<Client>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client c)
        {
            Client client =_context.Clients.FirstOrDefault(c => c.Id == id);
            client.Id = c.Id;
            client.Name = c.Name;
            client.Address = c.Address;
            client.MedicalInsurance = c.MedicalInsurance;
            client.BirthDate = c.BirthDate;
        }

        // DELETE api/<Client>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _context.Clients.Remove(_context.Clients.FirstOrDefault(c => c.Id == id));
        }
    }
}
