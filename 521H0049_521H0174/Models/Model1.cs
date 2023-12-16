using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _521H0049_521H0174.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=StudentsInformation")
        {
        }

        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<LoginHistory> LoginHistories { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CertificateStudentList> CertificateStudentList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
