﻿using DentalClinic.Classes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        static private List<Room> Rooms = new List<Room>();
        public RoomController()
        {
            
        }

        // GET: api/<RoomController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            yield return ""+Rooms.ToString();
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return ""+Rooms.FirstOrDefault(r => r.Id == id, Rooms.First()).ToString(); 
        }

        /*//GET by floor
       [HttpGet("{floor}")]
       public string Get(int floor)
       {
           return ""+Rooms.All(r => r.Floor == floor).ToString();
       }*/

        //GET by suitabe
        [HttpGet("{suitable}")]
        public string Get(string suitable)
        {
            return "" + Rooms.All(r => r.Suitable== suitable).ToString();
        }

        // POST api/<RoomController>
        [HttpPost]
        public void Post([FromBody] Room r)
        {
            Rooms.Add(new Room(r.Floor,r.Number,r.Suitable));
        }

        // PUT api/<RoomController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Room r)
        {
            Room room = Rooms.FirstOrDefault(r => r.Id == id);
            room.Number = r.Number;
            room.Floor = r.Floor;
            room.Suitable = r.Suitable;
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Rooms.Remove(Rooms.FirstOrDefault(r => r.Id == id));
        }
    }
}
