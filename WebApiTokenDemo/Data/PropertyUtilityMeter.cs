using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyUtilityMeters", Schema = "property")]
    public partial class PropertyUtilityMeter
    {
        public PropertyUtilityMeter()
        {
            PropertyUtilityMeterReadings = new HashSet<PropertyUtilityMeterReading>();
        }

        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int PropertyUtilityMeterTypeId { get; set; }
        [StringLength(255)]
        public string Location { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PropertyId")]
        [InverseProperty("PropertyUtilityMeters")]
        public Property Property { get; set; }
        [ForeignKey("PropertyUtilityMeterTypeId")]
        [InverseProperty("PropertyUtilityMeters")]
        public PropertyUtilityMeterType PropertyUtilityMeterType { get; set; }
        [InverseProperty("PropertyUtilityMeter")]
        public ICollection<PropertyUtilityMeterReading> PropertyUtilityMeterReadings { get; set; }
    }
}
