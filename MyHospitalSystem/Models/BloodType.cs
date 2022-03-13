using System;
using System.Collections.Generic;
using System.Text;

namespace MyHospitalSystem.Models
{
    public class BloodType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
