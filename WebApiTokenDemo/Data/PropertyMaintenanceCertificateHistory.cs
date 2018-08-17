using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyMaintenanceCertificateHistory", Schema = "property")]
    public partial class PropertyMaintenanceCertificateHistory
    {
        public int PropertyMaintenanceCertificateId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Expires { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Issued { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        public int Id { get; set; }

        [ForeignKey("PropertyMaintenanceCertificateId")]
        [InverseProperty("PropertyMaintenanceCertificateHistories")]
        public PropertyMaintenanceCertificate PropertyMaintenanceCertificate { get; set; }
    }
}
