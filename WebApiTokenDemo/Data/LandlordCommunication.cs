using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class LandlordCommunication
    {
        public int LandlordId { get; set; }
        public int CommunicationId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("CommunicationId")]
        [InverseProperty("LandlordCommunications")]
        public Communication Communication { get; set; }
        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordCommunications")]
        public Landlord Landlord { get; set; }
    }
}
