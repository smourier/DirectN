using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFontFileLoader
    {
        [PreserveSig]
        HRESULT CreateStreamFromKey(IntPtr fontFileReferenceKey, int fontFileReferenceKeySize, out IDWriteFontFileStream fontFileStream);
    }
}
