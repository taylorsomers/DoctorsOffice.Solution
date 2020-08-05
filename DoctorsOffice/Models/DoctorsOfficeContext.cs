using Microsoft.EntityFrameworkCore;

namespace DoctorsOffice.Models
{
  public class DoctorsOfficeContext : DbContext
  {
    public DbSet<Patient> Patients { get; set; }
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }

    public DoctorsOfficeContext(DbContextOptions options) : base(options) { }
  }
}
