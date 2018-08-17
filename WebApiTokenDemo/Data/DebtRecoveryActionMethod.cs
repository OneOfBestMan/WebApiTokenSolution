using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryActionMethod
    {
        public DebtRecoveryActionMethod()
        {
            DebtRecoveryActions = new HashSet<DebtRecoveryAction>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        [StringLength(1)]
        public string ListingGroup { get; set; }
        [Required]
        [StringLength(1)]
        public string TargetGroup { get; set; }
        public int ListOrder { get; set; }
        public bool ActiveRecordIndi { get; set; }
        public bool FinalDayBeforeActionIndi { get; set; }
        public bool AdhocMessageIndi { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [StringLength(255)]
        public string MessageTitle { get; set; }
        [Required]
        public string MessageBody { get; set; }
        [Required]
        [StringLength(1)]
        public string MessageDeliveryMethod { get; set; }
        public int? EmailMsgHtmlTemplateId { get; set; }
        public int? EmailSmtpClientId { get; set; }
        [Column("KeepACopy")]
        public bool KeepAcopy { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Fee { get; set; }
        public int? MailMergeTemplateId { get; set; }

        [ForeignKey("MailMergeTemplateId")]
        [InverseProperty("DebtRecoveryActionMethods")]
        public MailMergeTemplate MailMergeTemplate { get; set; }
        [InverseProperty("DebtRecoveryActionMethod")]
        public ICollection<DebtRecoveryAction> DebtRecoveryActions { get; set; }
    }
}
