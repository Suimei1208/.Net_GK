namespace _521H0049_521H0174.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Certificate
    {
        public int CertificateID { get; set; }

        public int? StudentID { get; set; }

        [Required]
        [StringLength(100)]
        public string CertificateName { get; set; }
    }
}
