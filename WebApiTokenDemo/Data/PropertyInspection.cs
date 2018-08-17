using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyInspections", Schema = "property")]
    public partial class PropertyInspection
    {
        public PropertyInspection()
        {
            PropertyInventoryItemInspectionConditions = new HashSet<PropertyInventoryItemInspectionCondition>();
        }

        public int Id { get; set; }
        public int InspectionTypeId { get; set; }
        public bool? SignedByTenants { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [StringLength(255)]
        public string MeterReadings { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InspectionDate { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("InspectionTypeId")]
        [InverseProperty("PropertyInspections")]
        public PropertyInspectionType InspectionType { get; set; }
        [InverseProperty("PropertyInspection")]
        public ICollection<PropertyInventoryItemInspectionCondition> PropertyInventoryItemInspectionConditions { get; set; }
    }
}
