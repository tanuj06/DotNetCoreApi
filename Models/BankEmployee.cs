using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BankEmployee
{
    public long BankEmployeeId { get; set; }

    public long? BankId { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? EmployeeName { get; set; }

    public long? OrganisationId { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public long? BankEmployeeImportHistoryId { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual Organisation? Organisation { get; set; }
}
