using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class PeriodFrequencyType
    {
        public PeriodFrequencyType()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
            RentChargeSchedules = new HashSet<RentChargeSchedule>();
            TenancyAgreements = new HashSet<TenancyAgreement>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("PeriodFrequencyType")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
        [InverseProperty("PeriodFrequencyType")]
        public ICollection<RentChargeSchedule> RentChargeSchedules { get; set; }
        [InverseProperty("RentPeriodFrequencyType")]
        public ICollection<TenancyAgreement> TenancyAgreements { get; set; }
    }
}
