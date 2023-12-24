using MigraDoc.Rendering;
using PdfSharp.Fonts;
using Westry;

class CustomFontResolver : IFontResolver
{
	public byte[] GetFont(string faceName)
	{
		if (faceName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
		{
			using (var stream = typeof(Program).Assembly.GetManifestResourceStream("YourNamespace.Arial.ttf"))
			{
				if (stream != null)
				{
					var buffer = new byte[stream.Length];
					stream.Read(buffer, 0, buffer.Length);
					return buffer;
				}
			}
		}
		return null;
	}

	public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
	{
		if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
		{
			return new FontResolverInfo("Arial#");
		}
		return null;
	}
}
