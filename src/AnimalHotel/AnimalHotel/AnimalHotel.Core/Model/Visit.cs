﻿using AnimalHotel.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel.Model
{
    public class Visit
    {
        public int ID { get; set; }
        public Animal? Animal { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        //public Status? Status { get; set; }
    }
}