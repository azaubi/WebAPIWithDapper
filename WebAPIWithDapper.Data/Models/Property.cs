namespace WebAPIWithDapper.Data.Models
{
    public class Property
    {
        public int Id { get; set; }
		public string OutsidePropertyId { get; set; } = string.Empty;
		public string OutsidePropertyId2 { get; set; } = string.Empty; // from RentManager v1 ApiPlugin
		public short PropertyTypeId { get; set; }
		public int PropertyManagerId { get; set; }
		public int? AccountManagerId { get; set; }
		public string NetSuiteCustomerId { get; set; } = string.Empty;
		public string NetsuiteRevenueShareId { get; set; } = string.Empty;
		public decimal LiabilityLimit { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Address1 { get; set; } = string.Empty;
		public string Address2 { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public virtual int StateId { get; set; }
		public string Zip { get; set; } = string.Empty;
		public bool IsActive { get; set; }
		public int? MigrationSourceLandlordId { get; set; }
		public int? MigrationSourcePropertyId { get; set; }
		public bool IncludeInMetrics { get; set; }
		public bool InsuranceAdministration { get; set; }
		public DateTime? InsuranceEnforceDate { get; set; }
		public string EmailSignature { get; set; }
		public int OwnedUnits { get; set; }
		public decimal WaiverFee { get; set; }
		public decimal RevenueShare { get; set; }
		public decimal ContentsCoverageLimit { get; set; }
		public DateTime? InsuranceAdministrationAsOfDate { get; set; }
		public bool IsWaiverLedgerBilling { get; set; }
		public bool IsWaiverProrated { get; set; }
		public int RecurringChargeOption { get; set; }
		public DateTime? RentistryAddedDate { get; set; }
		public int OwnerCompanyId { get; set; }
		public int PropertyManagementCompanyId { get; set; }
		public int RegionId { get; set; }
	}
}
