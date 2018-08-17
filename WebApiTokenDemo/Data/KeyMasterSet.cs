using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("KeyMasterSets", Schema = "property")]
    public partial class KeyMasterSet
    {
        public KeyMasterSet()
        {
            Keys = new HashSet<Key>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("KeyMasterSet")]
        public ICollection<Key> Keys { get; set; }
    }
}
