using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorInvoices", Schema = "accounts")]
    public partial class ContractorInvoice
    {
        public ContractorInvoice()
        {
            ContractorInvoiceItems = new HashSet<ContractorInvoiceItem>();
            ContractorInvoiceNotes = new HashSet<ContractorInvoiceNote>();
        }

        public int Id { get; set; }
        public int ContractorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal TotalAmount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? VatAmount { get; set; }
        [StringLength(255)]
        public string Ref { get; set; }
        [Required]
        [StringLength(1)]
        public string TypeId { get; set; }
        public byte StageId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public int? PropertyId { get; set; }
        public int? TransactionItemGroupId { get; set; }
        public int? LedgerTransactionGroupIdUk { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("ContractorInvoices")]
        public Contractor Contractor { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("ContractorInvoices")]
        public Property Property { get; set; }
        [ForeignKey("StageId")]
        [InverseProperty("ContractorInvoices")]
        public ContractorInvoiceStage Stage { get; set; }
        [ForeignKey("TransactionItemGroupId")]
        [InverseProperty("ContractorInvoices")]
        public LedgerTransactionGroup TransactionItemGroup { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("ContractorInvoices")]
        public ContractorInvoiceType Type { get; set; }
        [InverseProperty("ContractorInvoice")]
        public ICollection<ContractorInvoiceItem> ContractorInvoiceItems { get; set; }
        [InverseProperty("ContractorInvoice")]
        public ICollection<ContractorInvoiceNote> ContractorInvoiceNotes { get; set; }
    }
}
