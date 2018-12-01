// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(696,1)
using System;
using System.Runtime.InteropServices;
using FILETIME = DirectN._FILETIME;

namespace DirectN
{
    /// <summary>
    /// A built-in implementation of IDWriteFontFileLoader interface that operates on local font files and exposes local font file information from the font file reference key. Font file references created using CreateFontFileReference use this font file loader.
    /// </summary>
    [Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteLocalFontFileLoader : IDWriteFontFileLoader
    {
        // IDWriteFontFileLoader
        [PreserveSig]
        new HRESULT CreateStreamFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ [MarshalAs(UnmanagedType.IUnknown)] object fontFileReferenceKey, uint fontFileReferenceKeySize, /* _COM_Outptr_ */ out IDWriteFontFileStream fontFileStream);
        
        // IDWriteLocalFontFileLoader
        [PreserveSig]
        HRESULT GetFilePathLengthFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ [MarshalAs(UnmanagedType.IUnknown)] object fontFileReferenceKey, uint fontFileReferenceKeySize, /* _Out_ */ out uint filePathLength);
        
        [PreserveSig]
        HRESULT GetFilePathFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ [MarshalAs(UnmanagedType.IUnknown)] object fontFileReferenceKey, uint fontFileReferenceKeySize, /* _Out_writes_z_(filePathSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] char[] filePath, uint filePathSize);
        
        [PreserveSig]
        HRESULT GetLastWriteTimeFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ [MarshalAs(UnmanagedType.IUnknown)] object fontFileReferenceKey, uint fontFileReferenceKeySize, /* _Out_ */ out FILETIME lastWriteTime);
    }
}
