using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("KeyBunchKeys", Schema = "property")]
    public partial class KeyBunchKey
    {
        public int KeyBunchId { get; set; }
        public int KeyId { get; set; }
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("KeyId")]
        [InverseProperty("KeyBunchKeys")]
        public Key Key { get; set; }
        [ForeignKey("KeyBunchId")]
        [InverseProperty("KeyBunchKeys")]
        public KeyBunch KeyBunch { get; set; }
    }
}
