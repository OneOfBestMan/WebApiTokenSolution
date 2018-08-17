using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyFacilityTypes", Schema = "property")]
    public partial class PropertyFacilityType
    {
        public PropertyFacilityType()
        {
            PropertyFacilities = new HashSet<PropertyFacility>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("PropertyFacilityType")]
        public ICollection<PropertyFacility> PropertyFacilities { get; set; }
    }
}
