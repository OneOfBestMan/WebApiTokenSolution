using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyInventoryItemInspectionConditions", Schema = "property")]
    public partial class PropertyInventoryItemInspectionCondition
    {
        public int Id { get; set; }
        public int PropertyInspectionId { get; set; }
        public int PropertyInventoryItemConditionId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PropertyInspectionId")]
        [InverseProperty("PropertyInventoryItemInspectionConditions")]
        public PropertyInspection PropertyInspection { get; set; }
        [ForeignKey("PropertyInventoryItemConditionId")]
        [InverseProperty("PropertyInventoryItemInspectionConditions")]
        public PropertyInventoryItemCondition PropertyInventoryItemCondition { get; set; }
    }
}
