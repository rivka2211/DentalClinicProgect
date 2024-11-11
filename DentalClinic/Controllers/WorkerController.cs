using DentalClinic.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
       private static List<Worker> Workers = new List<Worker>();
        public WorkerController()
        {
            
        }
        // GET: api/<WorkerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            yield return Workers.ToString();
        }

        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return Workers.FirstOrDefault(w => w.Id == id, Workers.First()).ToString();
        }

        //GET by Profession
        [HttpGet("{profession}")]
        public string Get(ProfessionsEnum profession)
        {
             return Workers.All(w => w.Profession == profession).ToString();
        }

        // POST api/<WorkerController>
        [HttpPost]
        public void Post([FromBody] Worker w)
        {
            Workers.Add(new Worker(w.Id, w.Name, w.Profession, w.Address, w.Salary));
        }

        // PUT api/<WorkerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Worker w)
        {
            Worker worker = Workers.FirstOrDefault(w => w.Id == id);
            worker.Id = w.Id;
            worker.Name =w.Name;
            worker.Profession = w.Profession;
            worker.Address = w.Address;
            worker.Salary = w.Salary;
        }

        // DELETE api/<WorkerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Workers.Remove(Workers.FirstOrDefault(w => w.Id == id));
        }
    }
}
