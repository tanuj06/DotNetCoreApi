using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BankEmployeeRelatedDatum
{
    public long BankEmployeeId { get; set; }

    public long BankId { get; set; }

    public string? BankName { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? BranchName { get; set; }

    public string? BranchCode { get; set; }

    public long? OrganisationId { get; set; }

    public string OrgName { get; set; } = null!;
}
