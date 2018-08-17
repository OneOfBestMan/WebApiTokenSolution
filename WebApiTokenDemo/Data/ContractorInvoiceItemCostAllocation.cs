using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorInvoiceItemCostAllocations", Schema = "accounts")]
    public partial class ContractorInvoiceItemCostAllocation
    {
        public ContractorInvoiceItemCostAllocation()
        {
            ContractorInvoiceItemCostAllocationLedgerTransactions = new HashSet<ContractorInvoiceItemCostAllocationLedgerTransaction>();
        }

        public int Id { get; set; }
        public int ContractorInvoiceItemId { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal Amount { get; set; }
        public int LedgerMainAccountId { get; set; }
        public int ContraLedgerId { get; set; }

        [ForeignKey("ContraLedgerId")]
        [InverseProperty("ContractorInvoiceItemCostAllocations")]
        public Ledger ContraLedger { get; set; }
        [ForeignKey("ContractorInvoiceItemId")]
        [InverseProperty("ContractorInvoiceItemCostAllocations")]
        public ContractorInvoiceItem ContractorInvoiceItem { get; set; }
        [ForeignKey("LedgerMainAccountId")]
        [InverseProperty("ContractorInvoiceItemCostAllocations")]
        public LedgerMainAccount LedgerMainAccount { get; set; }
        [InverseProperty("ContractorInvoiceItemCostAllocation")]
        public ICollection<ContractorInvoiceItemCostAllocationLedgerTransaction> ContractorInvoiceItemCostAllocationLedgerTransactions { get; set; }
    }
}
