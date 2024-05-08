using System;
using System.Collections.Generic;

namespace AspNetCoreMVC_NorthwindTemplate.Models.Northwind;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
