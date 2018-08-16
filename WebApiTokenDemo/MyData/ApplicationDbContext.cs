using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApiTokenDemo.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
    }

    #region Models
    //public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    //public DbSet<Tenant> Tenants { get; set; } // Tenants
    //}
    #endregion

    #region Pocos
    //public partial class Tenant
    //{
    //    public int Id { get; set; } // Id (Primary key)
    //    public string Alias { get; set; } // Alias (length: 20)
    //    public int TenantTypeId { get; set; } // TenantTypeId
    //    public string Title { get; set; } // Title (length: 10)
    //    public string Firstname { get; set; } // Firstname (length: 50)
    //    public string Middlenames { get; set; } // Middlenames (length: 50)
    //    public string Lastname { get; set; } // Lastname (length: 50)
    //    public string StatusCode { get; set; } // StatusCode (length: 1)
    //    public string Gender { get; set; } // Gender (length: 1)
    //    public System.DateTime? Dob { get; set; } // Dob
    //    public string MobileNo { get; set; } // MobileNo (length: 15)
    //    public bool? MobileNoConfirmed { get; set; } // MobileNoConfirmed
    //    public string MobileNo2Name { get; set; } // MobileNo2Name (length: 50)
    //    public string MobileNo2 { get; set; } // MobileNo2 (length: 15)
    //    public string Email { get; set; } // Email (length: 255)
    //    public bool? EmailConfirmed { get; set; } // EmailConfirmed
    //    public string Email2Name { get; set; } // Email2Name (length: 50)
    //    public string Email2 { get; set; } // Email2 (length: 255)
    //    public int? NationalityId { get; set; } // NationalityId
    //    public bool? EmailLetters { get; set; } // EmailLetters
    //    public bool? MarketingOptOut { get; set; } // MarketingOptOut
    //    public string NationalInsurance { get; set; } // NationalInsurance (length: 50)
    //    public int? OracleTenantId { get; set; } // OracleTenantId
    //    public System.DateTime? FirstTenancyDate { get; set; } // FirstTenancyDate
    //    public string FirstTenancyRef { get; set; } // FirstTenancyRef (length: 50)
    //    public string FirstTenancyLetBy { get; set; } // FirstTenancyLetBy (length: 50)
    //    public string ConfidentialNotes { get; set; } // ConfidentialNotes (length: 2000)
    //    public string PayingOwnRent { get; set; } // PayingOwnRent (length: 1)
    //    public bool? ReceivingStudentLoan { get; set; } // ReceivingStudentLoan
    //    public bool? ReceivingHousingBenefit { get; set; } // ReceivingHousingBenefit
    //    public string StandardPaymentRef { get; set; } // StandardPaymentRef (length: 25)
    //    public byte[] RowVersion { get; set; } // RowVersion (length: 8)
    //    public string BusinessName { get; set; } // BusinessName (length: 50)
    //    public string ComputedName { get; set; } // ComputedName (length: 113)
    //    public bool ActiveRecordIndi { get; set; } // ActiveRecordIndi

    //    //// Reverse navigation
    //    //public virtual System.Collections.Generic.ICollection<AutoTransferPlan> AutoTransferPlans { get; set; } // AutoTransferPlans.FK_AutoTransferPlans_Tenants
    //    //public virtual System.Collections.Generic.ICollection<BankDetail> BankDetails { get; set; } // BankDetails.FK_BankDetails_Tenants
    //    //public virtual System.Collections.Generic.ICollection<BranchsTenant> BranchsTenants { get; set; } // Many to many mapping
    //    //public virtual System.Collections.Generic.ICollection<MaintenanceJob> MaintenanceJobs { get; set; } // MaintenanceJobs.FK_MaintenanceJobs_Tenants
    //    //public virtual System.Collections.Generic.ICollection<NextOfKin> NextOfKins { get; set; } // NextOfKins.FK_NextOfKins_Tenants
    //    //public virtual System.Collections.Generic.ICollection<Payee> Payees { get; set; } // Payees.FK_Payees_Tenants
    //    //public virtual System.Collections.Generic.ICollection<TempDataTenantPayment> TempDataTenantPayments { get; set; } // TempDataTenantPayments.FK_TempDataRentPayments_Tenants
    //    //public virtual System.Collections.Generic.ICollection<TenantCommunication> TenantCommunications { get; set; } // Many to many mapping
    //    //public virtual System.Collections.Generic.ICollection<TenantLedgerTransaction> TenantLedgerTransactions { get; set; } // Many to many mapping
    //    //public virtual System.Collections.Generic.ICollection<TenantNote> TenantNotes { get; set; } // Many to many mapping
    //    //public virtual System.Collections.Generic.ICollection<TenantsMainAccount> TenantsMainAccounts { get; set; } // TenantsMainAccounts.FK_TenantsMainAccounts_Tenants
    //    //public virtual System.Collections.Generic.ICollection<TenantsTenancyAgreement> TenantsTenancyAgreements { get; set; } // Many to many mapping
    //    //public virtual TenantUserAccessProfile TenantUserAccessProfile { get; set; } // TenantUserAccessProfiles.FK_TenantUserAccessProfiles_Tenants

    //    //// Foreign keys
    //    //public virtual TenantStatusType TenantStatusType { get; set; } // FK_Tenants_TenantStatusTypes
    //    //public virtual TenantType TenantType { get; set; } // FK_Tenants_TenantTypes

    //    public Tenant()
    //    {
    //        //AutoTransferPlans = new List<AutoTransferPlan>();
    //        //BankDetails = new List<BankDetail>();
    //        //BranchsTenants = new List<BranchsTenant>();
    //        //MaintenanceJobs = new List<MaintenanceJob>();
    //        //NextOfKins = new List<NextOfKin>();
    //        //Payees = new List<Payee>();
    //        //TempDataTenantPayments = new List<TempDataTenantPayment>();
    //        //TenantCommunications = new List<TenantCommunication>();
    //        //TenantLedgerTransactions = new List<TenantLedgerTransaction>();
    //        //TenantNotes = new List<TenantNote>();
    //        //TenantsMainAccounts = new List<TenantsMainAccount>();
    //        //TenantsTenancyAgreements = new List<TenantsTenancyAgreement>();
    //        InitializePartial();
    //    }

    //    partial void InitializePartial();
    //}
    #endregion

    #region Mappings
    //public partial class TenantMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tenant>
    //{
    //    public TenantMap()
    //        : this("letting")
    //    {
    //    }

    //    public TenantMap(string schema)
    //    {
    //        ToTable(schema + ".Tenants");
    //        HasKey(x => x.Id);

    //        Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
    //        Property(x => x.Alias).HasColumnName("Alias").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
    //        Property(x => x.TenantTypeId).HasColumnName("TenantTypeId").IsRequired().HasColumnType("int");
    //        Property(x => x.Title).HasColumnName("Title").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
    //        Property(x => x.Firstname).HasColumnName("Firstname").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.Middlenames).HasColumnName("Middlenames").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.Lastname).HasColumnName("Lastname").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.StatusCode).HasColumnName("StatusCode").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
    //        Property(x => x.Gender).HasColumnName("Gender").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
    //        Property(x => x.Dob).HasColumnName("Dob").IsOptional().HasColumnType("date");
    //        Property(x => x.MobileNo).HasColumnName("MobileNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(15);
    //        Property(x => x.MobileNoConfirmed).HasColumnName("MobileNoConfirmed").IsOptional().HasColumnType("bit");
    //        Property(x => x.MobileNo2Name).HasColumnName("MobileNo2Name").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.MobileNo2).HasColumnName("MobileNo2").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(15);
    //        Property(x => x.Email).HasColumnName("Email").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(255);
    //        Property(x => x.EmailConfirmed).HasColumnName("EmailConfirmed").IsOptional().HasColumnType("bit");
    //        Property(x => x.Email2Name).HasColumnName("Email2Name").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.Email2).HasColumnName("Email2").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(255);
    //        Property(x => x.NationalityId).HasColumnName("NationalityId").IsOptional().HasColumnType("int");
    //        Property(x => x.EmailLetters).HasColumnName("EmailLetters").IsOptional().HasColumnType("bit");
    //        Property(x => x.MarketingOptOut).HasColumnName("MarketingOptOut").IsOptional().HasColumnType("bit");
    //        Property(x => x.NationalInsurance).HasColumnName("NationalInsurance").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.OracleTenantId).HasColumnName("OracleTenantId").IsOptional().HasColumnType("int");
    //        Property(x => x.FirstTenancyDate).HasColumnName("FirstTenancyDate").IsOptional().HasColumnType("date");
    //        Property(x => x.FirstTenancyRef).HasColumnName("FirstTenancyRef").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.FirstTenancyLetBy).HasColumnName("FirstTenancyLetBy").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.ConfidentialNotes).HasColumnName("ConfidentialNotes").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(2000);
    //        Property(x => x.PayingOwnRent).HasColumnName("PayingOwnRent").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(1);
    //        Property(x => x.ReceivingStudentLoan).HasColumnName("ReceivingStudentLoan").IsOptional().HasColumnType("bit");
    //        Property(x => x.ReceivingHousingBenefit).HasColumnName("ReceivingHousingBenefit").IsOptional().HasColumnType("bit");
    //        Property(x => x.StandardPaymentRef).HasColumnName("StandardPaymentRef").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(25);
    //        Property(x => x.RowVersion).HasColumnName("RowVersion").IsRequired().IsFixedLength().HasColumnType("timestamp").HasMaxLength(8).IsRowVersion().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
    //        Property(x => x.BusinessName).HasColumnName("BusinessName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
    //        Property(x => x.ComputedName).HasColumnName("ComputedName").IsOptional().HasColumnType("nvarchar").HasMaxLength(113).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
    //        Property(x => x.ActiveRecordIndi).HasColumnName("ActiveRecordIndi").IsRequired().HasColumnType("bit");

    //        // Foreign keys
    //        HasRequired(a => a.TenantStatusType).WithMany(b => b.Tenants).HasForeignKey(c => c.StatusCode); // FK_Tenants_TenantStatusTypes
    //        HasRequired(a => a.TenantType).WithMany(b => b.Tenants).HasForeignKey(c => c.TenantTypeId); // FK_Tenants_TenantTypes
    //        InitializePartial();
    //    }
    //    partial void InitializePartial();
    //}


    #endregion

}
