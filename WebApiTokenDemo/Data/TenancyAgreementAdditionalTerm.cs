using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreementAdditionalTerms", Schema = "letting")]
    public partial class TenancyAgreementAdditionalTerm
    {
        public int Id { get; set; }
        public int TenancyAgreementId { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        public bool TenantsObligation { get; set; }
        public bool LandlordsObligation { get; set; }

        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TenancyAgreementAdditionalTerms")]
        public TenancyAgreement TenancyAgreement { get; set; }
    }
}
