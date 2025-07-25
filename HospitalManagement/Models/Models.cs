using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    // Doctor Registration
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string HighestQualification { get; set; }
        public string Specialization { get; set; }
    }

    // Employee Registration
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public DateTime EmployeeJoiningDate { get; set; }
    }

    // Appointment Scheduling
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; }
        public string PatientName { get; set; }
        public string AssignedDoctor { get; set; }
    }

    // Hospital Administration
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Location { get; set; }
    }

    // Inpatient Registration
    public class InPatient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Problem { get; set; }
        public DateTime DateOfJoining { get; set; }
    }

    // Outpatient Registration
    public class OutPatient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Problem { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfDischarge { get; set; }
    }

    // Itemized Patient Billing
    public class PatientBilling
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public decimal BillAmount { get; set; }
    }

    // Electronic Medical Records / Clinical History
    public class ClinicalHistory
    {
        public int PatientId { get; set; }
        public DateTime VisitedDate { get; set; }
    }

    
    
}