namespace ControlAccesoMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAT_AreasVisita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_AreasVisita()
        {
            CA_RegistroVisitas = new HashSet<CA_RegistroVisitas>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Area { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_RegistroVisitas> CA_RegistroVisitas { get; set; }
    }
}
