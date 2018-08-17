using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApiTokenDemo.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accommodation> Accommodations { get; set; }
        public virtual DbSet<AccommodationType> AccommodationTypes { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<AuditLogDetail> AuditLogDetails { get; set; }
        public virtual DbSet<AuditTableHistory> AuditTableHistories { get; set; }
        public virtual DbSet<AutoChargingEvent> AutoChargingEvents { get; set; }
        public virtual DbSet<AutoTransferPlan> AutoTransferPlans { get; set; }
        public virtual DbSet<AutoTransferPlanType> AutoTransferPlanTypes { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BankDeposit> BankDeposits { get; set; }
        public virtual DbSet<BankDetail> BankDetails { get; set; }
        public virtual DbSet<BankLedgerTransactionType> BankLedgerTransactionTypes { get; set; }
        public virtual DbSet<BankPaymentReference> BankPaymentReferences { get; set; }
        public virtual DbSet<BankStatementLedgerTransaction> BankStatementLedgerTransactions { get; set; }
        public virtual DbSet<BankStatementTransaction> BankStatementTransactions { get; set; }
        public virtual DbSet<BankTransactionStatu> BankTransactionStatuses { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchsApplicant> BranchsApplicants { get; set; }
        public virtual DbSet<BranchsContractor> BranchsContractors { get; set; }
        public virtual DbSet<BranchsLandlord> BranchsLandlords { get; set; }
        public virtual DbSet<BranchsLedger> BranchsLedgers { get; set; }
        public virtual DbSet<BranchsProperty> BranchsProperties { get; set; }
        public virtual DbSet<BranchsTenant> BranchsTenants { get; set; }
        public virtual DbSet<BranchTenantDebtPreference> BranchTenantDebtPreferences { get; set; }
        public virtual DbSet<Communication> Communications { get; set; }
        public virtual DbSet<CommunicationCategory> CommunicationCategories { get; set; }
        public virtual DbSet<CommunicationNote> CommunicationNotes { get; set; }
        public virtual DbSet<CommunicationType> CommunicationTypes { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanysSpecialLedger> CompanysSpecialLedgers { get; set; }
        public virtual DbSet<CompanysSpecialLedgerType> CompanysSpecialLedgerTypes { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<ContractorCommunication> ContractorCommunications { get; set; }
        public virtual DbSet<ContractorDeductionAccount> ContractorDeductionAccounts { get; set; }
        public virtual DbSet<ContractorInvoice> ContractorInvoices { get; set; }
        public virtual DbSet<ContractorInvoiceItem> ContractorInvoiceItems { get; set; }
        public virtual DbSet<ContractorInvoiceItemCostAllocation> ContractorInvoiceItemCostAllocations { get; set; }
        public virtual DbSet<ContractorInvoiceItemCostAllocationLedgerTransaction> ContractorInvoiceItemCostAllocationLedgerTransactions { get; set; }
        public virtual DbSet<ContractorInvoiceNote> ContractorInvoiceNotes { get; set; }
        public virtual DbSet<ContractorInvoiceStage> ContractorInvoiceStages { get; set; }
        public virtual DbSet<ContractorInvoiceType> ContractorInvoiceTypes { get; set; }
        public virtual DbSet<ContractorNote> ContractorNotes { get; set; }
        public virtual DbSet<ContractorsArea> ContractorsAreas { get; set; }
        public virtual DbSet<ContractorsMainAccount> ContractorsMainAccounts { get; set; }
        public virtual DbSet<ContractorsPendingPaymentAccount> ContractorsPendingPaymentAccounts { get; set; }
        public virtual DbSet<ContractorType> ContractorTypes { get; set; }
        public virtual DbSet<ContractorUserAccessProfile> ContractorUserAccessProfiles { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CsvFileFormat> CsvFileFormats { get; set; }
        public virtual DbSet<DebtChaseMethod> DebtChaseMethods { get; set; }
        public virtual DbSet<DebtRecoveryAction> DebtRecoveryActions { get; set; }
        public virtual DbSet<DebtRecoveryActionAdhocMessage> DebtRecoveryActionAdhocMessages { get; set; }
        public virtual DbSet<DebtRecoveryActionCommunication> DebtRecoveryActionCommunications { get; set; }
        public virtual DbSet<DebtRecoveryActionMethod> DebtRecoveryActionMethods { get; set; }
        public virtual DbSet<DebtRecoveryActionNote> DebtRecoveryActionNotes { get; set; }
        public virtual DbSet<DebtRecoveryOperation> DebtRecoveryOperations { get; set; }
        public virtual DbSet<DebtRecoveryOperationCommunication> DebtRecoveryOperationCommunications { get; set; }
        public virtual DbSet<DebtRecoveryOperationNote> DebtRecoveryOperationNotes { get; set; }
        public virtual DbSet<EmailMsgHtmlTemplate> EmailMsgHtmlTemplates { get; set; }
        public virtual DbSet<EmailSmtpClient> EmailSmtpClients { get; set; }
        public virtual DbSet<ExternalUserProfile> ExternalUserProfiles { get; set; }
        public virtual DbSet<ExtUserTenantCheckOutForm> ExtUserTenantCheckOutForms { get; set; }
        public virtual DbSet<Guarantor> Guarantors { get; set; }
        public virtual DbSet<GuarantorCommunication> GuarantorCommunications { get; set; }
        public virtual DbSet<GuarantorNote> GuarantorNotes { get; set; }
        public virtual DbSet<GuarantorUserAccessProfile> GuarantorUserAccessProfiles { get; set; }
        public virtual DbSet<HistoricalBankStatementTran> HistoricalBankStatementTrans { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<InternalUserProfile> InternalUserProfiles { get; set; }
        public virtual DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<Key> Keys { get; set; }
        public virtual DbSet<KeyBunch> KeyBunches { get; set; }
        public virtual DbSet<KeyBunchKey> KeyBunchKeys { get; set; }
        public virtual DbSet<KeyCollectionInstruction> KeyCollectionInstructions { get; set; }
        public virtual DbSet<KeyMasterSet> KeyMasterSets { get; set; }
        public virtual DbSet<KeyReturnInstruction> KeyReturnInstructions { get; set; }
        public virtual DbSet<Landlord> Landlords { get; set; }
        public virtual DbSet<LandlordCommunication> LandlordCommunications { get; set; }
        public virtual DbSet<LandlordLedgerTransaction> LandlordLedgerTransactions { get; set; }
        public virtual DbSet<LandlordNote> LandlordNotes { get; set; }
        public virtual DbSet<LandlordsContractorPaymentAccount> LandlordsContractorPaymentAccounts { get; set; }
        public virtual DbSet<LandlordsContractorPendingPaymentAccount> LandlordsContractorPendingPaymentAccounts { get; set; }
        public virtual DbSet<LandlordsFloatAccount> LandlordsFloatAccounts { get; set; }
        public virtual DbSet<LandlordsMainAccount> LandlordsMainAccounts { get; set; }
        public virtual DbSet<LandlordsPropertyHistory> LandlordsPropertyHistories { get; set; }
        public virtual DbSet<LandlordUserAccessProfile> LandlordUserAccessProfiles { get; set; }
        public virtual DbSet<Ledger> Ledgers { get; set; }
        public virtual DbSet<LedgerAccountType> LedgerAccountTypes { get; set; }
        public virtual DbSet<LedgerCategory> LedgerCategories { get; set; }
        public virtual DbSet<LedgerMainAccount> LedgerMainAccounts { get; set; }
        public virtual DbSet<LedgerNote> LedgerNotes { get; set; }
        public virtual DbSet<LedgerTransaction> LedgerTransactions { get; set; }
        public virtual DbSet<LedgerTransactionBatch> LedgerTransactionBatches { get; set; }
        public virtual DbSet<LedgerTransactionBatchLink> LedgerTransactionBatchLinks { get; set; }
        public virtual DbSet<LedgerTransactionGroup> LedgerTransactionGroups { get; set; }
        public virtual DbSet<LedgerTransactionGroupType> LedgerTransactionGroupTypes { get; set; }
        public virtual DbSet<LedgerTransactionStage> LedgerTransactionStages { get; set; }
        public virtual DbSet<LedgerTransactionType> LedgerTransactionTypes { get; set; }
        public virtual DbSet<LedgerTransactionTypeCategory> LedgerTransactionTypeCategories { get; set; }
        public virtual DbSet<LedgerTransactionTypeValidPayeeLedgerAccountType> LedgerTransactionTypeValidPayeeLedgerAccountTypes { get; set; }
        public virtual DbSet<LedgerTransactionTypeValidRecipientLedgerAccountType> LedgerTransactionTypeValidRecipientLedgerAccountTypes { get; set; }
        public virtual DbSet<LedgerType> LedgerTypes { get; set; }
        public virtual DbSet<LettingInstruction> LettingInstructions { get; set; }
        public virtual DbSet<LinkedPaymentTransaction> LinkedPaymentTransactions { get; set; }
        public virtual DbSet<MailMergeTemplate> MailMergeTemplates { get; set; }
        public virtual DbSet<MailMergeTemplateDataModel> MailMergeTemplateDataModels { get; set; }
        public virtual DbSet<MailMergeTemplateLayout> MailMergeTemplateLayouts { get; set; }
        public virtual DbSet<MaintenanceJob> MaintenanceJobs { get; set; }
        public virtual DbSet<MaintenanceJobPriority> MaintenanceJobPriorities { get; set; }
        public virtual DbSet<MaintenanceJobStatu> MaintenanceJobStatuses { get; set; }
        public virtual DbSet<MaintenanceJobType> MaintenanceJobTypes { get; set; }
        public virtual DbSet<MaintenancePreference> MaintenancePreferences { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<NextOfKin> NextOfKins { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NoteType> NoteTypes { get; set; }
        public virtual DbSet<OfficeCashStorageAccount> OfficeCashStorageAccounts { get; set; }
        public virtual DbSet<OfficeCashStorageAccountsBankDeposit> OfficeCashStorageAccountsBankDeposits { get; set; }
        public virtual DbSet<OfficeChequeStorageAccount> OfficeChequeStorageAccounts { get; set; }
        public virtual DbSet<OfficeChequeStorageAccountsBankDeposit> OfficeChequeStorageAccountsBankDeposits { get; set; }
        public virtual DbSet<OracleLedgerTransaction> OracleLedgerTransactions { get; set; }
        public virtual DbSet<Payee> Payees { get; set; }
        public virtual DbSet<PayeeUserAccessProfile> PayeeUserAccessProfiles { get; set; }
        public virtual DbSet<PaymentPlan> PaymentPlans { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PdqAccount> PdqAccounts { get; set; }
        public virtual DbSet<PdqAccountsBankDeposit> PdqAccountsBankDeposits { get; set; }
        public virtual DbSet<PendingPaymentsToPayAccount> PendingPaymentsToPayAccounts { get; set; }
        public virtual DbSet<PendingPaymentsToReceiveAccount> PendingPaymentsToReceiveAccounts { get; set; }
        public virtual DbSet<PeriodFrequencyType> PeriodFrequencyTypes { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyBlock> PropertyBlocks { get; set; }
        public virtual DbSet<PropertyEnergyPerformanceCertificate> PropertyEnergyPerformanceCertificates { get; set; }
        public virtual DbSet<PropertyFacility> PropertyFacilities { get; set; }
        public virtual DbSet<PropertyFacilityType> PropertyFacilityTypes { get; set; }
        public virtual DbSet<PropertyInspection> PropertyInspections { get; set; }
        public virtual DbSet<PropertyInspectionType> PropertyInspectionTypes { get; set; }
        public virtual DbSet<PropertyInventoryItem> PropertyInventoryItems { get; set; }
        public virtual DbSet<PropertyInventoryItemCondition> PropertyInventoryItemConditions { get; set; }
        public virtual DbSet<PropertyInventoryItemInspectionCondition> PropertyInventoryItemInspectionConditions { get; set; }
        public virtual DbSet<PropertyInventoryItemType> PropertyInventoryItemTypes { get; set; }
        public virtual DbSet<PropertyLedgerTransaction> PropertyLedgerTransactions { get; set; }
        public virtual DbSet<PropertyMaintenanceCertificate> PropertyMaintenanceCertificates { get; set; }
        public virtual DbSet<PropertyMaintenanceCertificateHistory> PropertyMaintenanceCertificateHistories { get; set; }
        public virtual DbSet<PropertyMaintenanceCertificateType> PropertyMaintenanceCertificateTypes { get; set; }
        public virtual DbSet<PropertyNote> PropertyNotes { get; set; }
        public virtual DbSet<PropertysLandlordHistory> PropertysLandlordHistories { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<PropertyUtilityMeter> PropertyUtilityMeters { get; set; }
        public virtual DbSet<PropertyUtilityMeterReading> PropertyUtilityMeterReadings { get; set; }
        public virtual DbSet<PropertyUtilityMeterType> PropertyUtilityMeterTypes { get; set; }
        public virtual DbSet<RefCode> RefCodes { get; set; }
        public virtual DbSet<RefCodeDomain> RefCodeDomains { get; set; }
        public virtual DbSet<RentChargeSchedule> RentChargeSchedules { get; set; }
        public virtual DbSet<SalesAccount> SalesAccounts { get; set; }
        public virtual DbSet<SelectionFilter> SelectionFilters { get; set; }
        public virtual DbSet<SelectionFiltersRecord> SelectionFiltersRecords { get; set; }
        public virtual DbSet<SelectionFilterType> SelectionFilterTypes { get; set; }
        public virtual DbSet<SpreadsheetDepositReturnFormResponse> SpreadsheetDepositReturnFormResponses { get; set; }
        public virtual DbSet<SpreadsheetKeyCollectionFormResponse> SpreadsheetKeyCollectionFormResponses { get; set; }
        public virtual DbSet<SystemDatum> SystemDatas { get; set; }
        public virtual DbSet<TempDataHousingBenefitPayment> TempDataHousingBenefitPayments { get; set; }
        public virtual DbSet<TempDataTenantPayment> TempDataTenantPayments { get; set; }
        public virtual DbSet<TempEndOfTenancyCharge> TempEndOfTenancyCharges { get; set; }
        public virtual DbSet<TenancyAgreement> TenancyAgreements { get; set; }
        public virtual DbSet<TenancyAgreementAdditionalTerm> TenancyAgreementAdditionalTerms { get; set; }
        public virtual DbSet<TenancyAgreementGeneralAccount> TenancyAgreementGeneralAccounts { get; set; }
        public virtual DbSet<TenancyAgreementLeadTenant> TenancyAgreementLeadTenants { get; set; }
        public virtual DbSet<TenancyAgreementLedgerTransaction> TenancyAgreementLedgerTransactions { get; set; }
        public virtual DbSet<TenancyAgreementNote> TenancyAgreementNotes { get; set; }
        public virtual DbSet<TenancyAgreementPayee> TenancyAgreementPayees { get; set; }
        public virtual DbSet<TenancyAgreementRentCollectedAccount> TenancyAgreementRentCollectedAccounts { get; set; }
        public virtual DbSet<TenancyAgreementStage> TenancyAgreementStages { get; set; }
        public virtual DbSet<TenancyDepositProtectionScheme> TenancyDepositProtectionSchemes { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<TenantCommunication> TenantCommunications { get; set; }
        public virtual DbSet<TenantLedgerTransaction> TenantLedgerTransactions { get; set; }
        public virtual DbSet<TenantNote> TenantNotes { get; set; }
        public virtual DbSet<TenantsMainAccount> TenantsMainAccounts { get; set; }
        public virtual DbSet<TenantStatusType> TenantStatusTypes { get; set; }
        public virtual DbSet<TenantsTenancyAgreement> TenantsTenancyAgreements { get; set; }
        public virtual DbSet<TenantsTenancyAgreementLedgerTransaction> TenantsTenancyAgreementLedgerTransactions { get; set; }
        public virtual DbSet<TenantsTenancyAgreementNote> TenantsTenancyAgreementNotes { get; set; }
        public virtual DbSet<TenantsTenancyDepositHeldAccount> TenantsTenancyDepositHeldAccounts { get; set; }
        public virtual DbSet<TenantsTenancyGuaranteedRentAccount> TenantsTenancyGuaranteedRentAccounts { get; set; }
        public virtual DbSet<TenantsTenancyOutstandingDepositAccount> TenantsTenancyOutstandingDepositAccounts { get; set; }
        public virtual DbSet<TenantsTenancyOutstandingGeneralAccount> TenantsTenancyOutstandingGeneralAccounts { get; set; }
        public virtual DbSet<TenantsTenancyOutstandingRentAccount> TenantsTenancyOutstandingRentAccounts { get; set; }
        public virtual DbSet<TenantType> TenantTypes { get; set; }
        public virtual DbSet<TenantUserAccessProfile> TenantUserAccessProfiles { get; set; }
        public virtual DbSet<TestDataSourceBanking> TestDataSourceBankings { get; set; }
        public virtual DbSet<TestDataSourceTransaction> TestDataSourceTransactions { get; set; }
        public virtual DbSet<UploadedBankStatementFile> UploadedBankStatementFiles { get; set; }
        public virtual DbSet<UserAccessProfile> UserAccessProfiles { get; set; }
        public virtual DbSet<VatAccount> VatAccounts { get; set; }
        public virtual DbSet<VatLedgerTransaction> VatLedgerTransactions { get; set; }
        public virtual DbSet<VatRate> VatRates { get; set; }
        public virtual DbSet<VatType> VatTypes { get; set; }

        // Unable to generate entity type for table 'accounts.RecurringLedgerTransactionsCopy'. Please see the warning messages.
        // Unable to generate entity type for table 'temp.OriginalUserProfile'. Please see the warning messages.
        // Unable to generate entity type for table 'temp.OriginalUsers'. Please see the warning messages.
        // Unable to generate entity type for table 'temp.PropertyInventoryItems20180612'. Please see the warning messages.
        // Unable to generate entity type for table 'property.PropertyMaintenanceCertificates07Oct15Copy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempLedgers'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=.;Database=SmileProp;Integrated Security=true;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Accommodation>(entity =>
            {
                entity.Property(e => e.ActiveRecordIndi).HasDefaultValueSql("((1))");

                entity.Property(e => e.DescrGeneral).IsUnicode(false);

                entity.Property(e => e.DescrLetting).IsUnicode(false);

                entity.Property(e => e.DescrSale).IsUnicode(false);

                entity.Property(e => e.FloorDimensions).IsUnicode(false);

                entity.Property(e => e.FloorLevel).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.AccommodationType)
                    .WithMany(p => p.Accommodations)
                    .HasForeignKey(d => d.AccommodationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accommodation_AccommodationTypes");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Accommodations)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accommodation_Properties");
            });

            modelBuilder.Entity<AccommodationType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_AccommodationTypes")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Middlenames).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            //modelBuilder.Entity<AspNetRole>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("RoleNameIndex")
            //        .IsUnique();

            //    entity.Property(e => e.Id).ValueGeneratedNever();
            //});

            //modelBuilder.Entity<AspNetUser>(entity =>
            //{
            //    entity.HasIndex(e => e.ExternalUserProfilesId)
            //        .HasName("IX_ExternalUserProfiles_Id");

            //    entity.HasIndex(e => e.InternalUserProfilesId)
            //        .HasName("IX_InternalUserProfiles_Id");

            //    entity.HasIndex(e => e.UserName)
            //        .HasName("UserNameIndex")
            //        .IsUnique();

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.HasOne(d => d.ExternalUserProfiles)
            //        .WithMany(p => p.AspNetUsers)
            //        .HasForeignKey(d => d.ExternalUserProfilesId)
            //        .HasConstraintName("FK_dbo.AspNetUsers_dbo.ExternalUserProfiles_ExternalUserProfiles_Id");

            //    entity.HasOne(d => d.InternalUserProfiles)
            //        .WithMany(p => p.AspNetUsers)
            //        .HasForeignKey(d => d.InternalUserProfilesId)
            //        .HasConstraintName("FK_dbo.AspNetUsers_dbo.InternalUserProfiles_InternalUserProfiles_Id");
            //});

            //modelBuilder.Entity<AspNetUserClaim>(entity =>
            //{
            //    entity.HasIndex(e => e.UserId)
            //        .HasName("IX_UserId");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserClaims)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            //});

            //modelBuilder.Entity<AspNetUserLogin>(entity =>
            //{
            //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId });

            //    entity.HasIndex(e => e.UserId)
            //        .HasName("IX_UserId");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserLogins)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            //});

            //modelBuilder.Entity<AspNetUserRole>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.RoleId });

            //    entity.HasIndex(e => e.RoleId)
            //        .HasName("IX_RoleId");

            //    entity.HasIndex(e => e.UserId)
            //        .HasName("IX_UserId");

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.AspNetUserRoles)
            //        .HasForeignKey(d => d.RoleId)
            //        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserRoles)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            //});

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.AssetType).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditLogDetail>(entity =>
            {
                entity.HasIndex(e => e.AuditLogId)
                    .HasName("IX_AuditLogId");

                entity.HasOne(d => d.AuditLog)
                    .WithMany(p => p.AuditLogDetails)
                    .HasForeignKey(d => d.AuditLogId)
                    .HasConstraintName("FK_dbo.AuditLogDetails_dbo.AuditLogs_AuditLogId");
            });

            modelBuilder.Entity<AuditTableHistory>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.TableName).IsUnicode(false);

                entity.Property(e => e.TableSchema).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<AutoChargingEvent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<AutoTransferPlan>(entity =>
            {
                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.AutoTransferPlanType)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => d.AutoTransferPlanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoTransferPlans_AutoTransferPlanTypes");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => d.ContractorId)
                    .HasConstraintName("FK_AutoTransferPlans_Contractors");

                entity.HasOne(d => d.CreditLedger)
                    .WithMany(p => p.AutoTransferPlanCreditLedgers)
                    .HasForeignKey(d => d.CreditLedgerId)
                    .HasConstraintName("FK_AutoTransferPlans_Ledgers");

                entity.HasOne(d => d.DebitLedger)
                    .WithMany(p => p.AutoTransferPlanDebitLedgers)
                    .HasForeignKey(d => d.DebitLedgerId)
                    .HasConstraintName("FK_AutoTransferPlans_Ledgers1");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => d.LandlordId)
                    .HasConstraintName("FK_AutoTransferPlans_Landlords");

                entity.HasOne(d => d.PeriodFrequencyType)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => d.PeriodFrequencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoTransferPlans_PeriodFrequencyTypes");

                entity.HasOne(d => d.RentChargeSchedule)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => d.RentChargeScheduleId)
                    .HasConstraintName("FK_AutoTransferPlans_RentChargeSchedules");

                entity.HasOne(d => d.TenancyAgreement)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => d.TenancyAgreementId)
                    .HasConstraintName("FK_AutoTransferPlans_TenancyAgreements");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_AutoTransferPlans_Tenants");

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.AutoTransferPlans)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .HasConstraintName("FK_AutoTransferPlans_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<AutoTransferPlanType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UK_AutoTransferPlanTypes")
                    .IsUnique();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.IsOneOffPeriodFreqFromDateRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOneOffPeriodFreqToDateRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.Property(e => e.AccountNo).IsUnicode(false);

                entity.Property(e => e.ChequeBookFacility).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DebitCardFacility).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SortCode).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.AccountLedger)
                    .WithMany(p => p.BankAccountAccountLedgers)
                    .HasForeignKey(d => d.AccountLedgerId)
                    .HasConstraintName("FK_BankAccounts_Ledgers");

                entity.HasOne(d => d.BankDepositControlAccountLedger)
                    .WithMany(p => p.BankAccountBankDepositControlAccountLedgers)
                    .HasForeignKey(d => d.BankDepositControlAccountLedgerId)
                    .HasConstraintName("FK_BankAccounts_Ledgers1");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankAccounts_Banks");

                entity.HasOne(d => d.DefaultCsvFileFormat)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.DefaultCsvFileFormatId)
                    .HasConstraintName("FK_BankAccounts_CsvFileFormats");

                entity.HasOne(d => d.UnidentifiedBankTxControlAccountLedger)
                    .WithMany(p => p.BankAccountUnidentifiedBankTxControlAccountLedgers)
                    .HasForeignKey(d => d.UnidentifiedBankTxControlAccountLedgerId)
                    .HasConstraintName("FK_BankAccounts_Ledgers2");
            });

            modelBuilder.Entity<BankDeposit>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.BankDeposits)
                    .HasForeignKey(d => d.BankAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankDeposits_BankAccounts");

                entity.HasOne(d => d.ReconciledBankTxItem)
                    .WithMany(p => p.BankDeposits)
                    .HasForeignKey(d => d.ReconciledBankTxItemId)
                    .HasConstraintName("FK_BankDeposits_BankTransactions");
            });

            modelBuilder.Entity<BankDetail>(entity =>
            {
                entity.Property(e => e.AccountName).IsUnicode(false);

                entity.Property(e => e.AccountNo).IsUnicode(false);

                entity.Property(e => e.BankAddressLine1).IsUnicode(false);

                entity.Property(e => e.BankAddressLine2).IsUnicode(false);

                entity.Property(e => e.BankAddressLine3).IsUnicode(false);

                entity.Property(e => e.BankAddressLine4).IsUnicode(false);

                entity.Property(e => e.BankName).IsUnicode(false);

                entity.Property(e => e.BicSwiftCode).IsUnicode(false);

                entity.Property(e => e.Iban).IsUnicode(false);

                entity.Property(e => e.Postcode).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SortCode).IsUnicode(false);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.BankDetails)
                    .HasForeignKey(d => d.ContractorId)
                    .HasConstraintName("FK_BankDetails_Contractors");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.BankDetails)
                    .HasForeignKey(d => d.LandlordId)
                    .HasConstraintName("FK_BankDetails_Landlords");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.BankDetails)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_BankDetails_Tenants");
            });

            modelBuilder.Entity<BankLedgerTransactionType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_BankTransactionItemTypes")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<BankPaymentReference>(entity =>
            {
                entity.HasIndex(e => new { e.BankAccountId, e.Details, e.Amt })
                    .HasName("UK_TypicalBankTransactions")
                    .IsUnique();

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.BankPaymentReferences)
                    .HasForeignKey(d => d.BankAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankPaymentReferences_BankAccounts");

                entity.HasOne(d => d.ContraLedger)
                    .WithMany(p => p.BankPaymentReferences)
                    .HasForeignKey(d => d.ContraLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankPaymentReferences_Ledgers");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.BankPaymentReferences)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoMatchBankStatementTransactions_PaymentTypes");
            });

            modelBuilder.Entity<BankStatementLedgerTransaction>(entity =>
            {
                entity.Property(e => e.LedgerTransactionId).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.BankDeposit)
                    .WithMany(p => p.BankStatementLedgerTransactions)
                    .HasForeignKey(d => d.BankDepositId)
                    .HasConstraintName("FK_BankTransactionItems_BankDeposits");

                entity.HasOne(d => d.BankLedgerTransactionType)
                    .WithMany(p => p.BankStatementLedgerTransactions)
                    .HasForeignKey(d => d.BankLedgerTransactionTypeId)
                    .HasConstraintName("FK_BankTransactionItems_BankTransactionItemTypes");

                entity.HasOne(d => d.BankTransaction)
                    .WithMany(p => p.BankStatementLedgerTransactions)
                    .HasForeignKey(d => d.BankTransactionId)
                    .HasConstraintName("FK_BankTransactionItems_BankTransactions");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithOne(p => p.BankStatementLedgerTransaction)
                    .HasForeignKey<BankStatementLedgerTransaction>(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankTransactionItems_TransactionItems");
            });

            modelBuilder.Entity<BankStatementTransaction>(entity =>
            {
                entity.HasIndex(e => new { e.BankAccountId, e.Date })
                    .HasName("IX_BankTransactions_Used4DuplicateMatching");

                entity.HasIndex(e => new { e.UploadedBankTransactionFileId, e.RowWithinFile })
                    .HasName("idx_DCh_1285_1284_BankStatementTransactions");

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.MatchStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('New')");

                entity.Property(e => e.MatchedBy).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.BankStatementTransactions)
                    .HasForeignKey(d => d.BankAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankTransactions_BankAccounts");

                entity.HasOne(d => d.BankPaymentReferenceIdMatchNavigation)
                    .WithMany(p => p.BankStatementTransactions)
                    .HasForeignKey(d => d.BankPaymentReferenceIdMatch)
                    .HasConstraintName("FK_BankTransactions_AutoMatchBankStatementTransactions");

                entity.HasOne(d => d.LedgerIdMatchNavigation)
                    .WithMany(p => p.BankStatementTransactions)
                    .HasForeignKey(d => d.LedgerIdMatch)
                    .HasConstraintName("FK_BankTransactions_Ledgers");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.BankStatementTransactions)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_BankTransactions_PaymentTypes");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.BankStatementTransactions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankTransactions_BankTransactionStatus");

                entity.HasOne(d => d.UploadedBankTransactionFile)
                    .WithMany(p => p.BankStatementTransactions)
                    .HasForeignKey(d => d.UploadedBankTransactionFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankTransactions_UploadedBankTransactionFile");
            });

            modelBuilder.Entity<BankTransactionStatu>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_BankTransactionStatus")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Branches_Companies");
            });

            modelBuilder.Entity<BranchsApplicant>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.ApplicantId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.BranchsApplicants)
                    .HasForeignKey(d => d.ApplicantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsApplicants_Applicants");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchsApplicants)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsApplicants_Branches");
            });

            modelBuilder.Entity<BranchsContractor>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.ContractorId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchsContractors)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsContractors_Branches");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.BranchsContractors)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsContractors_Contractors");
            });

            modelBuilder.Entity<BranchsLandlord>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.LandlordId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchsLandlords)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BanchsLandlords_Branches");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.BranchsLandlords)
                    .HasForeignKey(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BanchsLandlords_Landlords");
            });

            modelBuilder.Entity<BranchsLedger>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.LedgerId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchsLedgers)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsLedgers_Branches");

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.BranchsLedgers)
                    .HasForeignKey(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsLedgers_Ledgers");
            });

            modelBuilder.Entity<BranchsProperty>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.PropertyId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchsProperties)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsProperties_Branches");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.BranchsProperties)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsProperties_Properties");
            });

            modelBuilder.Entity<BranchsTenant>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.TenantId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchsTenants)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsTenants_Branches");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.BranchsTenants)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchsTenants_Tenants");
            });

            modelBuilder.Entity<BranchTenantDebtPreference>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.LedgerAccountTypeId });

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchTenantDebtPreferences)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTenantDebtPreferences_Branches");

                entity.HasOne(d => d.LedgerAccountType)
                    .WithMany(p => p.BranchTenantDebtPreferences)
                    .HasForeignKey(d => d.LedgerAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchTenantDebtPreferences_LedgerAccountTypes");
            });

            modelBuilder.Entity<Communication>(entity =>
            {
                entity.Property(e => e.From).IsUnicode(false);

                entity.Property(e => e.Ref).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.CommunicationCategory)
                    .WithMany(p => p.Communications)
                    .HasForeignKey(d => d.CommunicationCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Communications_CommunicationCategories");

                entity.HasOne(d => d.CommunicationType)
                    .WithMany(p => p.Communications)
                    .HasForeignKey(d => d.CommunicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Communications_CommunicationTypes");
            });

            modelBuilder.Entity<CommunicationCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_CommunicationCategories")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<CommunicationNote>(entity =>
            {
                entity.HasKey(e => new { e.CommunicationId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.CommunicationNotes)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommunicationNotes_Communications");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.CommunicationNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommunicationNotes_Notes");
            });

            modelBuilder.Entity<CommunicationType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_CommunicationTypes")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<CompanysSpecialLedger>(entity =>
            {
                entity.HasIndex(e => new { e.LedgerId, e.BranchId })
                    .HasName("UK_CompanysSpecialLedger")
                    .IsUnique();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CompanysSpecialLedgers)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_CompanysSpecialLedgers_Branches");

                entity.HasOne(d => d.CompanysLedgerType)
                    .WithMany(p => p.CompanysSpecialLedgers)
                    .HasForeignKey(d => d.CompanysLedgerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanysSpecialLedgers_CompanysSpecialLedgerTypes");

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.CompanysSpecialLedgers)
                    .HasForeignKey(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanysSpecialLedgers_Ledgers");
            });

            modelBuilder.Entity<CompanysSpecialLedgerType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UK_CompanysSpecialLedgerType")
                    .IsUnique();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<Contractor>(entity =>
            {
                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.ConfidentialNotes).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Middlenames).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.NationalInsurance).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.ContractorType)
                    .WithMany(p => p.Contractors)
                    .HasForeignKey(d => d.ContractorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contractors_ContractorTypes");
            });

            modelBuilder.Entity<ContractorCommunication>(entity =>
            {
                entity.HasKey(e => new { e.ContractorId, e.CommunicationId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.ContractorCommunications)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorCommunications_Communications");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorCommunications)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorCommunications_Contractors");
            });

            modelBuilder.Entity<ContractorDeductionAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerMainAccountId)
                    .HasName("UK_ContractorDeductionAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.ContractorDeductionAccount)
                    .HasForeignKey<ContractorDeductionAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorDeductionAccounts_Ledgers");

                entity.HasOne(d => d.LedgerMainAccount)
                    .WithOne(p => p.ContractorDeductionAccount)
                    .HasForeignKey<ContractorDeductionAccount>(d => d.LedgerMainAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorDeductionAccounts_LedgerMainAccounts");
            });

            modelBuilder.Entity<ContractorInvoice>(entity =>
            {
                entity.HasIndex(e => e.LedgerTransactionGroupIdUk)
                    .HasName("UK_ContractorInvoices")
                    .IsUnique();

                entity.Property(e => e.LedgerTransactionGroupIdUk).HasComputedColumnSql("(case when [TransactionItemGroupId] IS NULL then  -((1)*[Id]) else [TransactionItemGroupId] end)");

                entity.Property(e => e.Ref).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.TypeId).IsUnicode(false);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorInvoices)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoices_Contractors");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.ContractorInvoices)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_ContractorInvoices_Properties");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.ContractorInvoices)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoices_ContractorInvoiceStages");

                entity.HasOne(d => d.TransactionItemGroup)
                    .WithMany(p => p.ContractorInvoices)
                    .HasForeignKey(d => d.TransactionItemGroupId)
                    .HasConstraintName("FK_ContractorInvoices_TransactionItemGroups");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContractorInvoices)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoices_ContractorInvoiceTypes");
            });

            modelBuilder.Entity<ContractorInvoiceItem>(entity =>
            {
                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.StatusId).IsUnicode(false);

                entity.HasOne(d => d.ContractorInvoice)
                    .WithMany(p => p.ContractorInvoiceItems)
                    .HasForeignKey(d => d.ContractorInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceItems_ContractorInvoices");

                entity.HasOne(d => d.TenancyAgreement)
                    .WithMany(p => p.ContractorInvoiceItems)
                    .HasForeignKey(d => d.TenancyAgreementId)
                    .HasConstraintName("FK_ContractorInvoiceItems_TenancyAgreements");
            });

            modelBuilder.Entity<ContractorInvoiceItemCostAllocation>(entity =>
            {
                entity.HasOne(d => d.ContraLedger)
                    .WithMany(p => p.ContractorInvoiceItemCostAllocations)
                    .HasForeignKey(d => d.ContraLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceItemCostAllocations_Ledgers");

                entity.HasOne(d => d.ContractorInvoiceItem)
                    .WithMany(p => p.ContractorInvoiceItemCostAllocations)
                    .HasForeignKey(d => d.ContractorInvoiceItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceItemLiabilities_ContractorInvoiceItems1");

                entity.HasOne(d => d.LedgerMainAccount)
                    .WithMany(p => p.ContractorInvoiceItemCostAllocations)
                    .HasForeignKey(d => d.LedgerMainAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceItemCostAllocations_LedgerMainAccounts");
            });

            modelBuilder.Entity<ContractorInvoiceItemCostAllocationLedgerTransaction>(entity =>
            {
                entity.HasKey(e => new { e.ContractorInvoiceItemCostAllocationId, e.LedgerTransactionId });

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.ContractorInvoiceItemCostAllocation)
                    .WithMany(p => p.ContractorInvoiceItemCostAllocationLedgerTransactions)
                    .HasForeignKey(d => d.ContractorInvoiceItemCostAllocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceItemCostAllocationsTransactionItems_ContractorInvoiceItemCostAllocations");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.ContractorInvoiceItemCostAllocationLedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceItemCostAllocationsTransactionItems_TransactionItems");
            });

            modelBuilder.Entity<ContractorInvoiceNote>(entity =>
            {
                entity.HasKey(e => new { e.ContractorInvoiceId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.ContractorInvoice)
                    .WithMany(p => p.ContractorInvoiceNotes)
                    .HasForeignKey(d => d.ContractorInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceNotes_ContractorInvoices");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.ContractorInvoiceNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorInvoiceNotes_Notes");
            });

            modelBuilder.Entity<ContractorInvoiceStage>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_ContractorInvoiceStages")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ContractorInvoiceType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_ContractorInvoiceTypes")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ContractorNote>(entity =>
            {
                entity.HasKey(e => new { e.ContractorId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorNotes)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorNotes_Contractors");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.ContractorNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorNotes_Notes");
            });

            modelBuilder.Entity<ContractorsArea>(entity =>
            {
                entity.HasKey(e => new { e.ContractorId, e.AreaId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.ContractorsAreas)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorsAreas_Areas");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorsAreas)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorsAreas_Contractors");
            });

            modelBuilder.Entity<ContractorsMainAccount>(entity =>
            {
                entity.HasIndex(e => e.ContractorId)
                    .HasName("UK_ContractorsMainAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Contractor)
                    .WithOne(p => p.ContractorsMainAccount)
                    .HasForeignKey<ContractorsMainAccount>(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorsMainAccounts_Contractors");

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.ContractorsMainAccount)
                    .HasForeignKey<ContractorsMainAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorsMainAccounts_LedgerMainAccounts");
            });

            modelBuilder.Entity<ContractorsPendingPaymentAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_ContractorsPendingPaymentAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorsPendingPaymentAccounts)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorsPendingPaymentAccounts_Contractors");

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.ContractorsPendingPaymentAccount)
                    .HasForeignKey<ContractorsPendingPaymentAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorsPendingPaymentAccounts_Ledgers");
            });

            modelBuilder.Entity<ContractorType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<ContractorUserAccessProfile>(entity =>
            {
                entity.HasIndex(e => e.UserAccessProfileId)
                    .HasName("UK_ContractorUserAccessProfiles")
                    .IsUnique();

                entity.Property(e => e.ContractorId).ValueGeneratedNever();

                entity.HasOne(d => d.Contractor)
                    .WithOne(p => p.ContractorUserAccessProfile)
                    .HasForeignKey<ContractorUserAccessProfile>(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorUserAccessProfiles_Contractors");

                entity.HasOne(d => d.UserAccessProfile)
                    .WithOne(p => p.ContractorUserAccessProfile)
                    .HasForeignKey<ContractorUserAccessProfile>(d => d.UserAccessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorUserAccessProfiles_UserAccessProfiles");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Alpha2).IsUnicode(false);

                entity.Property(e => e.Aplha3).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<CsvFileFormat>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_CsvFileFormats")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<DebtChaseMethod>(entity =>
            {
                entity.Property(e => e.MessageBody).IsUnicode(false);

                entity.Property(e => e.MessageDeliveryMethod).IsUnicode(false);

                entity.Property(e => e.MessageTitle).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.EmailMsgHtmlTemplate)
                    .WithMany(p => p.DebtChaseMethods)
                    .HasForeignKey(d => d.EmailMsgHtmlTemplateId)
                    .HasConstraintName("FK_DebtRecoveryStageTypes_EmailMsgHtmlTemplates");

                entity.HasOne(d => d.EmailSmtpClient)
                    .WithMany(p => p.DebtChaseMethods)
                    .HasForeignKey(d => d.EmailSmtpClientId)
                    .HasConstraintName("FK_DebtRecoveryStageTypes_EmailSmtpClients");
            });

            modelBuilder.Entity<DebtRecoveryAction>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.DebtChaseMethod)
                    .WithMany(p => p.DebtRecoveryActions)
                    .HasForeignKey(d => d.DebtChaseMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryActions_DebtChaseMethods");

                entity.HasOne(d => d.DebtRecoveryActionAdhocMessage)
                    .WithMany(p => p.DebtRecoveryActions)
                    .HasForeignKey(d => d.DebtRecoveryActionAdhocMessageId)
                    .HasConstraintName("FK_DebtRecoveryActions_DebtRecoveryActionAdhocMessages");

                entity.HasOne(d => d.DebtRecoveryActionMethod)
                    .WithMany(p => p.DebtRecoveryActions)
                    .HasForeignKey(d => d.DebtRecoveryActionMethodId)
                    .HasConstraintName("FK_DebtRecoveryActions_DebtRecoveryActionMethods");

                entity.HasOne(d => d.DebtRecoveryOperation)
                    .WithMany(p => p.DebtRecoveryActions)
                    .HasForeignKey(d => d.DebtRecoveryOperationId)
                    .HasConstraintName("FK_DebtRecoveryActions_DebtRecoveryActions");
            });

            modelBuilder.Entity<DebtRecoveryActionAdhocMessage>(entity =>
            {
                entity.Property(e => e.Message).IsUnicode(false);
            });

            modelBuilder.Entity<DebtRecoveryActionCommunication>(entity =>
            {
                entity.HasKey(e => new { e.DebtRecoveryActionId, e.CommunicationId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.DebtRecoveryActionCommunications)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryActionCommunications_Communications");

                entity.HasOne(d => d.DebtRecoveryAction)
                    .WithMany(p => p.DebtRecoveryActionCommunications)
                    .HasForeignKey(d => d.DebtRecoveryActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryActionCommunications_DebtRecoveryActions");
            });

            modelBuilder.Entity<DebtRecoveryActionMethod>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_DebtRecoveryActionMethods")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.ListingGroup).IsUnicode(false);

                entity.Property(e => e.MessageBody).IsUnicode(false);

                entity.Property(e => e.MessageDeliveryMethod).IsUnicode(false);

                entity.Property(e => e.MessageTitle).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.TargetGroup).IsUnicode(false);

                entity.HasOne(d => d.MailMergeTemplate)
                    .WithMany(p => p.DebtRecoveryActionMethods)
                    .HasForeignKey(d => d.MailMergeTemplateId)
                    .HasConstraintName("FK_DebtRecoveryActionMethods_MailMergeTemplates");
            });

            modelBuilder.Entity<DebtRecoveryActionNote>(entity =>
            {
                entity.HasKey(e => new { e.DebtRecoveryActionId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.DebtRecoveryAction)
                    .WithMany(p => p.DebtRecoveryActionNotes)
                    .HasForeignKey(d => d.DebtRecoveryActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryActionNotes_DebtRecoveryActions");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.DebtRecoveryActionNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryActionNotes_Notes");
            });

            modelBuilder.Entity<DebtRecoveryOperation>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("IX_DebtRecoveryOperations_SingleActive_LedgerID")
                    .IsUnique()
                    .HasFilter("([Active]=(1))");

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.DebtRecoveryOperation)
                    .HasForeignKey<DebtRecoveryOperation>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryOperations_LedgerMainAccounts");
            });

            modelBuilder.Entity<DebtRecoveryOperationCommunication>(entity =>
            {
                entity.HasKey(e => new { e.DebtRecoveryOperationId, e.CommunicationId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.DebtRecoveryOperationCommunications)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryOperationCommunications_Communications");

                entity.HasOne(d => d.DebtRecoveryOperation)
                    .WithMany(p => p.DebtRecoveryOperationCommunications)
                    .HasForeignKey(d => d.DebtRecoveryOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryOperationCommunications_DebtRecoveryOperations");
            });

            modelBuilder.Entity<DebtRecoveryOperationNote>(entity =>
            {
                entity.HasKey(e => new { e.DebtRecoveryOperationId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.DebtRecoveryOperation)
                    .WithMany(p => p.DebtRecoveryOperationNotes)
                    .HasForeignKey(d => d.DebtRecoveryOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryOperationNotes_DebtRecoveryOperations");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.DebtRecoveryOperationNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtRecoveryOperationNotes_Notes");
            });

            modelBuilder.Entity<EmailMsgHtmlTemplate>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_EmailMsgHtmlTemplates")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PostMsgChars).IsUnicode(false);

                entity.Property(e => e.PreMsgChars).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<EmailSmtpClient>(entity =>
            {
                entity.HasIndex(e => new { e.Host, e.Username })
                    .HasName("UK_EmailSmtpClients")
                    .IsUnique();

                entity.Property(e => e.FromDisplayName).IsUnicode(false);

                entity.Property(e => e.FromEmailAddress).IsUnicode(false);

                entity.Property(e => e.Host).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SignatureHtml).IsUnicode(false);

                entity.Property(e => e.SignatureText).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<ExternalUserProfile>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<ExtUserTenantCheckOutForm>(entity =>
            {
                entity.HasKey(e => new { e.TenancyAgreementId, e.TenantId });

                entity.Property(e => e.AccountName).IsUnicode(false);

                entity.Property(e => e.AccountNo).IsUnicode(false);

                entity.Property(e => e.AlternativeEmail).IsUnicode(false);

                entity.Property(e => e.AlternativeTelNo).IsUnicode(false);

                entity.Property(e => e.AlternativeTelNoDetails).IsUnicode(false);

                entity.Property(e => e.Bank).IsUnicode(false);

                entity.Property(e => e.BedroomFloor).IsUnicode(false);

                entity.Property(e => e.BedroomLocation).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FormAccessCode).IsUnicode(false);

                entity.Property(e => e.ForwardAddressCountry).IsUnicode(false);

                entity.Property(e => e.ForwardAddressLine1).IsUnicode(false);

                entity.Property(e => e.ForwardAddressLine2).IsUnicode(false);

                entity.Property(e => e.ForwardAddressPostcode).IsUnicode(false);

                entity.Property(e => e.ForwardAddressTown).IsUnicode(false);

                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.KeysMissing).IsUnicode(false);

                entity.Property(e => e.KeysMissingDetails).IsUnicode(false);

                entity.Property(e => e.KeysReturned).IsUnicode(false);

                entity.Property(e => e.KeysReturnedDamagedDetails).IsUnicode(false);

                entity.Property(e => e.KeysReturnedHow).IsUnicode(false);

                entity.Property(e => e.KeysReturnedHowOtherDetails).IsUnicode(false);

                entity.Property(e => e.KeysReturnedToWhom).IsUnicode(false);

                entity.Property(e => e.KeysReturnedToWhomOtherDetails).IsUnicode(false);

                entity.Property(e => e.KeysReturnedWhichDoors).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.Sortcode).IsUnicode(false);

                entity.HasOne(d => d.Tenan)
                    .WithOne(p => p.ExtUserTenantCheckOutForm)
                    .HasForeignKey<ExtUserTenantCheckOutForm>(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExtUserTenantCheckOutForms_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<Guarantor>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Guarantors");

                entity.Property(e => e.AddressLine1).IsUnicode(false);

                entity.Property(e => e.AddressLine2).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.ConfidentialNotes).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.LandlineTelNo).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Postcode).IsUnicode(false);

                entity.Property(e => e.RelationshipToTenant).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.Guarantors)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Guarantors_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<GuarantorCommunication>(entity =>
            {
                entity.HasKey(e => new { e.GuarantorId, e.CommunicationId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.GuarantorCommunications)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuarantorCommunications_Communications");

                entity.HasOne(d => d.Guarantor)
                    .WithMany(p => p.GuarantorCommunications)
                    .HasForeignKey(d => d.GuarantorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuarantorCommunications_Guarantors");
            });

            modelBuilder.Entity<GuarantorNote>(entity =>
            {
                entity.HasKey(e => new { e.GuarantorId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Guarantor)
                    .WithMany(p => p.GuarantorNotes)
                    .HasForeignKey(d => d.GuarantorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuarantorNotes_Guarantors");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.GuarantorNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuarantorNotes_Notes");
            });

            modelBuilder.Entity<GuarantorUserAccessProfile>(entity =>
            {
                entity.HasIndex(e => e.UserAccessProfileId)
                    .HasName("UK_GuarantorUserAccessProfiles")
                    .IsUnique();

                entity.Property(e => e.GuarantorId).ValueGeneratedNever();

                entity.HasOne(d => d.Guarantor)
                    .WithOne(p => p.GuarantorUserAccessProfile)
                    .HasForeignKey<GuarantorUserAccessProfile>(d => d.GuarantorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuarantorUserAccessProfiles_Guarantors");

                entity.HasOne(d => d.UserAccessProfile)
                    .WithOne(p => p.GuarantorUserAccessProfile)
                    .HasForeignKey<GuarantorUserAccessProfile>(d => d.UserAccessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuarantorUserAccessProfiles_UserAccessProfiles");
            });

            modelBuilder.Entity<HistoricalBankStatementTran>(entity =>
            {
                entity.Property(e => e.AccNo).IsUnicode(false);

                entity.Property(e => e.Bank).IsUnicode(false);

                entity.Property(e => e.Detail).IsUnicode(false);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Filename).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.Accommodation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Images_Accommodation");
            });

            modelBuilder.Entity<InternalUserProfile>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<InvoiceHeader>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.InvoiceHeaders)
                    .HasForeignKey(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceHeaders_Ledgers");
            });

            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.HasIndex(e => e.LedgerTransactionId)
                    .HasName("IX_InvoiceItems")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.VatType).IsUnicode(false);

                entity.HasOne(d => d.InvoiceHeader)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.InvoiceHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceItems_InvoiceHeaders");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithOne(p => p.InvoiceItem)
                    .HasForeignKey<InvoiceItem>(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceItems_TransactionItems");
            });

            modelBuilder.Entity<Key>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.Bedroom)
                    .WithMany(p => p.Keys)
                    .HasForeignKey(d => d.BedroomId)
                    .HasConstraintName("FK_Keys_Accommodation");

                entity.HasOne(d => d.KeyMasterSet)
                    .WithMany(p => p.Keys)
                    .HasForeignKey(d => d.KeyMasterSetId)
                    .HasConstraintName("FK_Keys_KeyMasterSets");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Keys)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Keys_Properties");
            });

            modelBuilder.Entity<KeyBunch>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_KeyBunches")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.WhosSet).IsUnicode(false);
            });

            modelBuilder.Entity<KeyBunchKey>(entity =>
            {
                entity.HasKey(e => new { e.KeyBunchId, e.KeyId });

                entity.Property(e => e.Dummy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.KeyBunch)
                    .WithMany(p => p.KeyBunchKeys)
                    .HasForeignKey(d => d.KeyBunchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyBunchKeys_KeyBunches");

                entity.HasOne(d => d.Key)
                    .WithMany(p => p.KeyBunchKeys)
                    .HasForeignKey(d => d.KeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyBunchKeys_Keys");
            });

            modelBuilder.Entity<KeyCollectionInstruction>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_KeyCollectionInstructions")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Instructions).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<KeyMasterSet>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_MasterKeySets")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<KeyReturnInstruction>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_KeyReturnInstructions")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Instructions).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Landlord>(entity =>
            {
                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.ComputedName).HasComputedColumnSql("(case when [BusinessName] IS NULL then (case when [Title] IS NULL then N'' else [Title]+N' ' end+case when [Firstname] IS NULL then N'' else [Firstname]+N' ' end)+case when [Lastname] IS NULL then N'' else [Lastname]+N' ' end else [BusinessName] end)");

                entity.Property(e => e.ConfidentialNotes).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmergencyTelNo).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Middlenames).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.MobileNo2).IsUnicode(false);

                entity.Property(e => e.NrlexemptionNumber).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.Landlords)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_Landlords_Countries");
            });

            modelBuilder.Entity<LandlordCommunication>(entity =>
            {
                entity.HasKey(e => new { e.LandlordId, e.CommunicationId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.LandlordCommunications)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordCommunications_Communications");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.LandlordCommunications)
                    .HasForeignKey(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordCommunications_Landlords");
            });

            modelBuilder.Entity<LandlordLedgerTransaction>(entity =>
            {
                entity.HasKey(e => new { e.LandlordId, e.LedgerTransactionId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.LandlordLedgerTransactions)
                    .HasForeignKey(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordTransactionItems_Landlords");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.LandlordLedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordTransactionItems_TransactionItems");
            });

            modelBuilder.Entity<LandlordNote>(entity =>
            {
                entity.HasKey(e => new { e.LandlordId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.LandlordNotes)
                    .HasForeignKey(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordNotes_Landlords");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.LandlordNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordNotes_Notes");
            });

            modelBuilder.Entity<LandlordsContractorPaymentAccount>(entity =>
            {
                entity.HasIndex(e => e.LandlordId)
                    .HasName("UK_LandlordsSupplierPaymentAccounts")
                    .IsUnique();

                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_LandlordsContractorPaymentAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Landlord)
                    .WithOne(p => p.LandlordsContractorPaymentAccount)
                    .HasForeignKey<LandlordsContractorPaymentAccount>(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsContractorPaymentAccounts_Landlords");

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.LandlordsContractorPaymentAccount)
                    .HasForeignKey<LandlordsContractorPaymentAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsContractorPaymentAccounts_Ledgers");
            });

            modelBuilder.Entity<LandlordsContractorPendingPaymentAccount>(entity =>
            {
                entity.HasIndex(e => e.LandlordId)
                    .HasName("UK_LandlordsSupplierPendingPaymentAccounts")
                    .IsUnique();

                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_LandlordsContractorPendingPaymentAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Landlord)
                    .WithOne(p => p.LandlordsContractorPendingPaymentAccount)
                    .HasForeignKey<LandlordsContractorPendingPaymentAccount>(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsContractorPendingPaymentAccounts_Landlords");

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.LandlordsContractorPendingPaymentAccount)
                    .HasForeignKey<LandlordsContractorPendingPaymentAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsContractorPendingPaymentAccounts_Ledgers");
            });

            modelBuilder.Entity<LandlordsFloatAccount>(entity =>
            {
                entity.HasIndex(e => e.LandlordId)
                    .HasName("UK_LandlordsFloatAccounts")
                    .IsUnique();

                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_LandlordsFloatAccounts2")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Landlord)
                    .WithOne(p => p.LandlordsFloatAccount)
                    .HasForeignKey<LandlordsFloatAccount>(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsFloatAccounts_Landlords");

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.LandlordsFloatAccount)
                    .HasForeignKey<LandlordsFloatAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsFloatAccounts_Ledgers");
            });

            modelBuilder.Entity<LandlordsMainAccount>(entity =>
            {
                entity.HasIndex(e => e.LandlordId)
                    .HasName("UK_LandlordsMainAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.RentalStatementDeliveryMethod).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Landlord)
                    .WithOne(p => p.LandlordsMainAccount)
                    .HasForeignKey<LandlordsMainAccount>(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsAccounts_Landlords");

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.LandlordsMainAccount)
                    .HasForeignKey<LandlordsMainAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsMainAccounts_LedgerMainAccounts");
            });

            modelBuilder.Entity<LandlordsPropertyHistory>(entity =>
            {
                entity.HasKey(e => new { e.LandlordId, e.PropertysLandlordHistoryId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Share).HasDefaultValueSql("((100))");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.LandlordsPropertyHistories)
                    .HasForeignKey(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsPropertyShares_Landlords");

                entity.HasOne(d => d.PropertysLandlordHistory)
                    .WithMany(p => p.LandlordsPropertyHistories)
                    .HasForeignKey(d => d.PropertysLandlordHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsPropertyShares_LandlordsProperties");
            });

            modelBuilder.Entity<LandlordUserAccessProfile>(entity =>
            {
                entity.HasIndex(e => e.UserAccessProfileId)
                    .HasName("UK_LandlordUserAccessProfiles")
                    .IsUnique();

                entity.Property(e => e.LandlordId).ValueGeneratedNever();

                entity.HasOne(d => d.Landlord)
                    .WithOne(p => p.LandlordUserAccessProfile)
                    .HasForeignKey<LandlordUserAccessProfile>(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordUserAccessProfiles_Landlords");

                entity.HasOne(d => d.UserAccessProfile)
                    .WithOne(p => p.LandlordUserAccessProfile)
                    .HasForeignKey<LandlordUserAccessProfile>(d => d.UserAccessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordUserAccessProfiles_UserAccessProfiles");
            });

            modelBuilder.Entity<Ledger>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("UK_Ledgers_AccountId")
                    .IsUnique();

                entity.HasIndex(e => e.Code)
                    .HasName("UK_Ledgers2")
                    .IsUnique();

                entity.HasIndex(e => e.PublicId)
                    .HasName("UK_Ledgers3")
                    .IsUnique();

                entity.HasIndex(e => new { e.Code, e.Descr, e.LedgerAccountTypeId })
                    .HasName("idx_DCh_2757_2756_Ledgers");

                entity.Property(e => e.AccountId)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(('a'+'-')+CONVERT([varchar],[Id],(0)))");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.LedgerBalance).HasComputedColumnSql("(isnull([CreditTotalAmount],(0))-isnull([DebitTotalAmount],(0)))");

                entity.Property(e => e.PublicId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LedgerAccountType)
                    .WithMany(p => p.Ledgers)
                    .HasForeignKey(d => d.LedgerAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ledgers_LedgerAccountTypes");

                entity.HasOne(d => d.LedgerCategory)
                    .WithMany(p => p.Ledgers)
                    .HasForeignKey(d => d.LedgerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ledgers_LedgerCategories");
            });

            modelBuilder.Entity<LedgerAccountType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UK_LedgerAccountTypes2")
                    .IsUnique();

                entity.HasIndex(e => e.Descr)
                    .HasName("UK_LedgerAccountTypes")
                    .IsUnique();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.DefaultLedgerCategory)
                    .WithMany(p => p.LedgerAccountTypes)
                    .HasForeignKey(d => d.DefaultLedgerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LedgerAccountTypes_LedgerCategories");

                entity.HasOne(d => d.LedgerType)
                    .WithMany(p => p.LedgerAccountTypes)
                    .HasForeignKey(d => d.LedgerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LedgerAccountTypes_LedgerTypes");
            });

            modelBuilder.Entity<LedgerCategory>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UK_LedgerCategories")
                    .IsUnique();

                entity.Property(e => e.AllowSubCategories)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CreditTxTitle)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Credit')");

                entity.Property(e => e.DebitTxTitle)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Debit')");

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.HasOne(d => d.LedgerType)
                    .WithMany(p => p.LedgerCategories)
                    .HasForeignKey(d => d.LedgerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LedgerCategories_LedgerTypes");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_LedgerCategories_LedgerCategories");
            });

            modelBuilder.Entity<LedgerMainAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_LedgerMainAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Bank).IsUnicode(false);

                entity.Property(e => e.BankAccountName).IsUnicode(false);

                entity.Property(e => e.BankAccountNo).IsUnicode(false);

                entity.Property(e => e.ChequePayeeName).IsUnicode(false);

                entity.Property(e => e.Iban).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OurPaymentReference).IsUnicode(false);

                entity.Property(e => e.PreferredPaymentMethod).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SortCode).IsUnicode(false);

                entity.Property(e => e.SuspendDebtRecoveryReason).IsUnicode(false);

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.LedgerMainAccount)
                    .HasForeignKey<LedgerMainAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LedgerMainAccounts_Ledgers");
            });

            modelBuilder.Entity<LedgerNote>(entity =>
            {
                entity.HasKey(e => new { e.LedgerId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.LedgerNotes)
                    .HasForeignKey(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LedgerNotes_Ledgers");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.LedgerNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LedgerNotes_Notes");
            });

            modelBuilder.Entity<LedgerTransaction>(entity =>
            {
                entity.HasIndex(e => e.AutoTransferPlanId)
                    .HasName("idx_DCh_802_801_TransactionItems");

                entity.HasIndex(e => e.DebitLedgerId)
                    .HasName("idx_DCh_2891_2890_TransactionItems");

                entity.HasIndex(e => new { e.CreditLedgerId, e.DebitLedgerId })
                    .HasName("idx_DCh_9154_9153_TransactionItems");

                entity.HasIndex(e => new { e.CreditLedgerId, e.DebitLedgerId, e.LedgerTransactionStageId })
                    .HasName("idx_DCh_15402_15401_TransactionItems");

                entity.HasIndex(e => new { e.Date, e.CreditLedgerId, e.PaymentTypeId })
                    .HasName("idx_DCh_444_443_TransactionItems");

                entity.HasIndex(e => new { e.Amount, e.CreditLedgerId, e.DebitLedgerId, e.LedgerTransactionStageId })
                    .HasName("idx_DCh_40_39_TransactionItems");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.AutoTransferPlan)
                    .WithMany(p => p.LedgerTransactions)
                    .HasForeignKey(d => d.AutoTransferPlanId)
                    .HasConstraintName("FK_TransactionItems_AutoTransferPlans");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.LedgerTransactions)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItems_Branches");

                entity.HasOne(d => d.CreditLedger)
                    .WithMany(p => p.LedgerTransactionCreditLedgers)
                    .HasForeignKey(d => d.CreditLedgerId)
                    .HasConstraintName("FK_LedgerTransactionItems_LedgersCredit");

                entity.HasOne(d => d.DebitLedger)
                    .WithMany(p => p.LedgerTransactionDebitLedgers)
                    .HasForeignKey(d => d.DebitLedgerId)
                    .HasConstraintName("FK_LedgerTransactionItems_LedgersDebit");

                entity.HasOne(d => d.LedgerTransactionGroup)
                    .WithMany(p => p.LedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItems_TransactionItemGroups");

                entity.HasOne(d => d.LedgerTransactionStage)
                    .WithMany(p => p.LedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItems_TransactionItemStages");

                entity.HasOne(d => d.LedgerTransactionType)
                    .WithMany(p => p.LedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItems_TransactionItemTypes");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.LedgerTransactions)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_TransactionItems_PaymentTypes");
            });

            modelBuilder.Entity<LedgerTransactionBatch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<LedgerTransactionBatchLink>(entity =>
            {
                entity.HasKey(e => new { e.LedgerTransactionId, e.LedgerTransactionBatchId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LedgerTransactionBatch)
                    .WithMany(p => p.LedgerTransactionBatchLinks)
                    .HasForeignKey(d => d.LedgerTransactionBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItemBatchLinks_TransactionItemBatches");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.LedgerTransactionBatchLinks)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItemBatchLinks_TransactionItems");
            });

            modelBuilder.Entity<LedgerTransactionGroup>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LedgerTransactionGroupType)
                    .WithMany(p => p.LedgerTransactionGroups)
                    .HasForeignKey(d => d.LedgerTransactionGroupTypeId)
                    .HasConstraintName("FK_TransactionItemGroups_TransactionItemGroupTypes");
            });

            modelBuilder.Entity<LedgerTransactionGroupType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_TransactionItemGroupTypes")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<LedgerTransactionStage>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UK_TransactionItemStages")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<LedgerTransactionType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UK_TransactionItemTypes2")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("UK_TransactionItemTypes")
                    .IsUnique();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LedgerTransactionTypeCategory)
                    .WithMany(p => p.LedgerTransactionTypes)
                    .HasForeignKey(d => d.LedgerTransactionTypeCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItemTypes_TransactionItemTypeCategories");
            });

            modelBuilder.Entity<LedgerTransactionTypeCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_TransactionItemTypeCategories")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<LedgerTransactionTypeValidPayeeLedgerAccountType>(entity =>
            {
                entity.HasIndex(e => new { e.LedgerTransactionTypeId, e.LedgerAccountTypeId })
                    .HasName("IX_TransactionItemTypeValidPayeeLedgerAccountTypes")
                    .IsUnique();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LedgerAccountType)
                    .WithMany(p => p.LedgerTransactionTypeValidPayeeLedgerAccountTypes)
                    .HasForeignKey(d => d.LedgerAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItemTypeValidPayeeLedgerAccountTypes_LedgerAccountTypes1");

                entity.HasOne(d => d.LedgerTransactionType)
                    .WithMany(p => p.LedgerTransactionTypeValidPayeeLedgerAccountTypes)
                    .HasForeignKey(d => d.LedgerTransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItemTypeValidPayeeLedgerAccountTypes_TransactionItemTypes1");
            });

            modelBuilder.Entity<LedgerTransactionTypeValidRecipientLedgerAccountType>(entity =>
            {
                entity.HasIndex(e => new { e.LedgerTransactionTypeId, e.LedgerAccountTypeId })
                    .HasName("UK_TransactionItemTypeValidRecipientLedgerAccountTypes")
                    .IsUnique();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LedgerAccountType)
                    .WithMany(p => p.LedgerTransactionTypeValidRecipientLedgerAccountTypes)
                    .HasForeignKey(d => d.LedgerAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItemTypeValidRecipientLedgerAccountTypes_LedgerAccountTypes1");

                entity.HasOne(d => d.LedgerTransactionType)
                    .WithMany(p => p.LedgerTransactionTypeValidRecipientLedgerAccountTypes)
                    .HasForeignKey(d => d.LedgerTransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionItemTypeValidRecipientLedgerAccountTypes_TransactionItemTypes1");
            });

            modelBuilder.Entity<LedgerType>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<LettingInstruction>(entity =>
            {
                entity.Property(e => e.ApprovedByLandlord).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.LetIndividualRooms)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LandlordsProperties)
                    .WithMany(p => p.LettingInstructions)
                    .HasForeignKey(d => d.LandlordsPropertiesId)
                    .HasConstraintName("FK_LettingInstructions_LandlordsProperties");
            });

            modelBuilder.Entity<LinkedPaymentTransaction>(entity =>
            {
                entity.HasKey(e => new { e.ParentTransId, e.ChildTransId });

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<MailMergeTemplate>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_MailMergeTemplates")
                    .IsUnique();

                entity.Property(e => e.BodyText).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.TitleText).IsUnicode(false);

                entity.HasOne(d => d.BodyLayout)
                    .WithMany(p => p.MailMergeTemplateBodyLayouts)
                    .HasForeignKey(d => d.BodyLayoutId)
                    .HasConstraintName("FK_MailMergeTemplates_MailMergeTemplateLayouts1");

                entity.HasOne(d => d.DataModel)
                    .WithMany(p => p.MailMergeTemplates)
                    .HasForeignKey(d => d.DataModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailMergeTemplates_MailMergeTemplateDataModels");

                entity.HasOne(d => d.TitleLayout)
                    .WithMany(p => p.MailMergeTemplateTitleLayouts)
                    .HasForeignKey(d => d.TitleLayoutId)
                    .HasConstraintName("FK_MailMergeTemplates_MailMergeTemplateLayouts");
            });

            modelBuilder.Entity<MailMergeTemplateDataModel>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<MailMergeTemplateLayout>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceJob>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.NextActionComment).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Reference).IsUnicode(false);

                entity.Property(e => e.ReportedByOther).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.MaintenanceJobContractors)
                    .HasForeignKey(d => d.ContractorId)
                    .HasConstraintName("FK_MaintenanceJobs_Contractors1");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.MaintenanceJobs)
                    .HasForeignKey(d => d.PriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceJobs_MaintenanceJobPriorities");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.MaintenanceJobs)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_MaintenanceJobs_Projects");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.MaintenanceJobs)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceJobs_Properties");

                entity.HasOne(d => d.ReportedByContractorNavigation)
                    .WithMany(p => p.MaintenanceJobReportedByContractorNavigations)
                    .HasForeignKey(d => d.ReportedByContractor)
                    .HasConstraintName("FK_MaintenanceJobs_Contractors");

                entity.HasOne(d => d.ReportedByLandlordNavigation)
                    .WithMany(p => p.MaintenanceJobs)
                    .HasForeignKey(d => d.ReportedByLandlord)
                    .HasConstraintName("FK_MaintenanceJobs_Landlords");

                entity.HasOne(d => d.ReportedByTenantNavigation)
                    .WithMany(p => p.MaintenanceJobs)
                    .HasForeignKey(d => d.ReportedByTenant)
                    .HasConstraintName("FK_MaintenanceJobs_Tenants");

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.MaintenanceJobs)
                    .HasForeignKey(d => d.StatusCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceJobs_MaintenanceJobStatus");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MaintenanceJobs)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceJobs_MaintenanceJobTypes");
            });

            modelBuilder.Entity<MaintenanceJobPriority>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.TimeScale).IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceJobStatu>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<MaintenanceJobType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<MaintenancePreference>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Preference).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.LandlordNavigation)
                    .WithMany(p => p.MaintenancePreferences)
                    .HasForeignKey(d => d.Landlord)
                    .HasConstraintName("FK_MaintenancePreferences_Landlords");

                entity.HasOne(d => d.MaintenanceJobTypeNavigation)
                    .WithMany(p => p.MaintenancePreferences)
                    .HasForeignKey(d => d.MaintenanceJobType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenancePreferences_MaintenanceJobTypes");

                entity.HasOne(d => d.PropertyNavigation)
                    .WithMany(p => p.MaintenancePreferences)
                    .HasForeignKey(d => d.Property)
                    .HasConstraintName("FK_MaintenancePreferences_Properties");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });
            });

            modelBuilder.Entity<NextOfKin>(entity =>
            {
                entity.Property(e => e.AddressLine1).IsUnicode(false);

                entity.Property(e => e.AddressLine2).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.ConfidentialNotes).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.LandlineTelNo).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Postcode).IsUnicode(false);

                entity.Property(e => e.RelationshipToTenant).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.NextOfKins)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NextOfKins_Tenants");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Confidential).HasDefaultValueSql("((1))");

                entity.Property(e => e.Created).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.NoteType)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.NoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notes_NoteTypes");
            });

            modelBuilder.Entity<NoteType>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<OfficeCashStorageAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_OfficeCashStorageAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.OfficeCashStorageAccount)
                    .HasForeignKey<OfficeCashStorageAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeCashStorageAccounts_Ledgers");
            });

            modelBuilder.Entity<OfficeCashStorageAccountsBankDeposit>(entity =>
            {
                entity.HasKey(e => new { e.BankDepositId, e.OfficeCashStorageAccountId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.BankDeposit)
                    .WithMany(p => p.OfficeCashStorageAccountsBankDeposits)
                    .HasForeignKey(d => d.BankDepositId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeCashStorageAccountsBankDeposits_BankDeposits");

                entity.HasOne(d => d.OfficeCashStorageAccount)
                    .WithMany(p => p.OfficeCashStorageAccountsBankDeposits)
                    .HasForeignKey(d => d.OfficeCashStorageAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeCashStorageAccountsBankDeposits_OfficeCashStorageAccounts1");
            });

            modelBuilder.Entity<OfficeChequeStorageAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_OfficeChequeStorageAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.OfficeChequeStorageAccount)
                    .HasForeignKey<OfficeChequeStorageAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeChequeStorageAccounts_Ledgers");
            });

            modelBuilder.Entity<OfficeChequeStorageAccountsBankDeposit>(entity =>
            {
                entity.HasKey(e => new { e.BankDepositId, e.OfficeChequeStorageAccountId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.BankDeposit)
                    .WithMany(p => p.OfficeChequeStorageAccountsBankDeposits)
                    .HasForeignKey(d => d.BankDepositId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeChequeStorageAccountsBankDeposits_BankDeposits");

                entity.HasOne(d => d.OfficeChequeStorageAccount)
                    .WithMany(p => p.OfficeChequeStorageAccountsBankDeposits)
                    .HasForeignKey(d => d.OfficeChequeStorageAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeChequeStorageAccountsBankDeposits_OfficeChequeStorageAccounts1");
            });

            modelBuilder.Entity<OracleLedgerTransaction>(entity =>
            {
                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.OracleLedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .HasConstraintName("FK_OracleTransactionItems_TransactionItems");
            });

            modelBuilder.Entity<Payee>(entity =>
            {
                entity.Property(e => e.AddressLine1).IsUnicode(false);

                entity.Property(e => e.AddressLine2).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.ConfidentialNotes).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.LandlineTelNo).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Postcode).IsUnicode(false);

                entity.Property(e => e.RelationshipToTenant).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Payees)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payees_Tenants");
            });

            modelBuilder.Entity<PayeeUserAccessProfile>(entity =>
            {
                entity.HasIndex(e => e.UserAccessProfileId)
                    .HasName("UK_PayeeUserAccessProfiles")
                    .IsUnique();

                entity.Property(e => e.PayeeId).ValueGeneratedNever();

                entity.HasOne(d => d.Payee)
                    .WithOne(p => p.PayeeUserAccessProfile)
                    .HasForeignKey<PayeeUserAccessProfile>(d => d.PayeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayeeUserAccessProfiles_Payees");

                entity.HasOne(d => d.UserAccessProfile)
                    .WithOne(p => p.PayeeUserAccessProfile)
                    .HasForeignKey<PayeeUserAccessProfile>(d => d.UserAccessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayeeUserAccessProfiles_UserAccessProfiles");
            });

            modelBuilder.Entity<PaymentPlan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.GracePeriod).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.InitialTxStageOnMakePayment).HasDefaultValueSql("((1))");

                entity.Property(e => e.InitialTxStageOnTakePayment).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.InitialTxStageOnMakePaymentNavigation)
                    .WithMany(p => p.PaymentTypeInitialTxStageOnMakePaymentNavigations)
                    .HasForeignKey(d => d.InitialTxStageOnMakePayment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentTypes_LedgerTransactionStages1");

                entity.HasOne(d => d.InitialTxStageOnTakePaymentNavigation)
                    .WithMany(p => p.PaymentTypeInitialTxStageOnTakePaymentNavigations)
                    .HasForeignKey(d => d.InitialTxStageOnTakePayment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentTypes_LedgerTransactionStages");
            });

            modelBuilder.Entity<PdqAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_PdqAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.PdqAccount)
                    .HasForeignKey<PdqAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PdqAccounts_Ledgers");
            });

            modelBuilder.Entity<PdqAccountsBankDeposit>(entity =>
            {
                entity.HasKey(e => new { e.BankDepositId, e.PdqAccountId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.BankDeposit)
                    .WithMany(p => p.PdqAccountsBankDeposits)
                    .HasForeignKey(d => d.BankDepositId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PdqAccountsBankDeposits_BankDeposits");

                entity.HasOne(d => d.PdqAccount)
                    .WithMany(p => p.PdqAccountsBankDeposits)
                    .HasForeignKey(d => d.PdqAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PdqAccountsBankDeposits_PdqAccounts1");
            });

            modelBuilder.Entity<PendingPaymentsToPayAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerMainAccountId)
                    .HasName("UK_PendingPaymentsToPayAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.PendingPaymentsToPayAccount)
                    .HasForeignKey<PendingPaymentsToPayAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PendingPaymentsToPayAccounts_Ledgers");

                entity.HasOne(d => d.LedgerMainAccount)
                    .WithOne(p => p.PendingPaymentsToPayAccount)
                    .HasForeignKey<PendingPaymentsToPayAccount>(d => d.LedgerMainAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PendingPaymentsToPayAccounts_LedgerMainAccounts");
            });

            modelBuilder.Entity<PendingPaymentsToReceiveAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerMainAccountId)
                    .HasName("UK_PendingPaymentsToReceiveAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.PendingPaymentsToReceiveAccount)
                    .HasForeignKey<PendingPaymentsToReceiveAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PendingPaymentsToReceiveAccounts_Ledgers");

                entity.HasOne(d => d.LedgerMainAccount)
                    .WithOne(p => p.PendingPaymentsToReceiveAccount)
                    .HasForeignKey<PendingPaymentsToReceiveAccount>(d => d.LedgerMainAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PendingPaymentsToReceiveAccounts_LedgerMainAccounts");
            });

            modelBuilder.Entity<PeriodFrequencyType>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasIndex(e => e.Alias)
                    .HasName("UK_Properties_Ref")
                    .IsUnique();

                entity.HasIndex(e => e.PublicId)
                    .HasName("UK_Properties_PublicId")
                    .IsUnique();

                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.BurglarAlarmCode).IsUnicode(false);

                entity.Property(e => e.CarbonMonoxideDetectorNotes).IsUnicode(false);

                entity.Property(e => e.CarbonMonoxideDetectorType).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.ComputedAddressFirstLine).HasComputedColumnSql("((case when [FlatName] IS NULL then N'' else [FlatName]+N', ' end+case when [HouseNo] IS NULL then N'' else [HouseNo]+N' ' end)+case when [Street] IS NULL then N'' else [Street] end)");

                entity.Property(e => e.ComputedAddressFirstLinePostCode).HasComputedColumnSql("(((case when [FlatName] IS NULL then N'' else [FlatName]+N', ' end+case when [HouseNo] IS NULL then N'' else [HouseNo]+N' ' end)+case when [Street] IS NULL then N'' else [Street] end)+case when [PostCode] IS NULL then N'' else N', '+[PostCode] end)");

                entity.Property(e => e.ComputedAddressFull).HasComputedColumnSql("((((((case when [FlatName] IS NULL then N'' else [FlatName]+N', ' end+case when [HouseNo] IS NULL then N'' else [HouseNo]+N' ' end)+case when [Street] IS NULL then N'' else [Street] end)+case when [Locality] IS NULL then N'' else N', '+[Locality] end)+case when [City] IS NULL then N'' else N', '+[City] end)+case when [County] IS NULL then N'' else N', '+[County] end)+case when [PostCode] IS NULL then N'' else N', '+[PostCode] end)");

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.County).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.FireDetectionNotes).IsUnicode(false);

                entity.Property(e => e.FireDetectionType).IsUnicode(false);

                entity.Property(e => e.FlatName).IsUnicode(false);

                entity.Property(e => e.FuseboxLocation).IsUnicode(false);

                entity.Property(e => e.GasBoilerNotes).IsUnicode(false);

                entity.Property(e => e.GasBoilerType).IsUnicode(false);

                entity.Property(e => e.HouseNo).IsUnicode(false);

                entity.Property(e => e.Locality).IsUnicode(false);

                entity.Property(e => e.OffStreetParking).IsUnicode(false);

                entity.Property(e => e.PostCode).IsUnicode(false);

                entity.Property(e => e.PublicId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.StopcockLocation).IsUnicode(false);

                entity.Property(e => e.Street).IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_Properties_Areas");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_Properties_Assets");

                entity.HasOne(d => d.MainImage)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.MainImageId)
                    .HasConstraintName("FK_Properties_Images");

                entity.HasOne(d => d.PropertyBlock)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.PropertyBlockId)
                    .HasConstraintName("FK_Properties_PropertyBlocks");

                entity.HasOne(d => d.PropertyType)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.PropertyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Properties_PropertyTypes");
            });

            modelBuilder.Entity<PropertyBlock>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<PropertyEnergyPerformanceCertificate>(entity =>
            {
                entity.Property(e => e.PropertyMaintenanceCertificateId).ValueGeneratedNever();

                entity.Property(e => e.Ref).IsUnicode(false);

                entity.HasOne(d => d.PropertyMaintenanceCertificate)
                    .WithOne(p => p.PropertyEnergyPerformanceCertificate)
                    .HasForeignKey<PropertyEnergyPerformanceCertificate>(d => d.PropertyMaintenanceCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyEnergyPerformanceCertificates_PropertyMaintenanceCertificates");
            });

            modelBuilder.Entity<PropertyFacility>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.PropertyFacilityType)
                    .WithMany(p => p.PropertyFacilities)
                    .HasForeignKey(d => d.PropertyFacilityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyFacilities_PropertyFacilitityTypes");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyFacilities)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyFacilities_Properties");
            });

            modelBuilder.Entity<PropertyFacilityType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_PropertyFacilitityTypes")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<PropertyInspection>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.MeterReadings).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.InspectionType)
                    .WithMany(p => p.PropertyInspections)
                    .HasForeignKey(d => d.InspectionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyInspections_PropertyInspectionTypes");
            });

            modelBuilder.Entity<PropertyInspectionType>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<PropertyInventoryItem>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Accommodation)
                    .WithMany(p => p.PropertyInventoryItems)
                    .HasForeignKey(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyInventoryItems_Accommodation");

                entity.HasOne(d => d.PropertyInventoryType)
                    .WithMany(p => p.PropertyInventoryItems)
                    .HasForeignKey(d => d.PropertyInventoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyInventoryItems_PropertyInventoryItemTypes");
            });

            modelBuilder.Entity<PropertyInventoryItemCondition>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Condition).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.PropertyInventoryItem)
                    .WithMany(p => p.PropertyInventoryItemConditions)
                    .HasForeignKey(d => d.PropertyInventoryItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyInventoryItemConditions_PropertyInventoryItems");
            });

            modelBuilder.Entity<PropertyInventoryItemInspectionCondition>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.PropertyInspection)
                    .WithMany(p => p.PropertyInventoryItemInspectionConditions)
                    .HasForeignKey(d => d.PropertyInspectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyInventoryItemInspectionConditions_PropertyInspections");

                entity.HasOne(d => d.PropertyInventoryItemCondition)
                    .WithMany(p => p.PropertyInventoryItemInspectionConditions)
                    .HasForeignKey(d => d.PropertyInventoryItemConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyInventoryItemInspectionConditions_PropertyInventoryItemConditions");
            });

            modelBuilder.Entity<PropertyInventoryItemType>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<PropertyLedgerTransaction>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.LedgerTransactionId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.PropertyLedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyTransactionItems_TransactionItems");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyLedgerTransactions)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyTransactionItems_Properties");
            });

            modelBuilder.Entity<PropertyMaintenanceCertificate>(entity =>
            {
                entity.HasIndex(e => new { e.PropertyId, e.PropertyMaintenanceCertificateTypeId })
                    .HasName("UK_PropertyMaintenanceCertificates")
                    .IsUnique();

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ResponsibilityOf).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyMaintenanceCertificates)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyMaintenanceCertificates_Properties");

                entity.HasOne(d => d.PropertyMaintenanceCertificateType)
                    .WithMany(p => p.PropertyMaintenanceCertificates)
                    .HasForeignKey(d => d.PropertyMaintenanceCertificateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyMaintenanceCertificates_PropertyMaintenanceCertificateTypes");
            });

            modelBuilder.Entity<PropertyMaintenanceCertificateHistory>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.HasOne(d => d.PropertyMaintenanceCertificate)
                    .WithMany(p => p.PropertyMaintenanceCertificateHistories)
                    .HasForeignKey(d => d.PropertyMaintenanceCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyMaintenanceCertificateHistory_PropertyMaintenanceCertificates");
            });

            modelBuilder.Entity<PropertyMaintenanceCertificateType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<PropertyNote>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.PropertyNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyNotes_Notes");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyNotes)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyNotes_Properties");
            });

            modelBuilder.Entity<PropertysLandlordHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertysLandlordHistories)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LandlordsProperties_Properties");

                entity.HasOne(d => d.LandlordsPropertyHistory)
                    .WithMany(p => p.PropertysLandlordHistories)
                    .HasForeignKey(d => new { d.MainContact, d.Id })
                    .HasConstraintName("FK_LandlordsProperties_LandlordsPropertyShares");
            });

            modelBuilder.Entity<PropertyType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_PropertyTypes")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<PropertyUtilityMeter>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SerialNo).IsUnicode(false);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyUtilityMeters)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyUtilityMeters_Properties");

                entity.HasOne(d => d.PropertyUtilityMeterType)
                    .WithMany(p => p.PropertyUtilityMeters)
                    .HasForeignKey(d => d.PropertyUtilityMeterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyUtilityMeters_PropertyUtilityMeterTypes");
            });

            modelBuilder.Entity<PropertyUtilityMeterReading>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.TakenBy).IsUnicode(false);

                entity.HasOne(d => d.PropertyUtilityMeter)
                    .WithMany(p => p.PropertyUtilityMeterReadings)
                    .HasForeignKey(d => d.PropertyUtilityMeterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyUtilityMeterReadings_PropertyUtilityMeters");
            });

            modelBuilder.Entity<PropertyUtilityMeterType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_PropertyUtilityMeterTypes")
                    .IsUnique();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<RefCode>(entity =>
            {
                entity.HasKey(e => new { e.DomainId, e.LowValue });

                entity.Property(e => e.LowValue).IsUnicode(false);

                entity.Property(e => e.Abbreviation).IsUnicode(false);

                entity.Property(e => e.HighValue).IsUnicode(false);

                entity.Property(e => e.Meaning).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.RefCodes)
                    .HasForeignKey(d => d.DomainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefCodes_RefCodeDomains");
            });

            modelBuilder.Entity<RefCodeDomain>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<RentChargeSchedule>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.PeriodFrequencyType)
                    .WithMany(p => p.RentChargeSchedules)
                    .HasForeignKey(d => d.PeriodFrequencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentChargeSchedules_PeriodFrequencyTypes");

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.RentChargeSchedules)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentChargeSchedules_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<SalesAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_SalesAccounts")
                    .IsUnique();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.SalesAccount)
                    .HasForeignKey<SalesAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesAccounts_Ledgers");
            });

            modelBuilder.Entity<SelectionFilter>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.HasOne(d => d.SelectionFilterType)
                    .WithMany(p => p.SelectionFilters)
                    .HasForeignKey(d => d.SelectionFilterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelectionFilters_SelectionFilterTypes");
            });

            modelBuilder.Entity<SelectionFiltersRecord>(entity =>
            {
                entity.HasKey(e => new { e.SelectionFilterId, e.RecId });

                entity.HasIndex(e => new { e.SelectionFilterId, e.RecId })
                    .HasName("IX_SelectionFiltersRecords")
                    .IsUnique();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.SelectionFilter)
                    .WithMany(p => p.SelectionFiltersRecords)
                    .HasForeignKey(d => d.SelectionFilterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelectionFiltersRecords_SelectionFilters");
            });

            modelBuilder.Entity<SelectionFilterType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<SpreadsheetDepositReturnFormResponse>(entity =>
            {
                entity.HasIndex(e => new { e.Timestamp, e.Firstname, e.Lastname, e.PropertyAddress1stLine })
                    .HasName("UK_SpreadsheetDepositReturnFormResponses")
                    .IsUnique();

                entity.Property(e => e.BankAccountName).IsUnicode(false);

                entity.Property(e => e.BankAccountNo).IsUnicode(false);

                entity.Property(e => e.BankName).IsUnicode(false);

                entity.Property(e => e.BankSortCode).IsUnicode(false);

                entity.Property(e => e.BedroomFloor).IsUnicode(false);

                entity.Property(e => e.BedroomLocation).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ContactNo).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.ForwardingAddress).IsUnicode(false);

                entity.Property(e => e.HowKeysReturnedToUs).IsUnicode(false);

                entity.Property(e => e.KeysReturned).IsUnicode(false);

                entity.Property(e => e.KeysReturnedWhen).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.PlanToLeaveWhen).IsUnicode(false);

                entity.Property(e => e.ProcessComment).IsUnicode(false);

                entity.Property(e => e.ProcessStatus).IsUnicode(false);

                entity.Property(e => e.PropertyAddress1stLine).IsUnicode(false);

                entity.Property(e => e.TenancyEndDate).IsUnicode(false);

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.SpreadsheetDepositReturnFormResponses)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .HasConstraintName("FK_SpreadsheetDepositReturnFormResponses_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<SpreadsheetKeyCollectionFormResponse>(entity =>
            {
                entity.HasIndex(e => new { e.Timestamp, e.Firstname, e.Lastname, e.PropertyAddress1stLine })
                    .HasName("UK_SpreadsheetKeyCollectionFormResponses")
                    .IsUnique();

                entity.Property(e => e.CollectDate).IsUnicode(false);

                entity.Property(e => e.CollectSlot).IsUnicode(false);

                entity.Property(e => e.ContactNo).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.OtherPersonContactNo).IsUnicode(false);

                entity.Property(e => e.OtherPersonFirstname).IsUnicode(false);

                entity.Property(e => e.OtherPersonLastname).IsUnicode(false);

                entity.Property(e => e.ProcessComment).IsUnicode(false);

                entity.Property(e => e.ProcessStatus).IsUnicode(false);

                entity.Property(e => e.PropertyAddress1stLine).IsUnicode(false);

                entity.Property(e => e.TenancyEndBegin).IsUnicode(false);

                entity.Property(e => e.WhoToCollect).IsUnicode(false);

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.SpreadsheetKeyCollectionFormResponses)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .HasConstraintName("FK_SpreadsheetKeyCollectionFormResponses_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<SystemDatum>(entity =>
            {
                entity.Property(e => e.Key)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CsharpDescr).IsUnicode(false);

                entity.Property(e => e.CsharpType).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<TempDataHousingBenefitPayment>(entity =>
            {
                entity.HasIndex(e => e.ChequeNo)
                    .HasName("UK_TempDataHousingBenefitPayments")
                    .IsUnique();

                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<TempDataTenantPayment>(entity =>
            {
                entity.Property(e => e.ChequeNo).IsUnicode(false);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.CreatedReason).IsUnicode(false);

                entity.Property(e => e.DestinationLedgerCode).IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.TempDataTenantPayments)
                    .HasForeignKey(d => d.ContractorId)
                    .HasConstraintName("FK_TempDataTenantPayments_Contractors");

                entity.HasOne(d => d.HousingBenefitPayment)
                    .WithMany(p => p.TempDataTenantPayments)
                    .HasForeignKey(d => d.HousingBenefitPaymentId)
                    .HasConstraintName("FK_TempDataTenantPayments_TempDataHousingBenefitPayments");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.TempDataTenantPayments)
                    .HasForeignKey(d => d.LandlordId)
                    .HasConstraintName("FK_TempDataTenantPayments_Landlords");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.TempDataTenantPayments)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .HasConstraintName("FK_TempDataRentPayments_TransactionItems");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.TempDataTenantPayments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TempDataRentPayments_PaymentTypes");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TempDataTenantPayments)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_TempDataRentPayments_Tenants");
            });

            modelBuilder.Entity<TempEndOfTenancyCharge>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.TenancyAgreement)
                    .WithMany(p => p.TempEndOfTenancyCharges)
                    .HasForeignKey(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TempEndOfTenancyCharges_TenancyAgreements");

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.TempEndOfTenancyCharges)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .HasConstraintName("FK_TempEndOfTenancyCharges_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreement>(entity =>
            {
                entity.HasIndex(e => e.PublicId)
                    .HasName("UK_TenancyAgreements")
                    .IsUnique();

                entity.Property(e => e.DepositProtectionId).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.EndOfTenancyElectricBillAccepted).IsUnicode(false);

                entity.Property(e => e.EndOfTenancyGasBillAccepted).IsUnicode(false);

                entity.Property(e => e.EndOfTenancyLocalPropertyChargeBillAccepted).IsUnicode(false);

                entity.Property(e => e.EndOfTenancyWaterBillAccepted).IsUnicode(false);

                entity.Property(e => e.ExtRef).IsUnicode(false);

                entity.Property(e => e.PublicId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ref).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SourcedFrom).IsUnicode(false);

                entity.HasOne(d => d.DepositProtectionScheme)
                    .WithMany(p => p.TenancyAgreements)
                    .HasForeignKey(d => d.DepositProtectionSchemeId)
                    .HasConstraintName("FK_TenancyAgreements_TenancyDepositProtectionSchemes");

                entity.HasOne(d => d.KeyCollectionInstruction)
                    .WithMany(p => p.TenancyAgreements)
                    .HasForeignKey(d => d.KeyCollectionInstructionId)
                    .HasConstraintName("FK_TenancyAgreements_KeyCollectionInstructions");

                entity.HasOne(d => d.KeyReturnInstruction)
                    .WithMany(p => p.TenancyAgreements)
                    .HasForeignKey(d => d.KeyReturnInstructionId)
                    .HasConstraintName("FK_TenancyAgreements_KeyReturnInstructions");

                entity.HasOne(d => d.LandlordsProperties)
                    .WithMany(p => p.TenancyAgreements)
                    .HasForeignKey(d => d.LandlordsPropertiesId)
                    .HasConstraintName("FK_TenancyAgreements_LandlordsProperties");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.TenancyAgreements)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreements_Properties");

                entity.HasOne(d => d.RentPeriodFrequencyType)
                    .WithMany(p => p.TenancyAgreements)
                    .HasForeignKey(d => d.RentPeriodFrequencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreements_PeriodFrequencyTypes");

                entity.HasOne(d => d.TenancyAgreementStage)
                    .WithMany(p => p.TenancyAgreements)
                    .HasForeignKey(d => d.TenancyAgreementStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreements_TenancyAgreementStages");
            });

            modelBuilder.Entity<TenancyAgreementAdditionalTerm>(entity =>
            {
                entity.Property(e => e.Details).IsUnicode(false);

                entity.HasOne(d => d.TenancyAgreement)
                    .WithMany(p => p.TenancyAgreementAdditionalTerms)
                    .HasForeignKey(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementAdditionalTerms_TenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreementGeneralAccount>(entity =>
            {
                entity.HasIndex(e => e.TenancyAgreementId)
                    .HasName("UK_TenancyAgreementGeneralAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenancyAgreementGeneralAccount)
                    .HasForeignKey<TenancyAgreementGeneralAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementGeneralAccounts_Ledgers");

                entity.HasOne(d => d.TenancyAgreement)
                    .WithOne(p => p.TenancyAgreementGeneralAccount)
                    .HasForeignKey<TenancyAgreementGeneralAccount>(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementGeneralAccounts_TenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreementLeadTenant>(entity =>
            {
                entity.Property(e => e.TenancyAgreementId).ValueGeneratedNever();

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.TenancyAgreement)
                    .WithOne(p => p.TenancyAgreementLeadTenant)
                    .HasForeignKey<TenancyAgreementLeadTenant>(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementLeadTenants_TenancyAgreements");

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.TenancyAgreementLeadTenants)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementLeadTenants_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreementLedgerTransaction>(entity =>
            {
                entity.HasKey(e => new { e.TenancyAgreementId, e.LedgerTransactionId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.TenancyAgreementLedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementTransactionItems_TransactionItems");

                entity.HasOne(d => d.TenancyAgreement)
                    .WithMany(p => p.TenancyAgreementLedgerTransactions)
                    .HasForeignKey(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementTransactionItems_TenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreementNote>(entity =>
            {
                entity.HasKey(e => new { e.TenancyAgreementId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.TenancyAgreementNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementNotes_Notes");

                entity.HasOne(d => d.TenancyAgreement)
                    .WithMany(p => p.TenancyAgreementNotes)
                    .HasForeignKey(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementNotes_TenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreementPayee>(entity =>
            {
                entity.HasKey(e => new { e.PayeeId, e.TenantId, e.TenancyAgreementId });

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.TenancyAgreementPayees)
                    .HasForeignKey(d => d.PayeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementPayees_Payees");

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.TenancyAgreementPayees)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementPayees_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreementRentCollectedAccount>(entity =>
            {
                entity.HasIndex(e => e.TenancyAgreementId)
                    .HasName("UK_TenancyAgreementRentCollectedAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenancyAgreementRentCollectedAccount)
                    .HasForeignKey<TenancyAgreementRentCollectedAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementRentCollectedAccounts_Ledgers");

                entity.HasOne(d => d.TenancyAgreement)
                    .WithOne(p => p.TenancyAgreementRentCollectedAccount)
                    .HasForeignKey<TenancyAgreementRentCollectedAccount>(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenancyAgreementRentCollectedAccounts_TenancyAgreements");
            });

            modelBuilder.Entity<TenancyAgreementStage>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UK_TenancyAgreementStages")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<TenancyDepositProtectionScheme>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_TenancyDepositProtectionSchemes")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.BusinessName).IsUnicode(false);

                entity.Property(e => e.ComputedName).HasComputedColumnSql("(case when [BusinessName] IS NULL then (case when [Title] IS NULL then N'' else [Title]+N' ' end+case when [Firstname] IS NULL then N'' else [Firstname]+N' ' end)+case when [Lastname] IS NULL then N'' else [Lastname]+N' ' end else [BusinessName] end)");

                entity.Property(e => e.ConfidentialNotes).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Email2).IsUnicode(false);

                entity.Property(e => e.Email2Name).IsUnicode(false);

                entity.Property(e => e.FirstTenancyLetBy).IsUnicode(false);

                entity.Property(e => e.FirstTenancyRef).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Middlenames).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.MobileNo2).IsUnicode(false);

                entity.Property(e => e.MobileNo2Name).IsUnicode(false);

                entity.Property(e => e.NationalInsurance).IsUnicode(false);

                entity.Property(e => e.PayingOwnRent).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.StandardPaymentRef).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.Tenants)
                    .HasForeignKey(d => d.StatusCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tenants_TenantStatusTypes");

                entity.HasOne(d => d.TenantType)
                    .WithMany(p => p.Tenants)
                    .HasForeignKey(d => d.TenantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tenants_TenantTypes");
            });

            modelBuilder.Entity<TenantCommunication>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.CommunicationId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.TenantCommunications)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantCommunications_Communications");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantCommunications)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantCommunications_Tenants");
            });

            modelBuilder.Entity<TenantLedgerTransaction>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.LedgerTransactionId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.TenantLedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantTransactionItems_TransactionItems");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantLedgerTransactions)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantTransactionItems_Tenants");
            });

            modelBuilder.Entity<TenantNote>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.TenantNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantNotes_Notes");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantNotes)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantNotes_Tenants");
            });

            modelBuilder.Entity<TenantsMainAccount>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("UK_TenantsMainAccounts")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenantsMainAccount)
                    .HasForeignKey<TenantsMainAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsMainAccounts_LedgerMainAccounts");

                entity.HasOne(d => d.Tenant)
                    .WithOne(p => p.TenantsMainAccount)
                    .HasForeignKey<TenantsMainAccount>(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsMainAccounts_Tenants");
            });

            modelBuilder.Entity<TenantStatusType>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<TenantsTenancyAgreement>(entity =>
            {
                entity.HasKey(e => new { e.TenancyAgreementId, e.TenantId });

                entity.HasIndex(e => new { e.TenantId, e.TenancyAgreementId })
                    .HasName("UK_TenantsTenancyAgreements")
                    .IsUnique();

                entity.Property(e => e.BedroomLocation).IsUnicode(false);

                entity.Property(e => e.DepositPrescribedInfoGivenAddress).IsUnicode(false);

                entity.Property(e => e.DepositPrescribedInfoGivenMethod).IsUnicode(false);

                entity.Property(e => e.ExtRef).IsUnicode(false);

                entity.Property(e => e.GuarantorApproved).IsUnicode(false);

                entity.Property(e => e.PostTenancyAddressCountry).IsUnicode(false);

                entity.Property(e => e.PostTenancyAddressLine1).IsUnicode(false);

                entity.Property(e => e.PostTenancyAddressLine2).IsUnicode(false);

                entity.Property(e => e.PostTenancyAddressPostcode).IsUnicode(false);

                entity.Property(e => e.PostTenancyAddressTown).IsUnicode(false);

                entity.Property(e => e.PostTenancyBank).IsUnicode(false);

                entity.Property(e => e.PostTenancyBankAccountName).IsUnicode(false);

                entity.Property(e => e.PostTenancyBankAccountNameAlias).IsUnicode(false);

                entity.Property(e => e.PostTenancyBankAccountNo).IsUnicode(false);

                entity.Property(e => e.PostTenancyBankAccountSortCode).IsUnicode(false);

                entity.Property(e => e.RentPayee)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SignedAgreement)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SourcedFrom).IsUnicode(false);

                entity.Property(e => e.StandingOrderApproved).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.TenantsTenancyAgreements)
                    .HasForeignKey(d => d.StatusCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyAgreements_TenantStatusTypes");

                entity.HasOne(d => d.TenancyAgreement)
                    .WithMany(p => p.TenantsTenancyAgreements)
                    .HasForeignKey(d => d.TenancyAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyAgreements_TenancyAgreements");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantsTenancyAgreements)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyAgreements_Tenants");
            });

            modelBuilder.Entity<TenantsTenancyAgreementLedgerTransaction>(entity =>
            {
                entity.HasKey(e => new { e.TenancyAgreementId, e.TenantId, e.LedgerTransactionId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.LedgerTransaction)
                    .WithMany(p => p.TenantsTenancyAgreementLedgerTransactions)
                    .HasForeignKey(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyAgreementTransactionItems_TransactionItems");

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.TenantsTenancyAgreementLedgerTransactions)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyAgreementTransactionItems_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenantsTenancyAgreementNote>(entity =>
            {
                entity.HasKey(e => new { e.TenancyAgreementId, e.TenantId, e.NoteId });

                entity.Property(e => e.Dummy).IsUnicode(false);

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.TenantsTenancyAgreementNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyAgreementNotes_Notes");

                entity.HasOne(d => d.Tenan)
                    .WithMany(p => p.TenantsTenancyAgreementNotes)
                    .HasForeignKey(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyAgreementNotes_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenantsTenancyDepositHeldAccount>(entity =>
            {
                entity.HasIndex(e => new { e.TenancyAgreementId, e.TenantId })
                    .HasName("UK_TenantsTenancyDepositHeldAccounts2")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenantsTenancyDepositHeldAccount)
                    .HasForeignKey<TenantsTenancyDepositHeldAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyDepositHeldAccounts_Ledgers");

                entity.HasOne(d => d.Tenan)
                    .WithOne(p => p.TenantsTenancyDepositHeldAccount)
                    .HasForeignKey<TenantsTenancyDepositHeldAccount>(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyDepositHeldAccounts_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenantsTenancyGuaranteedRentAccount>(entity =>
            {
                entity.HasIndex(e => new { e.TenancyAgreementId, e.TenantId })
                    .HasName("UK_TenantsTenancyGuaranteedRentAccounts2")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.AutoDebtCollectProcessOrder).HasDefaultValueSql("((20))");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenantsTenancyGuaranteedRentAccount)
                    .HasForeignKey<TenantsTenancyGuaranteedRentAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyGuaranteedRentAccounts_Ledgers");

                entity.HasOne(d => d.Tenan)
                    .WithOne(p => p.TenantsTenancyGuaranteedRentAccount)
                    .HasForeignKey<TenantsTenancyGuaranteedRentAccount>(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyGuaranteedRentAccounts_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenantsTenancyOutstandingDepositAccount>(entity =>
            {
                entity.HasIndex(e => new { e.TenancyAgreementId, e.TenantId })
                    .HasName("Uk_TenantsTenancyOutstandingDepositAccounts2")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.AutoDebtCollectProcessOrder).HasDefaultValueSql("((10))");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenantsTenancyOutstandingDepositAccount)
                    .HasForeignKey<TenantsTenancyOutstandingDepositAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyOutstandingDepositAccounts_Ledgers");

                entity.HasOne(d => d.Tenan)
                    .WithOne(p => p.TenantsTenancyOutstandingDepositAccount)
                    .HasForeignKey<TenantsTenancyOutstandingDepositAccount>(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyOutstandingDepositAccounts_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenantsTenancyOutstandingGeneralAccount>(entity =>
            {
                entity.HasIndex(e => new { e.TenancyAgreementId, e.TenantId })
                    .HasName("UK_TenantsTenancyOutstandingGeneralAccounts2")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.AutoDebtCollectProcessOrder).HasDefaultValueSql("((40))");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenantsTenancyOutstandingGeneralAccount)
                    .HasForeignKey<TenantsTenancyOutstandingGeneralAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyOutstandingGeneralAccounts_Ledgers");

                entity.HasOne(d => d.Tenan)
                    .WithOne(p => p.TenantsTenancyOutstandingGeneralAccount)
                    .HasForeignKey<TenantsTenancyOutstandingGeneralAccount>(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyOutstandingGeneralAccounts_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenantsTenancyOutstandingRentAccount>(entity =>
            {
                entity.HasIndex(e => new { e.TenancyAgreementId, e.TenantId })
                    .HasName("UK_TenantsTenancyOutstandingRentAccounts2")
                    .IsUnique();

                entity.Property(e => e.LedgerId).ValueGeneratedNever();

                entity.Property(e => e.AutoDebtCollectProcessOrder).HasDefaultValueSql("((30))");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.TenantsTenancyOutstandingRentAccount)
                    .HasForeignKey<TenantsTenancyOutstandingRentAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyOutstandingRentAccounts_Ledgers");

                entity.HasOne(d => d.Tenan)
                    .WithOne(p => p.TenantsTenancyOutstandingRentAccount)
                    .HasForeignKey<TenantsTenancyOutstandingRentAccount>(d => new { d.TenancyAgreementId, d.TenantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantsTenancyOutstandingRentAccounts_TenantsTenancyAgreements");
            });

            modelBuilder.Entity<TenantType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });

            modelBuilder.Entity<TenantUserAccessProfile>(entity =>
            {
                entity.HasIndex(e => e.UserAccessProfileId)
                    .HasName("UK_TenantUserAccessProfiles")
                    .IsUnique();

                entity.Property(e => e.TenantId).ValueGeneratedNever();

                entity.HasOne(d => d.Tenant)
                    .WithOne(p => p.TenantUserAccessProfile)
                    .HasForeignKey<TenantUserAccessProfile>(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantUserAccessProfiles_Tenants");

                entity.HasOne(d => d.UserAccessProfile)
                    .WithOne(p => p.TenantUserAccessProfile)
                    .HasForeignKey<TenantUserAccessProfile>(d => d.UserAccessProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantUserAccessProfiles_UserAccessProfiles");
            });

            modelBuilder.Entity<TestDataSourceBanking>(entity =>
            {
                entity.Property(e => e.BankDepositId).IsUnicode(false);

                entity.Property(e => e.LedgerTransactions).IsUnicode(false);

                entity.Property(e => e.Pause).HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<TestDataSourceTransaction>(entity =>
            {
                entity.Property(e => e.Pause).HasDefaultValueSql("((1))");

                entity.Property(e => e.PropertyCode).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<UploadedBankStatementFile>(entity =>
            {
                entity.HasIndex(e => e.FileName)
                    .HasName("UK_DownloadedBankStatement")
                    .IsUnique();

                entity.Property(e => e.BaseDir).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ConfirmedDuplicates).IsUnicode(false);

                entity.Property(e => e.ConfirmedNonDuplicates).IsUnicode(false);

                entity.Property(e => e.FileDir).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FileType).IsUnicode(false);

                entity.Property(e => e.GeneratedBankTxRows).IsUnicode(false);

                entity.Property(e => e.InspectionOutcome).IsUnicode(false);

                entity.Property(e => e.NonGeneratedBankTxRows).IsUnicode(false);

                entity.Property(e => e.PossibleDuplicates).IsUnicode(false);

                entity.Property(e => e.RowOrder).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('New')");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.UploadedBankStatementFiles)
                    .HasForeignKey(d => d.BankAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UploadedBankTransactionFiles_BankAccounts");

                entity.HasOne(d => d.CsvFileFormat)
                    .WithMany(p => p.UploadedBankStatementFiles)
                    .HasForeignKey(d => d.CsvFileFormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UploadedBankTransactionFiles_CsvFileFormats");
            });

            modelBuilder.Entity<UserAccessProfile>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Pin).IsUnicode(false);
            });

            modelBuilder.Entity<VatAccount>(entity =>
            {
                entity.HasIndex(e => e.LedgerId)
                    .HasName("UK_VatAccounts")
                    .IsUnique();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.SchemeType).IsUnicode(false);

                entity.Property(e => e.VatNo).IsUnicode(false);

                entity.HasOne(d => d.Ledger)
                    .WithOne(p => p.VatAccount)
                    .HasForeignKey<VatAccount>(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatAccounts_Ledgers");
            });

            modelBuilder.Entity<VatLedgerTransaction>(entity =>
            {
                entity.HasIndex(e => e.LedgerTransactionId)
                    .HasName("IX_VatTransactionItems")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.Property(e => e.VatPeriod).IsUnicode(false);

                entity.HasOne(d => d.InvoiceHeader)
                    .WithMany(p => p.VatLedgerTransactions)
                    .HasForeignKey(d => d.InvoiceHeaderId)
                    .HasConstraintName("FK_VatTransactionItems_InvoiceHeaders");

                entity.HasOne(d => d.LedgerTransaction)
                    .WithOne(p => p.VatLedgerTransaction)
                    .HasForeignKey<VatLedgerTransaction>(d => d.LedgerTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatTransactionItems_TransactionItems");

                entity.HasOne(d => d.VatAccount)
                    .WithMany(p => p.VatLedgerTransactions)
                    .HasForeignKey(d => d.VatAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatTransactionItems_VatAccounts");
            });

            modelBuilder.Entity<VatRate>(entity =>
            {
                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.VatType)
                    .WithMany(p => p.VatRates)
                    .HasForeignKey(d => d.VatTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatRates_VatTypes");
            });

            modelBuilder.Entity<VatType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_VatTypes")
                    .IsUnique();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });
        }
    }
}
