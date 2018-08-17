using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("KeyReturnInstructions", Schema = "letting")]
    public partial class KeyReturnInstruction
    {
        public KeyReturnInstruction()
        {
            TenancyAgreements = new HashSet<TenancyAgreement>();
        }

        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(1000)]
        public string Instructions { get; set; }

        [InverseProperty("KeyReturnInstruction")]
        public ICollection<TenancyAgreement> TenancyAgreements { get; set; }
    }
}
