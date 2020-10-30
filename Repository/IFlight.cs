using DockerPracticeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerPracticeCheck.Repository
{
   public interface IFlight
    {
        public IEnumerable<Flight> GetFlights();
        public int AddFlight(Flight flight);
    }
}
