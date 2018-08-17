using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertysLandlordHistories", Schema = "letting")]
    public partial class PropertysLandlordHistory
    {
        public PropertysLandlordHistory()
        {
            LandlordsPropertyHistories = new HashSet<LandlordsPropertyHistory>();
            LettingInstructions = new HashSet<LettingInstruction>();
            TenancyAgreements = new HashSet<TenancyAgreement>();
        }

        public int Id { get; set; }
        public int PropertyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime From { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? To { get; set; }
        public int? MainContact { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("MainContact,Id")]
        [InverseProperty("PropertysLandlordHistories")]
        public LandlordsPropertyHistory LandlordsPropertyHistory { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("PropertysLandlordHistories")]
        public Property Property { get; set; }
        [InverseProperty("PropertysLandlordHistory")]
        public ICollection<LandlordsPropertyHistory> LandlordsPropertyHistories { get; set; }
        [InverseProperty("LandlordsProperties")]
        public ICollection<LettingInstruction> LettingInstructions { get; set; }
        [InverseProperty("LandlordsProperties")]
        public ICollection<TenancyAgreement> TenancyAgreements { get; set; }
    }
}
