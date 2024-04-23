using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Coaching
{
    public long CoachingId { get; set; }

    public DateOnly? CoachingDate { get; set; }

    public string? CoachingNote { get; set; }

    public long? UserId { get; set; }

    public string? CoacheeNote { get; set; }

    public DateTime? CoacheeNoteDateTime { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual User? User { get; set; }
}
