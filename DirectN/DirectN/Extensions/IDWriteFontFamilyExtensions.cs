using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDWriteFontFamilyExtensions
    {
        public static IReadOnlyList<DWriteLocalizedString> GetNames(this IComObject<IDWriteFontFamily> family) => GetNames(family?.Object);
        public static IReadOnlyList<DWriteLocalizedString> GetNames(this IDWriteFontFamily family)
        {
            if (family == null)
                throw new ArgumentNullException(nameof(family));

            family.GetFamilyNames(out var names).ThrowOnError();
            return names.GetNames();
        }
    }
}
