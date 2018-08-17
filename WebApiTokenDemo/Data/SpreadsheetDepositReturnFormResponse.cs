using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class SpreadsheetDepositReturnFormResponse
    {
        public int Id { get; set; }
        public int? TenancyAgreementId { get; set; }
        public int? TenantId { get; set; }
        [StringLength(50)]
        public string ProcessStatus { get; set; }
        [StringLength(255)]
        public string ProcessComment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [StringLength(255)]
        public string Firstname { get; set; }
        [StringLength(255)]
        public string Lastname { get; set; }
        [StringLength(255)]
        public string PropertyAddress1stLine { get; set; }
        [StringLength(50)]
        public string TenancyEndDate { get; set; }
        [StringLength(255)]
        public string ContactNo { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(1000)]
        public string ForwardingAddress { get; set; }
        [StringLength(255)]
        public string BankAccountName { get; set; }
        [StringLength(255)]
        public string BankSortCode { get; set; }
        [StringLength(255)]
        public string BankAccountNo { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [StringLength(255)]
        public string BedroomFloor { get; set; }
        [StringLength(255)]
        public string BedroomLocation { get; set; }
        [StringLength(255)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string PlanToLeaveWhen { get; set; }
        [StringLength(255)]
        public string HowKeysReturnedToUs { get; set; }
        [StringLength(50)]
        public string KeysReturned { get; set; }
        [StringLength(50)]
        public string KeysReturnedWhen { get; set; }

        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("SpreadsheetDepositReturnFormResponses")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
