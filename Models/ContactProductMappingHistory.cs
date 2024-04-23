using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactProductMappingHistory
{
    public long HistoryId { get; set; }

    public long ContactId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductType { get; set; }

    public string? ProductReferenceNumber { get; set; }

    public string? ProductAmount { get; set; }

    public string? OutstandingBalance { get; set; }

    public string? StartDate { get; set; }

    public string? Expirydate { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string? Field6 { get; set; }

    public string? Field7 { get; set; }

    public string? Field8 { get; set; }

    public string? Field9 { get; set; }

    public string? Field10 { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Currency { get; set; }

    public long? ContactProductImportHistoryId { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactProductImportHistory? ContactProductImportHistory { get; set; }
}
