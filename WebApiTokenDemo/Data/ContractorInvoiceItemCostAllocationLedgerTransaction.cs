using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorInvoiceItemCostAllocationLedgerTransactions", Schema = "accounts")]
    public partial class ContractorInvoiceItemCostAllocationLedgerTransaction
    {
        public int ContractorInvoiceItemCostAllocationId { get; set; }
        public int LedgerTransactionId { get; set; }
        [Required]
        [StringLength(15)]
        public string Type { get; set; }

        [ForeignKey("ContractorInvoiceItemCostAllocationId")]
        [InverseProperty("ContractorInvoiceItemCostAllocationLedgerTransactions")]
        public ContractorInvoiceItemCostAllocation ContractorInvoiceItemCostAllocation { get; set; }
        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("ContractorInvoiceItemCostAllocationLedgerTransactions")]
        public LedgerTransaction LedgerTransaction { get; set; }
    }
}
