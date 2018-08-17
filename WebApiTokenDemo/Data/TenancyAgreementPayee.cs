using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class TenancyAgreementPayee
    {
        public int PayeeId { get; set; }
        public int TenantId { get; set; }
        public int TenancyAgreementId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PayeeId")]
        [InverseProperty("TenancyAgreementPayees")]
        public Payee Payee { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenancyAgreementPayees")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
