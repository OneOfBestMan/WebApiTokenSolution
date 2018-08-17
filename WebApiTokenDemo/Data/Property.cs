using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Properties", Schema = "property")]
    public partial class Property
    {
        public Property()
        {
            Accommodations = new HashSet<Accommodation>();
            BranchsProperties = new HashSet<BranchsProperty>();
            ContractorInvoices = new HashSet<ContractorInvoice>();
            Keys = new HashSet<Key>();
            MaintenanceJobs = new HashSet<MaintenanceJob>();
            MaintenancePreferences = new HashSet<MaintenancePreference>();
            PropertyFacilities = new HashSet<PropertyFacility>();
            PropertyLedgerTransactions = new HashSet<PropertyLedgerTransaction>();
            PropertyMaintenanceCertificates = new HashSet<PropertyMaintenanceCertificate>();
            PropertyNotes = new HashSet<PropertyNote>();
            PropertyUtilityMeters = new HashSet<PropertyUtilityMeter>();
            PropertysLandlordHistories = new HashSet<PropertysLandlordHistory>();
            TenancyAgreements = new HashSet<TenancyAgreement>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [StringLength(20)]
        public string Alias { get; set; }
        [StringLength(50)]
        public string HouseNo { get; set; }
        [StringLength(50)]
        public string FlatName { get; set; }
        [StringLength(50)]
        public string Street { get; set; }
        [StringLength(50)]
        public string Locality { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string County { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(9)]
        public string PostCode { get; set; }
        public int? AreaId { get; set; }
        [StringLength(255)]
        public string StopcockLocation { get; set; }
        [StringLength(255)]
        public string FuseboxLocation { get; set; }
        [StringLength(10)]
        public string BurglarAlarmCode { get; set; }
        public byte? Bedrooms { get; set; }
        public byte? Bathrooms { get; set; }
        public byte? Receptionrooms { get; set; }
        [StringLength(1)]
        public string OffStreetParking { get; set; }
        public int? AssetId { get; set; }
        public int? OracleAccommodationId { get; set; }
        public int? MainImageId { get; set; }
        public int PropertyTypeId { get; set; }
        public int? PropertyBlockId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [StringLength(153)]
        public string ComputedAddressFirstLine { get; set; }
        [StringLength(164)]
        public string ComputedAddressFirstLinePostCode { get; set; }
        [StringLength(320)]
        public string ComputedAddressFull { get; set; }
        public bool ToLetIndi { get; set; }
        public bool ForSaleIndi { get; set; }
        public bool ActiveRecordIndi { get; set; }
        [StringLength(255)]
        public string FireDetectionType { get; set; }
        [StringLength(1000)]
        public string FireDetectionNotes { get; set; }
        [StringLength(255)]
        public string GasBoilerType { get; set; }
        [StringLength(1000)]
        public string GasBoilerNotes { get; set; }
        [Required]
        [StringLength(50)]
        public string PublicId { get; set; }
        [StringLength(255)]
        public string CarbonMonoxideDetectorType { get; set; }
        [StringLength(1000)]
        public string CarbonMonoxideDetectorNotes { get; set; }

        [ForeignKey("AreaId")]
        [InverseProperty("Properties")]
        public Area Area { get; set; }
        [ForeignKey("AssetId")]
        [InverseProperty("Properties")]
        public Asset Asset { get; set; }
        [ForeignKey("MainImageId")]
        [InverseProperty("Properties")]
        public Image MainImage { get; set; }
        [ForeignKey("PropertyBlockId")]
        [InverseProperty("Properties")]
        public PropertyBlock PropertyBlock { get; set; }
        [ForeignKey("PropertyTypeId")]
        [InverseProperty("Properties")]
        public PropertyType PropertyType { get; set; }
        [InverseProperty("Property")]
        public ICollection<Accommodation> Accommodations { get; set; }
        [InverseProperty("Property")]
        public ICollection<BranchsProperty> BranchsProperties { get; set; }
        [InverseProperty("Property")]
        public ICollection<ContractorInvoice> ContractorInvoices { get; set; }
        [InverseProperty("Property")]
        public ICollection<Key> Keys { get; set; }
        [InverseProperty("Property")]
        public ICollection<MaintenanceJob> MaintenanceJobs { get; set; }
        [InverseProperty("PropertyNavigation")]
        public ICollection<MaintenancePreference> MaintenancePreferences { get; set; }
        [InverseProperty("Property")]
        public ICollection<PropertyFacility> PropertyFacilities { get; set; }
        [InverseProperty("Property")]
        public ICollection<PropertyLedgerTransaction> PropertyLedgerTransactions { get; set; }
        [InverseProperty("Property")]
        public ICollection<PropertyMaintenanceCertificate> PropertyMaintenanceCertificates { get; set; }
        [InverseProperty("Property")]
        public ICollection<PropertyNote> PropertyNotes { get; set; }
        [InverseProperty("Property")]
        public ICollection<PropertyUtilityMeter> PropertyUtilityMeters { get; set; }
        [InverseProperty("Property")]
        public ICollection<PropertysLandlordHistory> PropertysLandlordHistories { get; set; }
        [InverseProperty("Property")]
        public ICollection<TenancyAgreement> TenancyAgreements { get; set; }
    }
}
