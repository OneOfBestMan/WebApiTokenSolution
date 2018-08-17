using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Communication
    {
        public Communication()
        {
            CommunicationNotes = new HashSet<CommunicationNote>();
            ContractorCommunications = new HashSet<ContractorCommunication>();
            DebtRecoveryActionCommunications = new HashSet<DebtRecoveryActionCommunication>();
            DebtRecoveryOperationCommunications = new HashSet<DebtRecoveryOperationCommunication>();
            GuarantorCommunications = new HashSet<GuarantorCommunication>();
            LandlordCommunications = new HashSet<LandlordCommunication>();
            TenantCommunications = new HashSet<TenantCommunication>();
        }

        public int Id { get; set; }
        public int CommunicationTypeId { get; set; }
        public int CommunicationCategoryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [StringLength(255)]
        public string Ref { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string From { get; set; }

        [ForeignKey("CommunicationCategoryId")]
        [InverseProperty("Communications")]
        public CommunicationCategory CommunicationCategory { get; set; }
        [ForeignKey("CommunicationTypeId")]
        [InverseProperty("Communications")]
        public CommunicationType CommunicationType { get; set; }
        [InverseProperty("Communication")]
        public ICollection<CommunicationNote> CommunicationNotes { get; set; }
        [InverseProperty("Communication")]
        public ICollection<ContractorCommunication> ContractorCommunications { get; set; }
        [InverseProperty("Communication")]
        public ICollection<DebtRecoveryActionCommunication> DebtRecoveryActionCommunications { get; set; }
        [InverseProperty("Communication")]
        public ICollection<DebtRecoveryOperationCommunication> DebtRecoveryOperationCommunications { get; set; }
        [InverseProperty("Communication")]
        public ICollection<GuarantorCommunication> GuarantorCommunications { get; set; }
        [InverseProperty("Communication")]
        public ICollection<LandlordCommunication> LandlordCommunications { get; set; }
        [InverseProperty("Communication")]
        public ICollection<TenantCommunication> TenantCommunications { get; set; }
    }
}
