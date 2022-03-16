using Microsoft.EntityFrameworkCore;
using MyHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHospitalSystem.Data
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Policlinic> Policlinics { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<City> Cities { get; set; }        
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4LEK61G\SQLEXPRESS; Database=HospitalSystem; Integrated Security=yes");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().Property(x => x.Address)
                                       .HasMaxLength(250); 
            modelBuilder.Entity<Patient>().Property(x => x.Name)
                                       .IsRequired()
                                       .HasMaxLength(50);  
            modelBuilder.Entity<Patient>().Property(x => x.Surname)
                                       .IsRequired()
                                       .HasMaxLength(50);



            modelBuilder.Entity<Patient>().HasOne(p => p.BloodType)
                                       .WithMany(b => b.Patients)
                                       .HasForeignKey(f => f.BloodTypeId)
                                       .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Test>().HasOne(t => t.Patient)
                                       .WithMany(p => p.Tests)
                                       .HasForeignKey(f => f.PatientId)
                                       .OnDelete(DeleteBehavior.SetNull);  
            modelBuilder.Entity<Test>().HasOne(t => t.TestType)
                                       .WithMany(p => p.Tests)
                                       .HasForeignKey(f => f.TestTypeId)
                                       .OnDelete(DeleteBehavior.SetNull); 
            modelBuilder.Entity<Appointment>().HasOne(a => a.Patient)
                                       .WithMany(p => p.Appointments)
                                       .HasForeignKey(f => f.PatientId)
                                       .OnDelete(DeleteBehavior.SetNull);   
            modelBuilder.Entity<Appointment>().HasOne(a => a.Doctor)
                                       .WithMany(p => p.Appointments)
                                       .HasForeignKey(f => f.DoctorId)
                                       .OnDelete(DeleteBehavior.SetNull);    
            modelBuilder.Entity<Doctor>().HasOne(a => a.Policlinic)
                                       .WithMany(p => p.Doctors)
                                       .HasForeignKey(f => f.PoliclinicId)
                                       .OnDelete(DeleteBehavior.SetNull);     
            modelBuilder.Entity<Policlinic>().HasOne(a => a.Town)
                                       .WithMany(p => p.Policlinics)
                                       .HasForeignKey(f => f.TownId)
                                       .OnDelete(DeleteBehavior.SetNull);    
            modelBuilder.Entity<Town>().HasOne(a => a.City)
                                       .WithMany(p => p.Towns)
                                       .HasForeignKey(f => f.CityId)
                                       .OnDelete(DeleteBehavior.SetNull);

         

        }
    }
}
