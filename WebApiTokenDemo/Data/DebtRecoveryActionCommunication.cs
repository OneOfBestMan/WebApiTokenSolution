using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryActionCommunication
    {
        public int DebtRecoveryActionId { get; set; }
        public int CommunicationId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("CommunicationId")]
        [InverseProperty("DebtRecoveryActionCommunications")]
        public Communication Communication { get; set; }
        [ForeignKey("DebtRecoveryActionId")]
        [InverseProperty("DebtRecoveryActionCommunications")]
        public DebtRecoveryAction DebtRecoveryAction { get; set; }
    }
}
