using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("AutoTransferPlanTypes", Schema = "accounts")]
    public partial class AutoTransferPlanType
    {
        public AutoTransferPlanType()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public bool AllowOneOffOnlyPeriodFrequency { get; set; }
        [Required]
        public bool? IsOneOffPeriodFreqFromDateRequired { get; set; }
        [Required]
        public bool? IsOneOffPeriodFreqToDateRequired { get; set; }
        public bool? RequireCreditLedgerId { get; set; }
        public bool? RequireDebitLedgerId { get; set; }
        public bool? RequireTenantId { get; set; }
        public bool? RequireLandlordId { get; set; }
        public bool? RequireContractorId { get; set; }
        public bool? RequireTenancyAgreementId { get; set; }

        [InverseProperty("AutoTransferPlanType")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
    }
}
