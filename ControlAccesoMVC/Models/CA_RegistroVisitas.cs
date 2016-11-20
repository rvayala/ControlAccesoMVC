namespace ControlAccesoMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CA_RegistroVisitas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? IdPersona { get; set; }

        public long? IdAreaVisitada { get; set; }

        public DateTime? FechaAcceso { get; set; }

        public DateTime? FechaSalida { get; set; }

        [StringLength(100)]
        public string MotivoVisita { get; set; }

        public virtual CA_Personas CA_Personas { get; set; }

        public virtual CAT_AreasVisita CAT_AreasVisita { get; set; }
    }
}
