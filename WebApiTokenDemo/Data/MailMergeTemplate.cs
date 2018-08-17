using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class MailMergeTemplate
    {
        public MailMergeTemplate()
        {
            DebtRecoveryActionMethods = new HashSet<DebtRecoveryActionMethod>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        public int DataModelId { get; set; }
        public bool TitleHtmlIndi { get; set; }
        public bool BodyHtmlIndi { get; set; }
        public int? TitleLayoutId { get; set; }
        public int? BodyLayoutId { get; set; }
        [Required]
        [StringLength(255)]
        public string TitleText { get; set; }
        [Required]
        public string BodyText { get; set; }
        public bool ActiveRecordIndi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Validated { get; set; }

        [ForeignKey("BodyLayoutId")]
        [InverseProperty("MailMergeTemplateBodyLayouts")]
        public MailMergeTemplateLayout BodyLayout { get; set; }
        [ForeignKey("DataModelId")]
        [InverseProperty("MailMergeTemplates")]
        public MailMergeTemplateDataModel DataModel { get; set; }
        [ForeignKey("TitleLayoutId")]
        [InverseProperty("MailMergeTemplateTitleLayouts")]
        public MailMergeTemplateLayout TitleLayout { get; set; }
        [InverseProperty("MailMergeTemplate")]
        public ICollection<DebtRecoveryActionMethod> DebtRecoveryActionMethods { get; set; }
    }
}
