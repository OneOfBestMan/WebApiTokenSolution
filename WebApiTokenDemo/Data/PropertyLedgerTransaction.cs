using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyLedgerTransactions", Schema = "letting")]
    public partial class PropertyLedgerTransaction
    {
        public int PropertyId { get; set; }
        public int LedgerTransactionId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("PropertyLedgerTransactions")]
        public LedgerTransaction LedgerTransaction { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("PropertyLedgerTransactions")]
        public Property Property { get; set; }
    }
}
