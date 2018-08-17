using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PendingPaymentsToPayAccounts", Schema = "accounts")]
    public partial class PendingPaymentsToPayAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int LedgerMainAccountId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("PendingPaymentsToPayAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("LedgerMainAccountId")]
        [InverseProperty("PendingPaymentsToPayAccount")]
        public LedgerMainAccount LedgerMainAccount { get; set; }
    }
}
