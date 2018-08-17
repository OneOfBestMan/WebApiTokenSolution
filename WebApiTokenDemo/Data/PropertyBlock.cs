using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyBlocks", Schema = "property")]
    public partial class PropertyBlock
    {
        public PropertyBlock()
        {
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("PropertyBlock")]
        public ICollection<Property> Properties { get; set; }
    }
}
