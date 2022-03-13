using System;
using System.Collections.Generic;
using System.Text;

namespace MyHospitalSystem.Models
{
    public class TestType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Test> Tests { get; set; }
    }
}
