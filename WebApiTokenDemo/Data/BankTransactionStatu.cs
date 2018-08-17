using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BankTransactionStatus", Schema = "banking")]
    public partial class BankTransactionStatu
    {
        public BankTransactionStatu()
        {
            BankStatementTransactions = new HashSet<BankStatementTransaction>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Status")]
        public ICollection<BankStatementTransaction> BankStatementTransactions { get; set; }
    }
}
