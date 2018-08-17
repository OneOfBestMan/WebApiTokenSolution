using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class BankDetail
    {
        public int Id { get; set; }
        public int? TenantId { get; set; }
        public int? LandlordId { get; set; }
        public int? ContractorId { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountName { get; set; }
        [Required]
        [StringLength(10)]
        public string AccountNo { get; set; }
        [Required]
        [StringLength(6)]
        public string SortCode { get; set; }
        [Required]
        [StringLength(50)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string BankAddressLine1 { get; set; }
        [StringLength(50)]
        public string BankAddressLine2 { get; set; }
        [StringLength(50)]
        public string BankAddressLine3 { get; set; }
        [StringLength(50)]
        public string BankAddressLine4 { get; set; }
        [StringLength(8)]
        public string Postcode { get; set; }
        [StringLength(50)]
        public string BicSwiftCode { get; set; }
        [StringLength(50)]
        public string Iban { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("BankDetails")]
        public Contractor Contractor { get; set; }
        [ForeignKey("LandlordId")]
        [InverseProperty("BankDetails")]
        public Landlord Landlord { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("BankDetails")]
        public Tenant Tenant { get; set; }
    }
}
