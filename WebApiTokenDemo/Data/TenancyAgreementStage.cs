using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreementStages", Schema = "letting")]
    public partial class TenancyAgreementStage
    {
        public TenancyAgreementStage()
        {
            TenancyAgreements = new HashSet<TenancyAgreement>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(1)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("TenancyAgreementStage")]
        public ICollection<TenancyAgreement> TenancyAgreements { get; set; }
    }
}
