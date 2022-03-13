﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyHospitalSystem.Models
{
    public class Test
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? TestTypeId { get; set; }
        public DateTime TestDate { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public TestType TestType { get; set; }
        public Patient Patient { get; set; }
    }
}
