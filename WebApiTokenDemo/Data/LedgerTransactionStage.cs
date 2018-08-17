using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionStages", Schema = "accounts")]
    public partial class LedgerTransactionStage
    {
        public LedgerTransactionStage()
        {
            LedgerTransactions = new HashSet<LedgerTransaction>();
            PaymentTypeInitialTxStageOnMakePaymentNavigations = new HashSet<PaymentType>();
            PaymentTypeInitialTxStageOnTakePaymentNavigations = new HashSet<PaymentType>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("LedgerTransactionStage")]
        public ICollection<LedgerTransaction> LedgerTransactions { get; set; }
        [InverseProperty("InitialTxStageOnMakePaymentNavigation")]
        public ICollection<PaymentType> PaymentTypeInitialTxStageOnMakePaymentNavigations { get; set; }
        [InverseProperty("InitialTxStageOnTakePaymentNavigation")]
        public ICollection<PaymentType> PaymentTypeInitialTxStageOnTakePaymentNavigations { get; set; }
    }
}
