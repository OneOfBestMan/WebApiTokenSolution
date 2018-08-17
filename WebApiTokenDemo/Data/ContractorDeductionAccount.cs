using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorDeductionAccounts", Schema = "accounts")]
    public partial class ContractorDeductionAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int LedgerMainAccountId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("ContractorDeductionAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("LedgerMainAccountId")]
        [InverseProperty("ContractorDeductionAccount")]
        public LedgerMainAccount LedgerMainAccount { get; set; }
    }
}
