using System;
using System.Collections.Generic;
using System.Text;

namespace DirectN
{
    public static class IDWriteLocalizedStringsExtensions
    {
        public static IReadOnlyList<DWriteLocalizedString> GetNames(this IDWriteLocalizedStrings strings)
        {
            if (strings == null)
                throw new ArgumentNullException(nameof(strings));

            var list = new List<DWriteLocalizedString>((int)strings.GetCount());
            for (var i = 0; i < list.Capacity; i++)
            {
                var name = new DWriteLocalizedString();
                strings.GetLocaleNameLength((uint)i, out var len).ThrowOnError();
                name.LocaleName = new string('\0', (int)len);
                strings.GetLocaleName((uint)i, name.LocaleName, len + 1);

                strings.GetStringLength((uint)i, out len).ThrowOnError();
                name.String = new string('\0', (int)len);
                strings.GetString((uint)i, name.String, len + 1);

                list.Add(name);
            }
            return list;
        }
    }
}
