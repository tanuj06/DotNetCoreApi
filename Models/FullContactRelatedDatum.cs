﻿using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FullContactRelatedDatum
{
    public long ContactId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PrimaryPhoneNumber { get; set; }

    public long? OrganisationTierMappingId { get; set; }

    public string? Tier { get; set; }

    public long ContactTypeId { get; set; }

    public string? ContactType { get; set; }

    public long? OwnerId { get; set; }

    public string? Owner { get; set; }

    public long? ContactSegmentId { get; set; }

    public string? Segment { get; set; }

    public string? CompanyName { get; set; }

    public string? NationalId { get; set; }

    public string? CustomerId { get; set; }

    public string? TradeLicenseNumber { get; set; }

    public DateOnly? Dob { get; set; }

    public decimal? MonthlySalary { get; set; }

    public string? JobTitle { get; set; }

    public string? ContactOwnersAndSharing { get; set; }

    public string? Attachments { get; set; }

    public string? ReferralType { get; set; }

    public string? ReferredBy { get; set; }
}
