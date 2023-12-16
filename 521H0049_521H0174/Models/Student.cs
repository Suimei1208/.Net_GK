namespace _521H0049_521H0174.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        public string Gender { get; set; }

        public double GPA { get; set; }

        public string Status { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

    }
}
