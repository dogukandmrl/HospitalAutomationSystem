using System.Data.Entity;

namespace HospitalAutomationSystem.Entity
{
    public class Context : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


}
