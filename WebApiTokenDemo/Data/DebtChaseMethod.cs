using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtChaseMethod
    {
        public DebtChaseMethod()
        {
            DebtRecoveryActions = new HashSet<DebtRecoveryAction>();
        }

        public int DebtChaseMethodId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
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
        [StringLength(1)]
        public string Status { get; set; }
        public bool? FinalDayBeforeActionIndi { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Fee { get; set; }
        public bool? AdhocMessageIndi { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("EmailMsgHtmlTemplateId")]
        [InverseProperty("DebtChaseMethods")]
        public EmailMsgHtmlTemplate EmailMsgHtmlTemplate { get; set; }
        [ForeignKey("EmailSmtpClientId")]
        [InverseProperty("DebtChaseMethods")]
        public EmailSmtpClient EmailSmtpClient { get; set; }
        [InverseProperty("DebtChaseMethod")]
        public ICollection<DebtRecoveryAction> DebtRecoveryActions { get; set; }
    }
}
