using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Westry.Util
{
	public static class StringExtensions
	{
		private static readonly Regex ContainsArabicCharsOnlyRegex = new Regex(
			@"^[\u0020-\u002F|\u0600-\u06FF|\d]+$",
			RegexOptions.CultureInvariant | RegexOptions.Compiled);

		public static bool ContainsArabicCharactersOnly(this string text)
		{
			if (text == null)
			{
				throw new ArgumentNullException(nameof(text));
			}

			if (text == string.Empty)
			{
				return false;
			}

			return ContainsArabicCharsOnlyRegex.IsMatch(text);
		}
	}
}
