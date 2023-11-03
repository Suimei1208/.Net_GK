namespace _521H0049_521H0174.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginHistory")]
    public partial class LoginHistory
    {
        public int LoginHistoryID { get; set; }

        public int? UserID { get; set; }

        public DateTime? LoginTime { get; set; }
    }
}
