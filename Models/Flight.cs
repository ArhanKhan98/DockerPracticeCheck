using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DockerPracticeCheck.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public string ToLocation { get; set; }
        public string FromLocation { get; set; }
        public double Price { get; set; }
    }
}
