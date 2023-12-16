using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _521H0049_521H0174.Models
{
    public class CertificateStudentList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }

        [ForeignKey("Certificate")]
        public int CertificateID { get; set; }

        public virtual Certificate Certificate { get; set; }

    }
}
