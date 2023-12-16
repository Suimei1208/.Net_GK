namespace _521H0049_521H0174.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Certificate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificateID { get; set; }

        [Required]
        [StringLength(100)]
        public string CertificateName { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }
    }
}
