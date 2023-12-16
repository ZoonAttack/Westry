using System;
using System.Collections.Generic;

namespace Westry.Models;

public partial class MealLog
{
    public int RecordId { get; set; }

    public int? MealId { get; set; }

    public int? Count { get; set; }

    public virtual Meal? Meal { get; set; }
}
