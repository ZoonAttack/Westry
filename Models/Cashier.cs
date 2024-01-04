using System;
using System.Collections.Generic;

namespace Westry.Models;

public partial class Cashier
{

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? ordersServied { get; set; }

    public DateTime? loggedInTime { get; set; }
    public DateTime? loggedOutTime { get; set; }
}
