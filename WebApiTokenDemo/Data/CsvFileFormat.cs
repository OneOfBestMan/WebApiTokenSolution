using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class CsvFileFormat
    {
        public CsvFileFormat()
        {
            BankAccounts = new HashSet<BankAccount>();
            UploadedBankStatementFiles = new HashSet<UploadedBankStatementFile>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("DefaultCsvFileFormat")]
        public ICollection<BankAccount> BankAccounts { get; set; }
        [InverseProperty("CsvFileFormat")]
        public ICollection<UploadedBankStatementFile> UploadedBankStatementFiles { get; set; }
    }
}
