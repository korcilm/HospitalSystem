using MyHospitalSystem.Data;
using MyHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyHospitalSystem
{
    public partial class PatientAddForm : Form
    {
        public PatientAddForm()
        {
            InitializeComponent();
        }
        HospitalDbContext context = new HospitalDbContext();

        private void PatientAddForm_Load(object sender, EventArgs e)
        {
            var result = context.BloodTypes.ToList();
            foreach (var item in result)
            {
                cmb_bloodType.Items.Add(item.Name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var bloodTypeId = context.BloodTypes.Where(x => x.Name == .ToString()).ToList();
            Patient patient = new Patient
            {
                Name = tbx_name.Text,
                Surname = tbx_surname.Text,
                Address=tbx_address.Text,
                IdentityNumber=tbx_identity.Text,
                BirthDate=dt_birth.Value,
                PhoneNumber=tbx_phone.Text,
                BloodTypeId= cmb_bloodType.SelectedIndex
            };

            context.Patients.Add(patient);
            int result = context.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);

        }

        
    }
}
