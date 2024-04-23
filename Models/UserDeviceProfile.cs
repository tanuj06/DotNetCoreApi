using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserDeviceProfile
{
    public long UserDeviceProfileId { get; set; }

    public long? UserId { get; set; }

    public string? DeviceId { get; set; }

    public string? DeviceDetails { get; set; }

    public string? ApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsBlocked { get; set; }

    public DateTime? LastLoginOn { get; set; }

    public string? LastLoginAt { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual User? User { get; set; }
}
