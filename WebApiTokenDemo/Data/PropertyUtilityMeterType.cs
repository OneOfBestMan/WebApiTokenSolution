using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyUtilityMeterTypes", Schema = "property")]
    public partial class PropertyUtilityMeterType
    {
        public PropertyUtilityMeterType()
        {
            PropertyUtilityMeters = new HashSet<PropertyUtilityMeter>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("PropertyUtilityMeterType")]
        public ICollection<PropertyUtilityMeter> PropertyUtilityMeters { get; set; }
    }
}
