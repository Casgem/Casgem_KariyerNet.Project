using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Concrete.Context
{
    public class KariyerNetDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-SUUA4BNC\\MSSQL; Initial Catalog = CasgemKariyerNetDB; Integrated Security = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EducationInformation>()
            .HasOne(a => a.User)
            .WithOne(a => a.EducationInformation)
            .HasForeignKey<User>(c => c.EducationInformationId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkExperience>()
            .HasOne(a => a.JobAdvertisement)
            .WithOne(a => a.WorkExperience)
            .HasForeignKey<JobAdvertisement>(c => c.WorkExperienceId)
            .OnDelete(DeleteBehavior.Restrict);

         

        }

        public DbSet<Company> Companies { get; set; } //Şirketler tablosu.
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; } //CV tablosu.
     
        public DbSet<EducationInformation> EducationInformations { get; set; }//Eğitim bilgileri.
        public DbSet<User> Users { get; set; }
       
     
       
        public DbSet<JobAdvertisement> JobAdvertisements { get; set; }//iş ilanları tablosu.
        public DbSet<JobApplication> JobApplications { get; set; } //iş başvuruları tablosu.
      
       
        //iş ilanında yayınlanan iş verenler tarafından istenilen ve beklenen iş deneyimleri tablosudur.
        public DbSet<WorkExperience> WorkExperiences { get; set; }
    }


}