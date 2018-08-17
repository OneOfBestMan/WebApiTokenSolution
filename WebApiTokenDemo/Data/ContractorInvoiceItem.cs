using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorInvoiceItems", Schema = "accounts")]
    public partial class ContractorInvoiceItem
    {
        public ContractorInvoiceItem()
        {
            ContractorInvoiceItemCostAllocations = new HashSet<ContractorInvoiceItemCostAllocation>();
        }

        public int Id { get; set; }
        public int ContractorInvoiceId { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Amount { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [StringLength(1)]
        public string StatusId { get; set; }
        public int? TenancyAgreementId { get; set; }

        [ForeignKey("ContractorInvoiceId")]
        [InverseProperty("ContractorInvoiceItems")]
        public ContractorInvoice ContractorInvoice { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("ContractorInvoiceItems")]
        public TenancyAgreement TenancyAgreement { get; set; }
        [InverseProperty("ContractorInvoiceItem")]
        public ICollection<ContractorInvoiceItemCostAllocation> ContractorInvoiceItemCostAllocations { get; set; }
    }
}
