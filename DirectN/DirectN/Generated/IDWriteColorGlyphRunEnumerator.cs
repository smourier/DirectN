// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_2.h(807,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Enumerator for an ordered collection of color glyph runs.
    /// </summary>
    [ComImport, Guid("d31fbe17-f157-41a2-8d24-cb779e0560e8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteColorGlyphRunEnumerator
    {
        [PreserveSig]
        HRESULT MoveNext(/* _Out_ */ out bool hasRun);
        
        [PreserveSig]
        HRESULT GetCurrentRun(/* _Outptr_ */ out IntPtr colorGlyphRun);
    }
}
