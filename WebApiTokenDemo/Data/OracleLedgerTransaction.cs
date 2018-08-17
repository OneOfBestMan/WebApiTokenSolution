using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class OracleLedgerTransaction
    {
        public int Id { get; set; }
        public int? LedgerTransactionId { get; set; }

        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("OracleLedgerTransactions")]
        public LedgerTransaction LedgerTransaction { get; set; }
    }
}
