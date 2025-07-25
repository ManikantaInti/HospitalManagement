using HospitalManagement.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement
{
    
        public class HospitalContext :DbContext
        {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        { }
       
            public DbSet<Doctor> Doctors { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Appointment> Appointments { get; set; }
            public DbSet<Hospital> Hospitals { get; set; }
            public DbSet<InPatient> InPatients { get; set; }
            public DbSet<OutPatient> OutPatients { get; set; }
            public DbSet<PatientBilling> PatientBillings { get; set; }
            public DbSet<ClinicalHistory> ClinicalHistories { get; set; }
        }
    }

