using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel.Model
{
    public class DailyActivity
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Hour { get; set; }
        public string AdditionalNotes { get; set; }

        public int AnimalID { get; set; }
        public Animal? Animal { get; set; }
    }
}