using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1a0d8438-1d97-4ec1-aef9-a2fb86ed6acb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFontList
    {
        [PreserveSig]
        HRESULT GetFontCollection(out IDWriteFontCollection fontCollection);

        [PreserveSig]
        int GetFontCount();

        [PreserveSig]
        HRESULT GetFont(int index, out IDWriteFont font);
    }
}
