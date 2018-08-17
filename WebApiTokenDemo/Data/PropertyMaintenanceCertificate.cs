using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyMaintenanceCertificates", Schema = "property")]
    public partial class PropertyMaintenanceCertificate
    {
        public PropertyMaintenanceCertificate()
        {
            PropertyMaintenanceCertificateHistories = new HashSet<PropertyMaintenanceCertificateHistory>();
        }

        public int Id { get; set; }
        public int PropertyId { get; set; }
        public byte PropertyMaintenanceCertificateTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Expires { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Issued { get; set; }
        [Required]
        [StringLength(1)]
        public string ResponsibilityOf { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        public bool InUse { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PropertyId")]
        [InverseProperty("PropertyMaintenanceCertificates")]
        public Property Property { get; set; }
        [ForeignKey("PropertyMaintenanceCertificateTypeId")]
        [InverseProperty("PropertyMaintenanceCertificates")]
        public PropertyMaintenanceCertificateType PropertyMaintenanceCertificateType { get; set; }
        [InverseProperty("PropertyMaintenanceCertificate")]
        public PropertyEnergyPerformanceCertificate PropertyEnergyPerformanceCertificate { get; set; }
        [InverseProperty("PropertyMaintenanceCertificate")]
        public ICollection<PropertyMaintenanceCertificateHistory> PropertyMaintenanceCertificateHistories { get; set; }
    }
}
