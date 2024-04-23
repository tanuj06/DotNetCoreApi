using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactsInitialBm
{
    public long InitialContactId { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Segment { get; set; }

    public string? IdNumber { get; set; }

    public string? InternetBanking { get; set; }

    public string? MobileNumber { get; set; }

    public string? Minor { get; set; }

    public string? Gender { get; set; }

    public string? Age { get; set; }

    public string? DebitCard { get; set; }

    public string? Cd { get; set; }

    public string? Current { get; set; }

    public string? Payroll { get; set; }

    public string? Saving { get; set; }

    public string? Td { get; set; }

    public string? SecuredLoan { get; set; }

    public string? UnsecuredLoan { get; set; }

    public string? CreditCard { get; set; }

    public string? Owner { get; set; }

    public bool? IsMoved { get; set; }

    public string? ValidationMessage { get; set; }

    public DateTime? LastExecutionDateTime { get; set; }
}
