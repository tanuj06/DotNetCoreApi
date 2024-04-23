using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class JobTitleParentJobTitleMapping
{
    public int MappingId { get; set; }

    public string? BranchCode { get; set; }

    public string? JobTitle { get; set; }

    public string? ParentJobTitle { get; set; }

    public int? MaxNoOfUsers { get; set; }

    public string? ShortRole { get; set; }

    public string? DigiRole { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public long? JobTitleParentJobTitleMappingImportHistoryId { get; set; }
}
