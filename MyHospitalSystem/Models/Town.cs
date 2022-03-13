using System;
using System.Collections.Generic;
using System.Text;

namespace MyHospitalSystem.Models
{
    public class Town
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public List<Policlinic> Policlinics { get; set; }
    }
}
