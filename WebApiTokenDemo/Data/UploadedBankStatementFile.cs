using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("UploadedBankStatementFiles", Schema = "banking")]
    public partial class UploadedBankStatementFile
    {
        public UploadedBankStatementFile()
        {
            BankStatementTransactions = new HashSet<BankStatementTransaction>();
        }

        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public int CsvFileFormatId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateRangeFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateRangeTo { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? OpeningBalance { get; set; }
        [StringLength(1)]
        public string RowOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [StringLength(255)]
        public string BaseDir { get; set; }
        [StringLength(255)]
        public string FileDir { get; set; }
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(50)]
        public string FileType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InspectionTimestamp { get; set; }
        [StringLength(255)]
        public string InspectionOutcome { get; set; }
        public int? TotalRows { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstRowDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastRowDate { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? FirstRowBalance { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? LastRowBalance { get; set; }
        [StringLength(1000)]
        public string GeneratedBankTxRows { get; set; }
        [StringLength(1000)]
        public string NonGeneratedBankTxRows { get; set; }
        [StringLength(1000)]
        public string PossibleDuplicates { get; set; }
        [StringLength(1000)]
        public string ConfirmedNonDuplicates { get; set; }
        [StringLength(1000)]
        public string ConfirmedDuplicates { get; set; }
        public int? DuplicateCompareMaxLength { get; set; }
        public bool ProcessingComplete { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BankAccountId")]
        [InverseProperty("UploadedBankStatementFiles")]
        public BankAccount BankAccount { get; set; }
        [ForeignKey("CsvFileFormatId")]
        [InverseProperty("UploadedBankStatementFiles")]
        public CsvFileFormat CsvFileFormat { get; set; }
        [InverseProperty("UploadedBankTransactionFile")]
        public ICollection<BankStatementTransaction> BankStatementTransactions { get; set; }
    }
}
