namespace Test1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prescription_Medicine
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrescriptionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedicineID { get; set; }

        [StringLength(50)]
        public string Dose { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public virtual Diagnose_Prescription Diagnose_Prescription { get; set; }

        public virtual Medicine Medicine { get; set; }
    }
}
