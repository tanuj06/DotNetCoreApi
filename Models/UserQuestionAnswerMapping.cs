using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserQuestionAnswerMapping
{
    public long UserQuestionAnswerMappingId { get; set; }

    public long UserId { get; set; }

    public long QuestionId { get; set; }

    public string Answers { get; set; } = null!;

    public int? OrganisationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual SecurityQuestion Question { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
