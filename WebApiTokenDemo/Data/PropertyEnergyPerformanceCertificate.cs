using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyEnergyPerformanceCertificates", Schema = "property")]
    public partial class PropertyEnergyPerformanceCertificate
    {
        [Key]
        public int PropertyMaintenanceCertificateId { get; set; }
        [StringLength(50)]
        public string Ref { get; set; }
        public byte? EnergyEfficiencyRatingCurrent { get; set; }
        public byte? EnergyEfficiencyRatingPotential { get; set; }
        [Column("EnvironmentImpactCO2RatingCurrent")]
        public byte? EnvironmentImpactCo2ratingCurrent { get; set; }
        [Column("EnvironmentImpactCO2RatingPotential")]
        public byte? EnvironmentImpactCo2ratingPotential { get; set; }

        [ForeignKey("PropertyMaintenanceCertificateId")]
        [InverseProperty("PropertyEnergyPerformanceCertificate")]
        public PropertyMaintenanceCertificate PropertyMaintenanceCertificate { get; set; }
    }
}
