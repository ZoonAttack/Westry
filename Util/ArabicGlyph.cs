using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westry.Util
{
	
	public class ArabicGlyph
	{
		public ArabicGlyph(
			char code,
			char isolated,
			char initial,
			char medial,
			char final)
		{
			Code = code;
			Isolated = isolated;
			Initial = initial;
			Medial = medial;
			Final = final;
		}

		public char Code { get; set; }
		public char Isolated { get; set; }
		public char Initial { get; set; }
		public char Medial { get; set; }
		public char Final { get; set; }

		private string DebuggerDisplay => $"{(ushort)Code}/0x{(ushort)Code:X}";
	}

	public class ArabicCombinedGlyph : ArabicGlyph
	{
		public ArabicCombinedGlyph(
			char code,
			char nextCode,
			char isolated,
			char initial,
			char medial,
			char final)
			: base(code, isolated, initial, medial, final)
		{
			NextCode = nextCode;
		}

		public char NextCode { get; set; }
	}

	public static class ArabicGlyphConverter
	{
		private static readonly HashSet<char> TransparentChars =
			new HashSet<char>()
			{
			'\x0610', /* ARABIC SIGN SALLALLAHOU ALAYHE WASSALLAM */
            '\x0612', /* ARABIC SIGN ALAYHE ASSALLAM */
            '\x0613', /* ARABIC SIGN RADI ALLAHOU ANHU */
            '\x0614', /* ARABIC SIGN TAKHALLUS */
            '\x0615', /* ARABIC SMALL HIGH TAH */
            '\x064B', /* ARABIC FATHATAN */
            '\x064C', /* ARABIC DAMMATAN */
            '\x064D', /* ARABIC KASRATAN */
            '\x064E', /* ARABIC FATHA */
            '\x064F', /* ARABIC DAMMA */
            '\x0650', /* ARABIC KASRA */
            '\x0651', /* ARABIC SHADDA */
            '\x0652', /* ARABIC SUKUN */
            '\x0653', /* ARABIC MADDAH ABOVE */
            '\x0654', /* ARABIC HAMZA ABOVE */
            '\x0655', /* ARABIC HAMZA BELOW */
            '\x0656', /* ARABIC SUBSCRIPT ALEF */
            '\x0657', /* ARABIC INVERTED DAMMA */
            '\x0658', /* ARABIC MARK NOON GHUNNA */
            '\x0670', /* ARABIC LETTER SUPERSCRIPT ALEF */
            '\x06D6', /* ARABIC SMALL HIGH LIGATURE SAD WITH LAM WITH ALEF MAKSURA */
            '\x06D7', /* ARABIC SMALL HIGH LIGATURE QAF WITH LAM WITH ALEF MAKSURA */
            '\x06D8', /* ARABIC SMALL HIGH MEEM INITIAL FORM */
            '\x06D9', /* ARABIC SMALL HIGH LAM ALEF */
            '\x06DA', /* ARABIC SMALL HIGH JEEM */
            '\x06DB', /* ARABIC SMALL HIGH THREE DOTS */
            '\x06DC', /* ARABIC SMALL HIGH SEEN */
            '\x06DF', /* ARABIC SMALL HIGH ROUNDED ZERO */
            '\x06E0', /* ARABIC SMALL HIGH UPRIGHT RECTANGULAR ZERO */
            '\x06E1', /* ARABIC SMALL HIGH DOTLESS HEAD OF KHAH */
            '\x06E2', /* ARABIC SMALL HIGH MEEM ISOLATED FORM */
            '\x06E3', /* ARABIC SMALL LOW SEEN */
            '\x06E4', /* ARABIC SMALL HIGH MADDA */
            '\x06E7', /* ARABIC SMALL HIGH YEH */
            '\x06E8', /* ARABIC SMALL HIGH NOON */
            '\x06EA', /* ARABIC EMPTY CENTRE LOW STOP */
            '\x06EB', /* ARABIC EMPTY CENTRE HIGH STOP */
            '\x06EC', /* ARABIC ROUNDED HIGH STOP WITH FILLED CENTRE */
            '\x06ED' /* ARABIC SMALL LOW MEEM */
			};

		private static readonly IDictionary<char, ArabicGlyph> MappedGlyphs =
			new Dictionary<char, ArabicGlyph>()
			{
			{'\x0621', new ArabicGlyph('\x0621', '\xFE80', '\0', '\0', '\0')}, /* HAMZA */
            {'\x0622', new ArabicGlyph('\x0622', '\xFE81', '\0', '\0', '\xFE82')}, /* ALEF_MADDA */
            {'\x0623', new ArabicGlyph('\x0623', '\xFE83', '\0', '\0', '\xFE84')}, /* ALEF_HAMZA_ABOVE */
            {'\x0624', new ArabicGlyph('\x0624', '\xFE85', '\0', '\0', '\xFE86')}, /* WAW_HAMZA */
            {'\x0625', new ArabicGlyph('\x0625', '\xFE87', '\0', '\0', '\xFE88')}, /* ALEF_HAMZA_BELOW */
            {'\x0626', new ArabicGlyph('\x0626', '\xFE89', '\xFE8B', '\xFE8C', '\xFE8A')}, /* YEH_HAMZA */
            {'\x0627', new ArabicGlyph('\x0627', '\xFE8D', '\0', '\0', '\xFE8E')}, /* ALEF */
            {'\x0628', new ArabicGlyph('\x0628', '\xFE8F', '\xFE91', '\xFE92', '\xFE90')}, /* BEH */
            {'\x0629', new ArabicGlyph('\x0629', '\xFE93', '\0', '\0', '\xFE94')}, /* TEH_MARBUTA */
            {'\x062A', new ArabicGlyph('\x062A', '\xFE95', '\xFE97', '\xFE98', '\xFE96')}, /* TEH */
            {'\x062B', new ArabicGlyph('\x062B', '\xFE99', '\xFE9B', '\xFE9C', '\xFE9A')}, /* THEH */
            {'\x062C', new ArabicGlyph('\x062C', '\xFE9D', '\xFE9F', '\xFEA0', '\xFE9E')}, /* JEEM */
            {'\x062D', new ArabicGlyph('\x062D', '\xFEA1', '\xFEA3', '\xFEA4', '\xFEA2')}, /* HAH */
            {'\x062E', new ArabicGlyph('\x062E', '\xFEA5', '\xFEA7', '\xFEA8', '\xFEA6')}, /* KHAH */
            {'\x062F', new ArabicGlyph('\x062F', '\xFEA9', '\0', '\0', '\xFEAA')}, /* DAL */
            {'\x0630', new ArabicGlyph('\x0630', '\xFEAB', '\0', '\0', '\xFEAC')}, /* THAL */
            {'\x0631', new ArabicGlyph('\x0631', '\xFEAD', '\0', '\0', '\xFEAE')}, /* REH */
            {'\x0632', new ArabicGlyph('\x0632', '\xFEAF', '\0', '\0', '\xFEB0')}, /* ZAIN */
            {'\x0633', new ArabicGlyph('\x0633', '\xFEB1', '\xFEB3', '\xFEB4', '\xFEB2')}, /* SEEN */
            {'\x0634', new ArabicGlyph('\x0634', '\xFEB5', '\xFEB7', '\xFEB8', '\xFEB6')}, /* SHEEN */
            {'\x0635', new ArabicGlyph('\x0635', '\xFEB9', '\xFEBB', '\xFEBC', '\xFEBA')}, /* SAD */
            {'\x0636', new ArabicGlyph('\x0636', '\xFEBD', '\xFEBF', '\xFEC0', '\xFEBE')}, /* DAD */
            {'\x0637', new ArabicGlyph('\x0637', '\xFEC1', '\xFEC3', '\xFEC4', '\xFEC2')}, /* TAH */
            {'\x0638', new ArabicGlyph('\x0638', '\xFEC5', '\xFEC7', '\xFEC8', '\xFEC6')}, /* ZAH */
            {'\x0639', new ArabicGlyph('\x0639', '\xFEC9', '\xFECB', '\xFECC', '\xFECA')}, /* AIN */
            {'\x063A', new ArabicGlyph('\x063A', '\xFECD', '\xFECF', '\xFED0', '\xFECE')}, /* GHAIN */
            {'\x0640', new ArabicGlyph('\x0640', '\x0640', '\0', '\0', '\0')}, /* TATWEEL */
            {'\x0641', new ArabicGlyph('\x0641', '\xFED1', '\xFED3', '\xFED4', '\xFED2')}, /* FEH */
            {'\x0642', new ArabicGlyph('\x0642', '\xFED5', '\xFED7', '\xFED8', '\xFED6')}, /* QAF */
            {'\x0643', new ArabicGlyph('\x0643', '\xFED9', '\xFEDB', '\xFEDC', '\xFEDA')}, /* KAF */
            {'\x0644', new ArabicGlyph('\x0644', '\xFEDD', '\xFEDF', '\xFEE0', '\xFEDE')}, /* LAM */
            {'\x0645', new ArabicGlyph('\x0645', '\xFEE1', '\xFEE3', '\xFEE4', '\xFEE2')}, /* MEEM */
            {'\x0646', new ArabicGlyph('\x0646', '\xFEE5', '\xFEE7', '\xFEE8', '\xFEE6')}, /* NOON */
            {'\x0647', new ArabicGlyph('\x0647', '\xFEE9', '\xFEEB', '\xFEEC', '\xFEEA')}, /* HEH */
            {'\x0648', new ArabicGlyph('\x0648', '\xFEED', '\0', '\0', '\xFEEE')}, /* WAW */
            {'\x0649', new ArabicGlyph('\x0649', '\xFEEF', '\0', '\0', '\xFEF0')}, /* ALEF_MAKSURA */
            {'\x064A', new ArabicGlyph('\x064A', '\xFEF1', '\xFEF3', '\xFEF4', '\xFEF2')} /* YEH */
			};

		private static readonly IDictionary<int, ArabicCombinedGlyph> MappedCombinedGlyphs =
			new Dictionary<int, ArabicCombinedGlyph>
			{
            /* LAM_ALEF_MADDA */
            {
				(0x0644 << 16 | 0x0622), new ArabicCombinedGlyph('\x0644', '\x0622', '\xFEF5', '\0', '\0', '\xFEF6')
			},
            /* LAM_ALEF_HAMZA_ABOVE */
            {
				(0x0644 << 16 | 0x0623), new ArabicCombinedGlyph('\x0644', '\x0623', '\xFEF7', '\0', '\0', '\xFEF8')
			}, 
            /* LAM_ALEF_HAMZA_BELOW */
            {
				(0x0644 << 16 | 0x0625), new ArabicCombinedGlyph('\x0644', '\x0625', '\xFEF9', '\0', '\0', '\xFEFA')
			},
            /* LAM_ALEF */
            {
				(0x0644 << 16 | 0x0627), new ArabicCombinedGlyph('\x0644', '\x0627', '\xFEFB', '\0', '\0', '\xFEFC')
			}
			};

		public static string ConvertToArabicGlyphs(string text)
		{
			if (text == null)
			{
				throw new ArgumentNullException(nameof(text));
			}

			if (text == string.Empty)
			{
				return text;
			}

			int sourceLength = text.Length;
			var sb = new StringBuilder(text.Length);

			for (int i = 0; i < sourceLength; i++)
			{
				char currentChar = text[i];

				if (!MappedGlyphs.TryGetValue(currentChar, out ArabicGlyph glyph))
				{
					// Add any unmapped characters as-is, and proceed to next character.
					sb.Append(currentChar);

					continue;
				}

				int prevIndex = i - 1;
				int nextIndex = i + 1;
				char prevChar;
				char nextChar;

				// Transparent characters have no effect in the shaping process.
				// Ignore all transparent characters that comes BEFORE the current character.
				while (prevIndex >= 0)
				{
					if (!TransparentChars.Contains(text[prevIndex]))
					{
						break;
					}

					prevIndex--;
				}

				if (prevIndex < 0 ||
					!MappedGlyphs.TryGetValue(prevChar = text[prevIndex], out ArabicGlyph prevGlyph) ||
					(prevGlyph.Initial == '\0' || (prevGlyph.Initial == '\0' && glyph.Medial == '\0')))
				{
					prevChar = default;
				}

				// Transparent characters have no effect in the shaping process.
				// Ignore all the transparent characters that comes AFTER the current character.
				while (nextIndex < sourceLength)
				{
					if (!TransparentChars.Contains(text[nextIndex]))
					{
						break;
					}

					nextIndex++;
				}

				if (nextIndex >= sourceLength ||
					!MappedGlyphs.TryGetValue(nextChar = text[nextIndex], out ArabicGlyph nextGlyph) ||
					(nextGlyph.Medial == '\0' && nextGlyph.Final == '\0' && nextChar != '\x0640'))
				{
					nextChar = default;
				}

				char glyphChar;

				if (currentChar == '\x0644' &&
					nextChar != '\0' &&
					(nextChar == '\x0622' || nextChar == '\x0623' || nextChar == '\x0625' || nextChar == '\x0627') &&
					MappedCombinedGlyphs.TryGetValue(currentChar << 16 | nextChar, out ArabicCombinedGlyph combinedGlyph))
				{
					// Combinations
					glyphChar = prevChar != -1
						? combinedGlyph.Final
						: combinedGlyph.Isolated;

					// We added a glyph consisting of both the current and the next char.
					// Increment 'i', to skip the next character from the for-loop.
					i++;
				}
				else if (prevChar != '\0' && nextChar != '\0' && glyph.Medial != '\0')
				{
					// Medial
					glyphChar = glyph.Medial;
				}
				else if (prevChar != '\0' && glyph.Final != '\0')
				{
					// Final
					glyphChar = glyph.Final;
				}
				else if (nextChar != '\0' && glyph.Initial != '\0')
				{
					// Initial
					glyphChar = glyph.Initial;
				}
				else
				{
					// Isolated
					glyphChar = glyph.Isolated;
				}

				sb.Append(glyphChar);
			}

			return sb.ToString();
		}
	}
}
