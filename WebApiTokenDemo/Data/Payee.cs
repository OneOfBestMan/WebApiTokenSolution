using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Payees", Schema = "letting")]
    public partial class Payee
    {
        public Payee()
        {
            TenancyAgreementPayees = new HashSet<TenancyAgreementPayee>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(15)]
        public string LandlineTelNo { get; set; }
        [StringLength(15)]
        public string MobileNo { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string AddressLine1 { get; set; }
        [StringLength(255)]
        public string AddressLine2 { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        [StringLength(10)]
        public string Postcode { get; set; }
        [StringLength(25)]
        public string RelationshipToTenant { get; set; }
        [StringLength(255)]
        public string ConfidentialNotes { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("TenantId")]
        [InverseProperty("Payees")]
        public Tenant Tenant { get; set; }
        [InverseProperty("Payee")]
        public PayeeUserAccessProfile PayeeUserAccessProfile { get; set; }
        [InverseProperty("Payee")]
        public ICollection<TenancyAgreementPayee> TenancyAgreementPayees { get; set; }
    }
}
