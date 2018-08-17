using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyInventoryItemTypes", Schema = "property")]
    public partial class PropertyInventoryItemType
    {
        public PropertyInventoryItemType()
        {
            PropertyInventoryItems = new HashSet<PropertyInventoryItem>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("PropertyInventoryType")]
        public ICollection<PropertyInventoryItem> PropertyInventoryItems { get; set; }
    }
}
