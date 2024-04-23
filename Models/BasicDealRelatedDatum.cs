﻿using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BasicDealRelatedDatum
{
    public long DealId { get; set; }

    public long ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public long ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? DealSubject { get; set; }

    public DateOnly? ExpectedDealCloseDate { get; set; }

    public long? OwnerId { get; set; }

    public string? OwnerName { get; set; }

    public long? DealStageId { get; set; }

    public string? DealStage { get; set; }

    public decimal? ExpectedDealSize { get; set; }

    public long? DealSourceId { get; set; }

    public string? DealSourceName { get; set; }
}