using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryOperation
    {
        public DebtRecoveryOperation()
        {
            DebtRecoveryActions = new HashSet<DebtRecoveryAction>();
            DebtRecoveryOperationCommunications = new HashSet<DebtRecoveryOperationCommunication>();
            DebtRecoveryOperationNotes = new HashSet<DebtRecoveryOperationNote>();
        }

        public int Id { get; set; }
        public int LedgerId { get; set; }
        public bool Active { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FirstDayOfDebt { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? FirstDayOfDebtAmount { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RecoveryFinished { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("DebtRecoveryOperation")]
        public LedgerMainAccount Ledger { get; set; }
        [InverseProperty("DebtRecoveryOperation")]
        public ICollection<DebtRecoveryAction> DebtRecoveryActions { get; set; }
        [InverseProperty("DebtRecoveryOperation")]
        public ICollection<DebtRecoveryOperationCommunication> DebtRecoveryOperationCommunications { get; set; }
        [InverseProperty("DebtRecoveryOperation")]
        public ICollection<DebtRecoveryOperationNote> DebtRecoveryOperationNotes { get; set; }
    }
}
