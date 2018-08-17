using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyMaintenanceCertificateTypes", Schema = "property")]
    public partial class PropertyMaintenanceCertificateType
    {
        public PropertyMaintenanceCertificateType()
        {
            PropertyMaintenanceCertificates = new HashSet<PropertyMaintenanceCertificate>();
        }

        public byte Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        public byte Duration { get; set; }
        public byte RenewalNoticedRequired { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("PropertyMaintenanceCertificateType")]
        public ICollection<PropertyMaintenanceCertificate> PropertyMaintenanceCertificates { get; set; }
    }
}
