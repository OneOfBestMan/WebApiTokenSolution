using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BankLedgerTransactionTypes", Schema = "banking")]
    public partial class BankLedgerTransactionType
    {
        public BankLedgerTransactionType()
        {
            BankStatementLedgerTransactions = new HashSet<BankStatementLedgerTransaction>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }

        [InverseProperty("BankLedgerTransactionType")]
        public ICollection<BankStatementLedgerTransaction> BankStatementLedgerTransactions { get; set; }
    }
}
