using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyInventoryItemConditions", Schema = "property")]
    public partial class PropertyInventoryItemCondition
    {
        public PropertyInventoryItemCondition()
        {
            PropertyInventoryItemInspectionConditions = new HashSet<PropertyInventoryItemInspectionCondition>();
        }

        public int Id { get; set; }
        public int PropertyInventoryItemId { get; set; }
        [Required]
        [StringLength(255)]
        public string Condition { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PropertyInventoryItemId")]
        [InverseProperty("PropertyInventoryItemConditions")]
        public PropertyInventoryItem PropertyInventoryItem { get; set; }
        [InverseProperty("PropertyInventoryItemCondition")]
        public ICollection<PropertyInventoryItemInspectionCondition> PropertyInventoryItemInspectionConditions { get; set; }
    }
}
