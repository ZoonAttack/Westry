using System;
using System.Collections.Generic;

namespace Westry.Models;

public partial class Meal
{
    public int MealId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

}
