using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class MailMergeTemplateDataModel
    {
        public MailMergeTemplateDataModel()
        {
            MailMergeTemplates = new HashSet<MailMergeTemplate>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }

        [InverseProperty("DataModel")]
        public ICollection<MailMergeTemplate> MailMergeTemplates { get; set; }
    }
}
