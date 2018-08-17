using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PdqAccounts", Schema = "accounts")]
    public partial class PdqAccount
    {
        public PdqAccount()
        {
            PdqAccountsBankDeposits = new HashSet<PdqAccountsBankDeposit>();
        }

        [Key]
        public int LedgerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("PdqAccount")]
        public Ledger Ledger { get; set; }
        [InverseProperty("PdqAccount")]
        public ICollection<PdqAccountsBankDeposit> PdqAccountsBankDeposits { get; set; }
    }
}
