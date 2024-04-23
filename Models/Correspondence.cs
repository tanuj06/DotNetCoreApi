using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Correspondence
{
    public long CorresspondenceId { get; set; }

    public long? ModuleId { get; set; }

    public long EntityId { get; set; }

    public long? CorrespondenceTypeId { get; set; }

    public bool? IsDefault { get; set; }

    public string? Address { get; set; }

    public string? CityName { get; set; }

    public string? CountryName { get; set; }

    public string? StateName { get; set; }

    public string? Zip { get; set; }

    public string? GoogleLat { get; set; }

    public string? GoogleLong { get; set; }

    public string? Crmcode { get; set; }

    public bool? IsMandatory { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public bool? SyncStatus { get; set; }

    public int? AddedFromSource { get; set; }

    public long? ImportHistoryId { get; set; }

    public bool? IsPrimary { get; set; }

    public string? UnitNumber { get; set; }

    public string? PremiseName { get; set; }

    public string? StreetNumber { get; set; }

    public string? Makani { get; set; }

    public string? NearestLandmark { get; set; }

    public string? BuildingName { get; set; }

    public string? AddressStartDate { get; set; }

    public string? AddressEndDate { get; set; }

    public string? Region { get; set; }

    public virtual CorrospondanceType? CorrespondenceType { get; set; }

    public virtual Module? Module { get; set; }
}
