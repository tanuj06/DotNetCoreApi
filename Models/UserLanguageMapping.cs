using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserLanguageMapping
{
    public long UserLanguageMappingId { get; set; }

    public long UserId { get; set; }

    public int LanguageSpeakId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public bool IsDeleted { get; set; }

    public virtual LanguageSpeak LanguageSpeak { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
