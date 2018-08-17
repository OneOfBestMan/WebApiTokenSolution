using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Applicant
    {
        public Applicant()
        {
            BranchsApplicants = new HashSet<BranchsApplicant>();
        }

        public int Id { get; set; }
        [StringLength(50)]
        public string Firstname { get; set; }
        [StringLength(50)]
        public string Middlenames { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [StringLength(1)]
        public string Gender { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(15)]
        public string MobileNo { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Applicant")]
        public ICollection<BranchsApplicant> BranchsApplicants { get; set; }
    }
}
