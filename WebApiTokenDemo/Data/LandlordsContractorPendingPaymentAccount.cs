using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordsContractorPendingPaymentAccounts", Schema = "accounts")]
    public partial class LandlordsContractorPendingPaymentAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int LandlordId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordsContractorPendingPaymentAccount")]
        public Landlord Landlord { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("LandlordsContractorPendingPaymentAccount")]
        public Ledger Ledger { get; set; }
    }
}
