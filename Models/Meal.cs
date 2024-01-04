using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Westry.Models;

public partial class Meal
{
    [Key]
    public int MealId { get; set; }

    public string? Name { get; set; }

    public bool? hasBreakfast {  get; set; }
    public bool? hasDinner { get; set; }
    public bool? hasLunch { get; set; }


	public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
    public virtual ICollection<BreakFastOption> BreakFastOptions { get; } = new List<BreakFastOption>();
    public virtual ICollection<DinnerOption> DinnerOptions { get; } = new List<DinnerOption>();
    public virtual ICollection<LunchOption> LunchOptions { get; } = new List<LunchOption>();

}
