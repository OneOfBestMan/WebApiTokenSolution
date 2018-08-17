using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TempDataHousingBenefitPayments", Schema = "temp")]
    public partial class TempDataHousingBenefitPayment
    {
        public TempDataHousingBenefitPayment()
        {
            TempDataTenantPayments = new HashSet<TempDataTenantPayment>();
        }

        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public int ChequeNo { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Amount { get; set; }
        public int NoOfTenants { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }

        [InverseProperty("HousingBenefitPayment")]
        public ICollection<TempDataTenantPayment> TempDataTenantPayments { get; set; }
    }
}
