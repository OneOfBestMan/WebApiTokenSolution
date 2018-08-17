using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorsMainAccounts", Schema = "accounts")]
    public partial class ContractorsMainAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int ContractorId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("ContractorsMainAccount")]
        public Contractor Contractor { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("ContractorsMainAccount")]
        public LedgerMainAccount Ledger { get; set; }
    }
}
