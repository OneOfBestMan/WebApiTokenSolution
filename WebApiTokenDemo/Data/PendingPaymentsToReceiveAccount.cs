using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PendingPaymentsToReceiveAccounts", Schema = "accounts")]
    public partial class PendingPaymentsToReceiveAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int LedgerMainAccountId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("PendingPaymentsToReceiveAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("LedgerMainAccountId")]
        [InverseProperty("PendingPaymentsToReceiveAccount")]
        public LedgerMainAccount LedgerMainAccount { get; set; }
    }
}
