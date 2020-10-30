using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerPracticeCheck.Models;
using DockerPracticeCheck.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerPracticeCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        public IFlight repo;
        public FlightController(IFlight repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        [Route("GetAllFlights")]
        public IActionResult GetAllFlights()
        {
            try
            {
                var flights = repo.GetFlights().ToList();
                if (flights.Count == 0)
                {
                    return BadRequest("No Flights");
                }
                return Ok(flights);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("AddFlight")]
        public IActionResult AddFlight([FromBody]Flight flight)
        {
            try
            {
                var res = repo.AddFlight(flight);
                if (res == 0)
                {
                    return BadRequest();
                }
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}