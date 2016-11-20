namespace ControlAccesoMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CA_Personas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_Personas()
        {
            CA_RegistroVisitas = new HashSet<CA_RegistroVisitas>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; }

        [StringLength(50)]
        public string SegundoApellido { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime? FechaBaja { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_RegistroVisitas> CA_RegistroVisitas { get; set; }
    }
}
