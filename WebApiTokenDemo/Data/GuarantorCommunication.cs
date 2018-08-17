using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class GuarantorCommunication
    {
        public int GuarantorId { get; set; }
        public int CommunicationId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("CommunicationId")]
        [InverseProperty("GuarantorCommunications")]
        public Communication Communication { get; set; }
        [ForeignKey("GuarantorId")]
        [InverseProperty("GuarantorCommunications")]
        public Guarantor Guarantor { get; set; }
    }
}
