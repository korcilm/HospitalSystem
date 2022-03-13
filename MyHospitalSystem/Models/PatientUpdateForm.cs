using Microsoft.EntityFrameworkCore;
using MyHospitalSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyHospitalSystem.Models
{
    public partial class PatientUpdateForm : Form
    {
        public PatientUpdateForm()
        {
            InitializeComponent();
        }
        HospitalDbContext context = new HospitalDbContext();
        private void PatientUpdateForm_Load(object sender, EventArgs e)
        {
            HospitalDbContext context = new HospitalDbContext();
            var allContext = context.Patients.Include(x => x.BloodType);
            var data = allContext.Select(f => new
            {
                f.Id,
                f.Name,
                f.Surname,
                f.IdentityNumber,
                f.BirthDate,
                f.Address,
                f.PhoneNumber,
                BloodType = f.BloodType.Name
            });

            var list = data.ToList();
            dgw_PatientList.DataSource = list;
        }

        private void GetPatient(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = Convert.ToInt32(dgw_PatientList.CurrentRow.Cells["Id"].Value.ToString());
            var getContext = context.Patients.Include(x => x.BloodType).Where(x => x.Id == id).FirstOrDefault();
            tbx_name.Text = getContext.Name;
            tbx_surname.Text = getContext.Surname;
            tbx_phone.Text = getContext.PhoneNumber;
            tbx_identity.Text = getContext.IdentityNumber;
            tbx_address.Text = getContext.Address;
            dt_birth.Text = getContext.BirthDate.ToString();

            var result = context.BloodTypes.ToList();
            foreach (var item in result)
            {
                cmb_bloodType.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgw_PatientList.CurrentRow.Cells["Id"].Value.ToString());
            var getContext = context.Patients.Include(x => x.BloodType).Where(x => x.Id == id).FirstOrDefault();
            getContext.Name = tbx_name.Text;
            getContext.Surname = tbx_surname.Text;
            getContext.Address = tbx_address.Text;
            getContext.IdentityNumber = tbx_identity.Text;
            getContext.BirthDate = dt_birth.Value;
            getContext.PhoneNumber = tbx_phone.Text;
            getContext.BloodTypeId = cmb_bloodType.SelectedIndex+1;

            context.Patients.Update(getContext);
            int result = context.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }
    }
}
