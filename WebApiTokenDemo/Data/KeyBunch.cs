using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("KeyBunches", Schema = "property")]
    public partial class KeyBunch
    {
        public KeyBunch()
        {
            KeyBunchKeys = new HashSet<KeyBunchKey>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(1)]
        public string WhosSet { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsNameUnique { get; set; }

        [InverseProperty("KeyBunch")]
        public ICollection<KeyBunchKey> KeyBunchKeys { get; set; }
    }
}
