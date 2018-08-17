using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class BranchsApplicant
    {
        public int BranchId { get; set; }
        public int ApplicantId { get; set; }
        public bool CreatedByThisBranch { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ApplicantId")]
        [InverseProperty("BranchsApplicants")]
        public Applicant Applicant { get; set; }
        [ForeignKey("BranchId")]
        [InverseProperty("BranchsApplicants")]
        public Branch Branch { get; set; }
    }
}
