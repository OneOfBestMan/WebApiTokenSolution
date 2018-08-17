using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LettingInstructions", Schema = "letting")]
    public partial class LettingInstruction
    {
        public int Id { get; set; }
        [StringLength(1)]
        public string ApprovedByLandlord { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Commences { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expires { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal MarketedRentWholeProperty { get; set; }
        [Required]
        [StringLength(10)]
        public string MarketedRentFrequency { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal MarketedRentPerPerson { get; set; }
        [Required]
        [StringLength(1)]
        public string LetIndividualRooms { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public int? LandlordsPropertiesId { get; set; }

        [ForeignKey("LandlordsPropertiesId")]
        [InverseProperty("LettingInstructions")]
        public PropertysLandlordHistory LandlordsProperties { get; set; }
    }
}
