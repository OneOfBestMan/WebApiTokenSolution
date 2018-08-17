using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordsMainAccounts", Schema = "accounts")]
    public partial class LandlordsMainAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int LandlordId { get; set; }
        [StringLength(50)]
        public string RentalStatementDeliveryMethod { get; set; }
        public short? CreditLimit { get; set; }
        public short? CreditTermsInDays { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordsMainAccount")]
        public Landlord Landlord { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("LandlordsMainAccount")]
        public LedgerMainAccount Ledger { get; set; }
    }
}
