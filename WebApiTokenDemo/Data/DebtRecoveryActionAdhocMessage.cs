using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryActionAdhocMessage
    {
        public DebtRecoveryActionAdhocMessage()
        {
            DebtRecoveryActions = new HashSet<DebtRecoveryAction>();
        }

        public int Id { get; set; }
        [Required]
        public string Message { get; set; }

        [InverseProperty("DebtRecoveryActionAdhocMessage")]
        public ICollection<DebtRecoveryAction> DebtRecoveryActions { get; set; }
    }
}
