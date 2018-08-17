using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordsContractorPaymentAccounts", Schema = "accounts")]
    public partial class LandlordsContractorPaymentAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int LandlordId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordsContractorPaymentAccount")]
        public Landlord Landlord { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("LandlordsContractorPaymentAccount")]
        public Ledger Ledger { get; set; }
    }
}
