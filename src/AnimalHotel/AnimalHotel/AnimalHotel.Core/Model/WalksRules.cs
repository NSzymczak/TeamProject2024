using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel.Model
{
    public class WalksRules
    {
        public int ID { get; set; }
        public string Hours { get; set; }
        public int Length { get; set; }
        public int AnimalID { get; set; }
        public Animal Animal { get; set; }
    }
}