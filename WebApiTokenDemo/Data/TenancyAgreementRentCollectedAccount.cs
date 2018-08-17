using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreementRentCollectedAccounts", Schema = "accounts")]
    public partial class TenancyAgreementRentCollectedAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int TenancyAgreementId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("TenancyAgreementRentCollectedAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TenancyAgreementRentCollectedAccount")]
        public TenancyAgreement TenancyAgreement { get; set; }
    }
}
