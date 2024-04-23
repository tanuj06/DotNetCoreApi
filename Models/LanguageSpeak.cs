using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LanguageSpeak
{
    public int LanguageSpeakId { get; set; }

    public string? Name { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<UserLanguageMapping> UserLanguageMappings { get; set; } = new List<UserLanguageMapping>();
}
