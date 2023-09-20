// generated from <Windows SDK Path>\um\dwrite_3.h
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
