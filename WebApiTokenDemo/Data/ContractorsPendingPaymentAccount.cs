using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorsPendingPaymentAccounts", Schema = "accounts")]
    public partial class ContractorsPendingPaymentAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int ContractorId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("ContractorsPendingPaymentAccounts")]
        public Contractor Contractor { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("ContractorsPendingPaymentAccount")]
        public Ledger Ledger { get; set; }
    }
}
