using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westry.Models
{
	public partial class LunchOption
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int optionID {  get; set; }
		public string? optionName { get; set; }
		public int? MealId { get; set; }

		public virtual Meal? Meal { get; set; }
	}
}
