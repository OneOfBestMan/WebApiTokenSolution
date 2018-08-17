using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyFacilities", Schema = "property")]
    public partial class PropertyFacility
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int PropertyFacilityTypeId { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PropertyId")]
        [InverseProperty("PropertyFacilities")]
        public Property Property { get; set; }
        [ForeignKey("PropertyFacilityTypeId")]
        [InverseProperty("PropertyFacilities")]
        public PropertyFacilityType PropertyFacilityType { get; set; }
    }
}
