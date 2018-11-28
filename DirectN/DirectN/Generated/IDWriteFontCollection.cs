using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFontCollection
    {
        [PreserveSig]
        int GetFontFamilyCount();

        [PreserveSig]
        HRESULT GetFontFamily(int index, out IDWriteFontFamily fontFamily);

        [PreserveSig]
        HRESULT FindFamilyName([MarshalAs(UnmanagedType.LPWStr)] string familyName, out int index, out bool exists);

        [PreserveSig]
        HRESULT GetFontFromFontFace(IDWriteFontFace fontFace, out IDWriteFont font);
    }
}
