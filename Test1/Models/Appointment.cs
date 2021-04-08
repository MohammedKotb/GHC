namespace Test1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public int ID { get; set; }

        public int PatientID { get; set; }

        public int DocID { get; set; }

        public DateTime AppointmetDateTime { get; set; }

        public string Note { get; set; }

        [Required]
        [StringLength(10)]
        public string Accepted { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
