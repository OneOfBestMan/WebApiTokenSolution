using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class MailMergeTemplateLayout
    {
        public MailMergeTemplateLayout()
        {
            MailMergeTemplateBodyLayouts = new HashSet<MailMergeTemplate>();
            MailMergeTemplateTitleLayouts = new HashSet<MailMergeTemplate>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }

        [InverseProperty("BodyLayout")]
        public ICollection<MailMergeTemplate> MailMergeTemplateBodyLayouts { get; set; }
        [InverseProperty("TitleLayout")]
        public ICollection<MailMergeTemplate> MailMergeTemplateTitleLayouts { get; set; }
    }
}
