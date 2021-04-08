namespace Test1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Analysis
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public DateTime? DateAndTime { get; set; }

        public int PatientID { get; set; }

        public int DocID { get; set; }

        [Required]
        public string Report { get; set; }

        public string Note { get; set; }

        [Required]
        public string AttachURL { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
