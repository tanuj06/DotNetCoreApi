using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Module
{
    public long ModuleId { get; set; }

    public string Name { get; set; } = null!;

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public long? ModifiedOn { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual ICollection<Communication> Communications { get; set; } = new List<Communication>();

    public virtual ICollection<ContactPortfolioTransaction> ContactPortfolioTransactions { get; set; } = new List<ContactPortfolioTransaction>();

    public virtual ICollection<Correspondence> Correspondences { get; set; } = new List<Correspondence>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<OrganisationModulePermission> OrganisationModulePermissions { get; set; } = new List<OrganisationModulePermission>();

    public virtual ICollection<UserModuleAccessMapping> UserModuleAccessMappings { get; set; } = new List<UserModuleAccessMapping>();
}
