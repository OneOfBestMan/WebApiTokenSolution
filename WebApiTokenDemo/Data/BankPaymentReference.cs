using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BankPaymentReferences", Schema = "banking")]
    public partial class BankPaymentReference
    {
        public BankPaymentReference()
        {
            BankStatementTransactions = new HashSet<BankStatementTransaction>();
        }

        public int Id { get; set; }
        public int BankAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Amt { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        public int ContraLedgerId { get; set; }
        public byte PaymentTypeId { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BankAccountId")]
        [InverseProperty("BankPaymentReferences")]
        public BankAccount BankAccount { get; set; }
        [ForeignKey("ContraLedgerId")]
        [InverseProperty("BankPaymentReferences")]
        public Ledger ContraLedger { get; set; }
        [ForeignKey("PaymentTypeId")]
        [InverseProperty("BankPaymentReferences")]
        public PaymentType PaymentType { get; set; }
        [InverseProperty("BankPaymentReferenceIdMatchNavigation")]
        public ICollection<BankStatementTransaction> BankStatementTransactions { get; set; }
    }
}
