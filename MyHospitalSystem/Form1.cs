using Microsoft.EntityFrameworkCore;
using MyHospitalSystem.Data;
using MyHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHospitalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HospitalDbContext context = new HospitalDbContext();
            context.Database.EnsureCreated();

            var allContext = context.Patients.Include(x => x.BloodType);


            var data = allContext.Select(f => new
            {
                Name=f.Name +" " + f.Surname,
                f.IdentityNumber,
                f.BirthDate,
                f.Address,
                f.PhoneNumber,
                BloodType = f.BloodType.Name
            });

            var list = data.ToList();
            dgw_ListPatient.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientAddForm patientAddForm = new PatientAddForm();
            patientAddForm.Show();
        }

        private void dgw_ListPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            PatientUpdateForm patientAddForm = new PatientUpdateForm();
            patientAddForm.Show();
        }
    }
}
