﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDoctors.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string numberpolicy { get; set; }
        public string numberpassport { get; set; }
        public string phone { get; set; }
        public string photourl { get; set; }
        public string residenceaddress { get; set; }
        public string placeofresidence { get; set; }

    }
}
