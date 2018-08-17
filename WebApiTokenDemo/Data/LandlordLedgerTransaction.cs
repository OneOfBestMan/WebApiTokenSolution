using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordLedgerTransactions", Schema = "letting")]
    public partial class LandlordLedgerTransaction
    {
        public int LandlordId { get; set; }
        public int LedgerTransactionId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordLedgerTransactions")]
        public Landlord Landlord { get; set; }
        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("LandlordLedgerTransactions")]
        public LedgerTransaction LedgerTransaction { get; set; }
    }
}
