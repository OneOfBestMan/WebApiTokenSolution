using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryAction
    {
        public DebtRecoveryAction()
        {
            DebtRecoveryActionCommunications = new HashSet<DebtRecoveryActionCommunication>();
            DebtRecoveryActionNotes = new HashSet<DebtRecoveryActionNote>();
        }

        public int Id { get; set; }
        public int? DebtRecoveryOperationId { get; set; }
        public int DebtChaseMethodId { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Balance { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FinalDayBeforeFurtherAction { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? FeeLevied { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public int? DebtRecoveryActionMethodId { get; set; }
        public int? DebtRecoveryActionAdhocMessageId { get; set; }

        [ForeignKey("DebtChaseMethodId")]
        [InverseProperty("DebtRecoveryActions")]
        public DebtChaseMethod DebtChaseMethod { get; set; }
        [ForeignKey("DebtRecoveryActionAdhocMessageId")]
        [InverseProperty("DebtRecoveryActions")]
        public DebtRecoveryActionAdhocMessage DebtRecoveryActionAdhocMessage { get; set; }
        [ForeignKey("DebtRecoveryActionMethodId")]
        [InverseProperty("DebtRecoveryActions")]
        public DebtRecoveryActionMethod DebtRecoveryActionMethod { get; set; }
        [ForeignKey("DebtRecoveryOperationId")]
        [InverseProperty("DebtRecoveryActions")]
        public DebtRecoveryOperation DebtRecoveryOperation { get; set; }
        [InverseProperty("DebtRecoveryAction")]
        public ICollection<DebtRecoveryActionCommunication> DebtRecoveryActionCommunications { get; set; }
        [InverseProperty("DebtRecoveryAction")]
        public ICollection<DebtRecoveryActionNote> DebtRecoveryActionNotes { get; set; }
    }
}
