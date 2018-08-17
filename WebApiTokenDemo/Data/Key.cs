using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Keys", Schema = "property")]
    public partial class Key
    {
        public Key()
        {
            KeyBunchKeys = new HashSet<KeyBunchKey>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        public byte TotalQuantity { get; set; }
        public int? KeyMasterSetId { get; set; }
        public bool IsMasterKey { get; set; }
        public int? PropertyId { get; set; }
        public int? BedroomId { get; set; }
        public bool? IsForEntranceDoor { get; set; }

        [ForeignKey("BedroomId")]
        [InverseProperty("Keys")]
        public Accommodation Bedroom { get; set; }
        [ForeignKey("KeyMasterSetId")]
        [InverseProperty("Keys")]
        public KeyMasterSet KeyMasterSet { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("Keys")]
        public Property Property { get; set; }
        [InverseProperty("Key")]
        public ICollection<KeyBunchKey> KeyBunchKeys { get; set; }
    }
}
