using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorInvoiceStages", Schema = "accounts")]
    public partial class ContractorInvoiceStage
    {
        public ContractorInvoiceStage()
        {
            ContractorInvoices = new HashSet<ContractorInvoice>();
        }

        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("Stage")]
        public ICollection<ContractorInvoice> ContractorInvoices { get; set; }
    }
}
