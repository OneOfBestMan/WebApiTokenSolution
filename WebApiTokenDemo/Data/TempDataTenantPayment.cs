using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TempDataTenantPayments", Schema = "temp")]
    public partial class TempDataTenantPayment
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal Amount { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        public byte PaymentTypeId { get; set; }
        [StringLength(1)]
        public string TransactionType { get; set; }
        public int? TenantId { get; set; }
        public int? LandlordId { get; set; }
        public int? ContractorId { get; set; }
        [Required]
        [StringLength(50)]
        public string DestinationLedgerCode { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PeriodFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PeriodTo { get; set; }
        [StringLength(8)]
        public string ChequeNo { get; set; }
        public int? BankDepositId { get; set; }
        public int? TenantMainAccountId { get; set; }
        public int? LandlordMainAccountId { get; set; }
        public int? ContractorMainAccountId { get; set; }
        public int? DestinationLedgerId { get; set; }
        public int? LedgerTransactionId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Created { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Required]
        [StringLength(255)]
        public string CreatedReason { get; set; }
        public int? HousingBenefitPaymentId { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("TempDataTenantPayments")]
        public Contractor Contractor { get; set; }
        [ForeignKey("HousingBenefitPaymentId")]
        [InverseProperty("TempDataTenantPayments")]
        public TempDataHousingBenefitPayment HousingBenefitPayment { get; set; }
        [ForeignKey("LandlordId")]
        [InverseProperty("TempDataTenantPayments")]
        public Landlord Landlord { get; set; }
        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("TempDataTenantPayments")]
        public LedgerTransaction LedgerTransaction { get; set; }
        [ForeignKey("PaymentTypeId")]
        [InverseProperty("TempDataTenantPayments")]
        public PaymentType PaymentType { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("TempDataTenantPayments")]
        public Tenant Tenant { get; set; }
    }
}
