using System;
using System.Collections.Generic;

namespace Westry.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
