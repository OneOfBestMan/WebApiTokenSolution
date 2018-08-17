using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("RentChargeSchedules", Schema = "letting")]
    public partial class RentChargeSchedule
    {
        public RentChargeSchedule()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public int TenancyAgreementId { get; set; }
        [Column(TypeName = "date")]
        public DateTime PeriodFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PeriodTo { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal PeriodCharge { get; set; }
        public int PeriodFrequencyTypeId { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? DailyRateCharge { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PeriodFrequencyTypeId")]
        [InverseProperty("RentChargeSchedules")]
        public PeriodFrequencyType PeriodFrequencyType { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("RentChargeSchedules")]
        public TenantsTenancyAgreement Tenan { get; set; }
        [InverseProperty("RentChargeSchedule")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
    }
}
