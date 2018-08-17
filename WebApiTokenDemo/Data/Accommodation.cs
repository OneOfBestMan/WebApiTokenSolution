using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Accommodation", Schema = "property")]
    public partial class Accommodation
    {
        public Accommodation()
        {
            Images = new HashSet<Image>();
            Keys = new HashSet<Key>();
            PropertyInventoryItems = new HashSet<PropertyInventoryItem>();
        }

        public int Id { get; set; }
        public int PropertyId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [StringLength(50)]
        public string FloorLevel { get; set; }
        [StringLength(255)]
        public string DescrGeneral { get; set; }
        [StringLength(255)]
        public string DescrLetting { get; set; }
        [StringLength(255)]
        public string DescrSale { get; set; }
        public int AccommodationTypeId { get; set; }
        [StringLength(50)]
        public string FloorDimensions { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [Required]
        public bool? ActiveRecordIndi { get; set; }
        public short ListOrder { get; set; }

        [ForeignKey("AccommodationTypeId")]
        [InverseProperty("Accommodations")]
        public AccommodationType AccommodationType { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("Accommodations")]
        public Property Property { get; set; }
        [InverseProperty("Accommodation")]
        public ICollection<Image> Images { get; set; }
        [InverseProperty("Bedroom")]
        public ICollection<Key> Keys { get; set; }
        [InverseProperty("Accommodation")]
        public ICollection<PropertyInventoryItem> PropertyInventoryItems { get; set; }
    }
}
