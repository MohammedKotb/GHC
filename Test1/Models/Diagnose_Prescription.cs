namespace Test1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Diagnose_Prescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnose_Prescription()
        {
            Prescription_Medicine = new HashSet<Prescription_Medicine>();
        }

        [Key]
        public int PrescriptionID { get; set; }

        public int DiagnoseID { get; set; }

        public virtual Diagnose Diagnose { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription_Medicine> Prescription_Medicine { get; set; }
    }
}
