using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactPortfolioTransfer
{
    public long TransferRequestId { get; set; }

    public long OrganisationId { get; set; }

    public bool IsScheduled { get; set; }

    public DateTime TransferRequestDateTime { get; set; }

    public DateTime? ExecutionStartDateTime { get; set; }

    public DateTime? ExecutionEndDateTime { get; set; }

    public int PortfolioTransferStatusId { get; set; }

    public bool FromOwnerFlag { get; set; }

    public bool FromPreviousOwnerFlag { get; set; }

    public bool FromCurrentOwnerFlag { get; set; }

    public string? FromOwnerSelectedValues { get; set; }

    public bool FromBranchFlag { get; set; }

    public string? FromBranchSelectedValues { get; set; }

    public bool FromTierFlag { get; set; }

    public string? FromTierSelectedValues { get; set; }

    public bool FromSegmentFlag { get; set; }

    public string? FromSegmentSelectedValues { get; set; }

    public bool FromSourceFlag { get; set; }

    public string? FromSourceSelectedValues { get; set; }

    public string NewContactOwner { get; set; } = null!;

    public bool DealTransferFlag { get; set; }

    public int? DealTransferCriteria { get; set; }

    public bool ActivityTransferFlag { get; set; }

    public int? ActivityTransferCriteria { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<ContactPortfolioTransaction> ContactPortfolioTransactions { get; set; } = new List<ContactPortfolioTransaction>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual PortfolioTransferStatus PortfolioTransferStatus { get; set; } = null!;
}
