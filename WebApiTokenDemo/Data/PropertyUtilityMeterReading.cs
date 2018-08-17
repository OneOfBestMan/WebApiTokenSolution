using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyUtilityMeterReadings", Schema = "property")]
    public partial class PropertyUtilityMeterReading
    {
        public int Id { get; set; }
        public int PropertyUtilityMeterId { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal MeterReading { get; set; }
        [Required]
        [StringLength(50)]
        public string TakenBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTaken { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PropertyUtilityMeterId")]
        [InverseProperty("PropertyUtilityMeterReadings")]
        public PropertyUtilityMeter PropertyUtilityMeter { get; set; }
    }
}
