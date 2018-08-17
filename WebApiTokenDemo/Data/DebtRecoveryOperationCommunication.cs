using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryOperationCommunication
    {
        public int DebtRecoveryOperationId { get; set; }
        public int CommunicationId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("CommunicationId")]
        [InverseProperty("DebtRecoveryOperationCommunications")]
        public Communication Communication { get; set; }
        [ForeignKey("DebtRecoveryOperationId")]
        [InverseProperty("DebtRecoveryOperationCommunications")]
        public DebtRecoveryOperation DebtRecoveryOperation { get; set; }
    }
}
