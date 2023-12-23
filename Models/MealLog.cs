using System;
using System.Collections.Generic;

namespace Westry.Models;

public partial class MealLog
{
    public string PhoneNumber { get; set; }

    public int? MealId { get; set; }

    public string? choosen_meal { get; set; }

    public virtual Meal? Meal { get; set; }
}
