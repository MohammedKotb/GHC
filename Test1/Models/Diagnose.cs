namespace Test1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diagnose")]
    public partial class Diagnose
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnose()
        {
            Diagnose_Prescription = new HashSet<Diagnose_Prescription>();
        }

        public int ID { get; set; }

        public DateTime DiagnoseDateTime { get; set; }

        [Required]
        public string DiagnoseDescription { get; set; }

        [StringLength(50)]
        public string RequiredRadiation { get; set; }

        [StringLength(50)]
        public string RequiredAnalyses { get; set; }

        public int PatientID { get; set; }

        public int DocID { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnose_Prescription> Diagnose_Prescription { get; set; }
    }
}
