using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyDepositProtectionSchemes", Schema = "letting")]
    public partial class TenancyDepositProtectionScheme
    {
        public TenancyDepositProtectionScheme()
        {
            TenancyAgreements = new HashSet<TenancyAgreement>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("DepositProtectionScheme")]
        public ICollection<TenancyAgreement> TenancyAgreements { get; set; }
    }
}
