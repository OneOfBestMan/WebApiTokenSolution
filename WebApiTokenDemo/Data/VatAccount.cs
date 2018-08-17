using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("VatAccounts", Schema = "accounts")]
    public partial class VatAccount
    {
        public VatAccount()
        {
            VatLedgerTransactions = new HashSet<VatLedgerTransaction>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string VatNo { get; set; }
        [Required]
        [StringLength(50)]
        public string SchemeType { get; set; }
        public int LedgerId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("VatAccount")]
        public Ledger Ledger { get; set; }
        [InverseProperty("VatAccount")]
        public ICollection<VatLedgerTransaction> VatLedgerTransactions { get; set; }
    }
}
