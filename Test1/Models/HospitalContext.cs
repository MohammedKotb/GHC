using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Test1.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
            : base("name=HospitalContext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Analysis> Analyses { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<Diagnose_Prescription> Diagnose_Prescription { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Radiation> Radiations { get; set; }
        public virtual DbSet<Prescription_Medicine> Prescription_Medicine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Position)
                .IsFixedLength();

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Accepted)
                .IsFixedLength();

            modelBuilder.Entity<Diagnose>()
                .HasMany(e => e.Diagnose_Prescription)
                .WithRequired(e => e.Diagnose)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Diagnose_Prescription>()
                .HasMany(e => e.Prescription_Medicine)
                .WithRequired(e => e.Diagnose_Prescription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Analyses)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.DocID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.DocID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Chats)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.DocID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Diagnoses)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.DocID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Radiations)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.DocID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.Prescription_Medicine)
                .WithRequired(e => e.Medicine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Analyses)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.PatientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.PatientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Chats)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.PatientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Diagnoses)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.PatientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Radiations)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.PatientID)
                .WillCascadeOnDelete(false);
        }
    }
}
