using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class TenantCommunication
    {
        public int TenantId { get; set; }
        public int CommunicationId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("CommunicationId")]
        [InverseProperty("TenantCommunications")]
        public Communication Communication { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("TenantCommunications")]
        public Tenant Tenant { get; set; }
    }
}
