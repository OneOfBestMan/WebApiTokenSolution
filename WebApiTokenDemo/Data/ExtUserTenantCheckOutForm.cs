using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class ExtUserTenantCheckOutForm
    {
        public int TenancyAgreementId { get; set; }
        public int TenantId { get; set; }
        [StringLength(50)]
        public string FormAccessCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FormAvailableFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FormAvailableTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FormCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FormUpdated { get; set; }
        public byte? FormUpdateCount { get; set; }
        public byte? FormUpdateCountLimit { get; set; }
        [StringLength(50)]
        public string IpAddress { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LeavingDate { get; set; }
        [StringLength(50)]
        public string Bank { get; set; }
        [StringLength(50)]
        public string AccountName { get; set; }
        [StringLength(8)]
        public string Sortcode { get; set; }
        [StringLength(50)]
        public string AccountNo { get; set; }
        [StringLength(255)]
        public string KeysReturnedToWhomOtherDetails { get; set; }
        [StringLength(255)]
        public string AlternativeEmail { get; set; }
        [StringLength(255)]
        public string KeysReturnedHowOtherDetails { get; set; }
        [StringLength(50)]
        public string KeysMissing { get; set; }
        [StringLength(50)]
        public string KeysReturned { get; set; }
        [StringLength(1)]
        public string BedroomFloor { get; set; }
        [StringLength(255)]
        public string BedroomLocation { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(15)]
        public string MobileNo { get; set; }
        [StringLength(15)]
        public string AlternativeTelNo { get; set; }
        [StringLength(255)]
        public string AlternativeTelNoDetails { get; set; }
        [StringLength(1)]
        public string KeysReturnedToWhom { get; set; }
        [StringLength(255)]
        public string KeysMissingDetails { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? KeysReturnedDate { get; set; }
        public byte? KeysMissingQty { get; set; }
        [StringLength(1)]
        public string KeysReturnedHow { get; set; }
        public byte? KeysReturnedQty { get; set; }
        [StringLength(255)]
        public string KeysReturnedWhichDoors { get; set; }
        [StringLength(255)]
        public string KeysReturnedDamagedDetails { get; set; }
        [StringLength(255)]
        public string ForwardAddressLine1 { get; set; }
        [StringLength(255)]
        public string ForwardAddressLine2 { get; set; }
        [StringLength(255)]
        public string ForwardAddressTown { get; set; }
        [StringLength(10)]
        public string ForwardAddressPostcode { get; set; }
        [StringLength(50)]
        public string ForwardAddressCountry { get; set; }

        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("ExtUserTenantCheckOutForm")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
