using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel.Model
{
    public class Health
    {
        public int ID { get; set; }
        public string HealthStatus { get; set; }
        public DateTime Vaccination { get; set; }
        public string AdditionalNotes { get; set; }
        public int AnimalID { get; set; }
        public Animal Animal { get; set; }
    }
}