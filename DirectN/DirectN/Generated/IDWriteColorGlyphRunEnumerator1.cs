// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_3.h(1875,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Enumerator for an ordered collection of color glyph runs.
    /// </summary>
    [ComImport, Guid("7c5f86da-c7a1-4f05-b8e1-55a179fe5a35"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator
    {
        // IDWriteColorGlyphRunEnumerator
        [PreserveSig]
        new HRESULT MoveNext(/* _Out_ */ out bool hasRun);
        
        [PreserveSig]
        new HRESULT GetCurrentRun(/* _Outptr_ */ out IntPtr colorGlyphRun);
        
        // IDWriteColorGlyphRunEnumerator1
        [PreserveSig]
        HRESULT GetCurrentRun1(/* _Outptr_ */ out IntPtr colorGlyphRun);
    }
}
