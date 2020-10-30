using DockerPracticeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerPracticeCheck.Repository
{
    public class EFFlightRepository : IFlight
    {
        private static List<Flight> lst = new List<Flight>();
        public int AddFlight(Flight flight)
        {
            if(flight!=null)
            {
                lst.Add(flight);
                return 1;
            }
            return 0;
        }

        public IEnumerable<Flight> GetFlights()
        {
            return lst;
        }
    }
}
