using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Note
    {
        public Note()
        {
            CommunicationNotes = new HashSet<CommunicationNote>();
            ContractorInvoiceNotes = new HashSet<ContractorInvoiceNote>();
            ContractorNotes = new HashSet<ContractorNote>();
            DebtRecoveryActionNotes = new HashSet<DebtRecoveryActionNote>();
            DebtRecoveryOperationNotes = new HashSet<DebtRecoveryOperationNote>();
            GuarantorNotes = new HashSet<GuarantorNote>();
            LandlordNotes = new HashSet<LandlordNote>();
            LedgerNotes = new HashSet<LedgerNote>();
            PropertyNotes = new HashSet<PropertyNote>();
            TenancyAgreementNotes = new HashSet<TenancyAgreementNote>();
            TenantNotes = new HashSet<TenantNote>();
            TenantsTenancyAgreementNotes = new HashSet<TenantsTenancyAgreementNote>();
        }

        public int Id { get; set; }
        public int NoteTypeId { get; set; }
        [Required]
        public bool? Confidential { get; set; }
        [Required]
        [StringLength(1000)]
        public string Details { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public DateTimeOffset Created { get; set; }

        [ForeignKey("NoteTypeId")]
        [InverseProperty("Notes")]
        public NoteType NoteType { get; set; }
        [InverseProperty("Note")]
        public ICollection<CommunicationNote> CommunicationNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<ContractorInvoiceNote> ContractorInvoiceNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<ContractorNote> ContractorNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<DebtRecoveryActionNote> DebtRecoveryActionNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<DebtRecoveryOperationNote> DebtRecoveryOperationNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<GuarantorNote> GuarantorNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<LandlordNote> LandlordNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<LedgerNote> LedgerNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<PropertyNote> PropertyNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<TenancyAgreementNote> TenancyAgreementNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<TenantNote> TenantNotes { get; set; }
        [InverseProperty("Note")]
        public ICollection<TenantsTenancyAgreementNote> TenantsTenancyAgreementNotes { get; set; }
    }
}
