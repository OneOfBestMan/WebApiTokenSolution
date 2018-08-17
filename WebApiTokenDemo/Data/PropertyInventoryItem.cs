using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyInventoryItems", Schema = "property")]
    public partial class PropertyInventoryItem
    {
        public PropertyInventoryItem()
        {
            PropertyInventoryItemConditions = new HashSet<PropertyInventoryItemCondition>();
        }

        public int Id { get; set; }
        public int PropertyInventoryTypeId { get; set; }
        public byte Quantity { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        public int AccommodationId { get; set; }
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("AccommodationId")]
        [InverseProperty("PropertyInventoryItems")]
        public Accommodation Accommodation { get; set; }
        [ForeignKey("PropertyInventoryTypeId")]
        [InverseProperty("PropertyInventoryItems")]
        public PropertyInventoryItemType PropertyInventoryType { get; set; }
        [InverseProperty("PropertyInventoryItem")]
        public ICollection<PropertyInventoryItemCondition> PropertyInventoryItemConditions { get; set; }
    }
}
