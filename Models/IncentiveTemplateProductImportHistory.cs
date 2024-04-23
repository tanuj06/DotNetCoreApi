using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateProductImportHistory
{
    public long IncentiveTemplateProductImportHistoryId { get; set; }

    public long? OrganisationId { get; set; }

    public DateTime ImportTimeStamp { get; set; }

    public string FileName { get; set; } = null!;

    public bool? IsReverted { get; set; }

    public string? Status { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string? UploadedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ProductTypeId { get; set; }

    public virtual ICollection<IncentiveTemplateProductImportAudit> IncentiveTemplateProductImportAuditNewImportHistories { get; set; } = new List<IncentiveTemplateProductImportAudit>();

    public virtual ICollection<IncentiveTemplateProductImportAudit> IncentiveTemplateProductImportAuditOldImportHistories { get; set; } = new List<IncentiveTemplateProductImportAudit>();

    public virtual ICollection<IncentiveTemplateProductImportMapping> IncentiveTemplateProductImportMappings { get; set; } = new List<IncentiveTemplateProductImportMapping>();

    public virtual ICollection<IncentiveTemplateProductMappingHistory> IncentiveTemplateProductMappingHistories { get; set; } = new List<IncentiveTemplateProductMappingHistory>();

    public virtual ICollection<IncentiveTransactionsBancAssuranceConventional> IncentiveTransactionsBancAssuranceConventionals { get; set; } = new List<IncentiveTransactionsBancAssuranceConventional>();

    public virtual ICollection<IncentiveTransactionsBancAssuranceIslamicReversed> IncentiveTransactionsBancAssuranceIslamicReverseds { get; set; } = new List<IncentiveTransactionsBancAssuranceIslamicReversed>();

    public virtual ICollection<IncentiveTransactionsBancAssuranceIslamic> IncentiveTransactionsBancAssuranceIslamics { get; set; } = new List<IncentiveTransactionsBancAssuranceIslamic>();

    public virtual ICollection<IncentiveTransactionsPayroll> IncentiveTransactionsPayrolls { get; set; } = new List<IncentiveTransactionsPayroll>();

    public virtual Organisation? Organisation { get; set; }

    public virtual IncentiveProductType? ProductType { get; set; }
}
