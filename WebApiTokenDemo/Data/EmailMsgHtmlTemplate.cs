using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class EmailMsgHtmlTemplate
    {
        public EmailMsgHtmlTemplate()
        {
            DebtChaseMethods = new HashSet<DebtChaseMethod>();
        }

        public int EmailMsgHtmlTemplateId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string PreMsgChars { get; set; }
        [Required]
        public string PostMsgChars { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("EmailMsgHtmlTemplate")]
        public ICollection<DebtChaseMethod> DebtChaseMethods { get; set; }
    }
}
