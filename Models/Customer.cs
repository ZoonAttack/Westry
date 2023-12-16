using System;
using System.Collections.Generic;

namespace Westry.Models;

public partial class Customer
{

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public int? MealId { get; set; }

    public int? SubscriptionCount { get; set; }

    public int? BreakfastCounter { get; set; }

    public int? LunchCounter { get; set; }

    public int? DinnerCounter { get; set; }

    public virtual Meal? Meal { get; set; }
}
