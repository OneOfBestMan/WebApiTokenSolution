using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PaymentTypes", Schema = "accounts")]
    public partial class PaymentType
    {
        public PaymentType()
        {
            BankPaymentReferences = new HashSet<BankPaymentReference>();
            BankStatementTransactions = new HashSet<BankStatementTransaction>();
            LedgerTransactions = new HashSet<LedgerTransaction>();
            TempDataTenantPayments = new HashSet<TempDataTenantPayment>();
        }

        public byte Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public byte AuthorisationPeriod { get; set; }
        public bool MustBankToClear { get; set; }
        public bool CanBeTakenByStaff { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public bool CanBeMadeByStaff { get; set; }
        public int InitialTxStageOnTakePayment { get; set; }
        public int InitialTxStageOnMakePayment { get; set; }

        [ForeignKey("InitialTxStageOnMakePayment")]
        [InverseProperty("PaymentTypeInitialTxStageOnMakePaymentNavigations")]
        public LedgerTransactionStage InitialTxStageOnMakePaymentNavigation { get; set; }
        [ForeignKey("InitialTxStageOnTakePayment")]
        [InverseProperty("PaymentTypeInitialTxStageOnTakePaymentNavigations")]
        public LedgerTransactionStage InitialTxStageOnTakePaymentNavigation { get; set; }
        [InverseProperty("PaymentType")]
        public ICollection<BankPaymentReference> BankPaymentReferences { get; set; }
        [InverseProperty("PaymentType")]
        public ICollection<BankStatementTransaction> BankStatementTransactions { get; set; }
        [InverseProperty("PaymentType")]
        public ICollection<LedgerTransaction> LedgerTransactions { get; set; }
        [InverseProperty("PaymentType")]
        public ICollection<TempDataTenantPayment> TempDataTenantPayments { get; set; }
    }
}
