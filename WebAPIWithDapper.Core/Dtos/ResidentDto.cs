using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIWithDapper.Core.Dtos
{
    public partial class ResidentDto
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string ExternalResidentDisplayId { get; set; }
        public string ExternalResidentId { get; set; }
        public string ExternalLeaseId { get; set; }
        public string ExternalUnitId { get; set; }
        public string UnitName { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime? ComplianceStatusExpirationDate { get; set; }
        public string ComplianceStatusComment { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? LeaseStartDate { get; set; }
        public DateTime? LeaseEndDate { get; set; }
        public DateTime? MoveInDate { get; set; }
        public DateTime? MoveOutDate { get; set; }
        public DateTime NotifyExpirePolicy30DaysSentOn { get; set; }
        public DateTime? NotifyExpirePolicy1DaySentOn { get; set; }
        public int PropertyUnitId { get; set; }
        public int ResidentTypeId { get; set; }
        public int ResidentInsuranceComplianceStatusId { get; set; }
        public int ResidentStatusExemptReason { get; set; }
        public int PolicyStatusId { get; set; }
    }
}
