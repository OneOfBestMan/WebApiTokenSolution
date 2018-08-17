using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class SpreadsheetKeyCollectionFormResponse
    {
        public int Id { get; set; }
        public int? TenancyAgreementId { get; set; }
        public int? TenantId { get; set; }
        [StringLength(50)]
        public string ProcessStatus { get; set; }
        [StringLength(255)]
        public string ProcessComment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [StringLength(255)]
        public string Firstname { get; set; }
        [StringLength(255)]
        public string Lastname { get; set; }
        [StringLength(255)]
        public string PropertyAddress1stLine { get; set; }
        [StringLength(255)]
        public string ContactNo { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string OtherPersonFirstname { get; set; }
        [StringLength(255)]
        public string OtherPersonLastname { get; set; }
        [StringLength(255)]
        public string OtherPersonContactNo { get; set; }
        [StringLength(255)]
        public string CollectDate { get; set; }
        [StringLength(255)]
        public string CollectSlot { get; set; }
        [StringLength(255)]
        public string WhoToCollect { get; set; }
        [StringLength(50)]
        public string TenancyEndBegin { get; set; }

        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("SpreadsheetKeyCollectionFormResponses")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
