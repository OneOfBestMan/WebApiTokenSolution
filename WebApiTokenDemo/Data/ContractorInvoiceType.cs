using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorInvoiceTypes", Schema = "accounts")]
    public partial class ContractorInvoiceType
    {
        public ContractorInvoiceType()
        {
            ContractorInvoices = new HashSet<ContractorInvoice>();
        }

        [StringLength(1)]
        public string Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("Type")]
        public ICollection<ContractorInvoice> ContractorInvoices { get; set; }
    }
}
