using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreementGeneralAccounts", Schema = "accounts")]
    public partial class TenancyAgreementGeneralAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int TenancyAgreementId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("TenancyAgreementGeneralAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TenancyAgreementGeneralAccount")]
        public TenancyAgreement TenancyAgreement { get; set; }
    }
}
