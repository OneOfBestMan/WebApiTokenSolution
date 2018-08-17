using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class ContractorCommunication
    {
        public int ContractorId { get; set; }
        public int CommunicationId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("CommunicationId")]
        [InverseProperty("ContractorCommunications")]
        public Communication Communication { get; set; }
        [ForeignKey("ContractorId")]
        [InverseProperty("ContractorCommunications")]
        public Contractor Contractor { get; set; }
    }
}
