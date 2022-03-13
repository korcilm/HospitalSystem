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
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4LEK61G\SQLEXPRESS; Database=HospitalSystemDb; Integrated Security=yes");

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

            modelBuilder.Entity<BloodType>().HasData(new BloodType { Id = 1, Name = "0" });
            modelBuilder.Entity<BloodType>().HasData(new BloodType { Id = 2, Name = "AB" });
            modelBuilder.Entity<BloodType>().HasData(new BloodType { Id = 3, Name = "A" });
            modelBuilder.Entity<BloodType>().HasData(new BloodType { Id = 4, Name = "B" });

            modelBuilder.Entity<City>().HasData(new City {Id=1,  Name = "Kocaeli" });
            modelBuilder.Entity<Town>().HasData(new Town { Id = 1, Name = "Gebze",CityId=1 });
            modelBuilder.Entity<Town>().HasData(new Town { Id = 2, Name = "İzmit",CityId=1 });
            modelBuilder.Entity<Town>().HasData(new Town { Id = 3, Name = "Darıca",CityId=1 });
            modelBuilder.Entity<Policlinic>().HasData(new Policlinic { Id = 1, Name = "Kulak Burun Boğaz (KBB)",TownId=1});
            modelBuilder.Entity<Policlinic>().HasData(new Policlinic { Id = 2, Name = "Dahiliye",TownId=1});
            modelBuilder.Entity<Policlinic>().HasData(new Policlinic { Id = 3, Name = "Genel Cerrahi",TownId=1});
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = 1, Name = "Hasan",Surname="Tahsin",PhoneNumber="15215451151",Address="FSM mah 375 sok no:7",PoliclinicId=1});
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = 2, Name = "Mehmet",Surname="Kara",PhoneNumber="764451151",Address="Mutlu mah 372 sok no:17",PoliclinicId=2});
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = 3, Name = "Aylin",Surname="Yıldız",PhoneNumber="232351151",Address="Papatya mah Çiçek sok no:28",PoliclinicId=3});
           
            modelBuilder.Entity<Patient>().HasData(new Patient { Id = 1, Name = "Muhammet",Surname="Korçil",PhoneNumber="5412351151",Address="Atatürk mah 202 sok no:28",BloodTypeId=2});
            modelBuilder.Entity<Patient>().HasData(new Patient { Id = 2, Name = "Ahmet",Surname="Taşkın",PhoneNumber="535511151",Address= "FSM mah 156 sok no:28", BloodTypeId=1});
           

        }
    }
}
