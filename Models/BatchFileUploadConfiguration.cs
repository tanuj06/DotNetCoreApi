using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BatchFileUploadConfiguration
{
    public long ConfigurationId { get; set; }

    public string ConfigurationName { get; set; } = null!;

    public int ModuleId { get; set; }

    public string? InputFolderPath { get; set; }

    public string? ProcessingErrorFolderPath { get; set; }

    public string? CompletedFolderPath { get; set; }

    public string? PartiallyCompletedFolderPath { get; set; }

    public string? ErrorNotificationEmail { get; set; }

    public long OrganisationId { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}
