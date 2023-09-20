// generated from <Windows SDK Path>\um\dwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface for loading font file data.
    /// </summary>
    [ComImport, Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFileStream
    {
        [PreserveSig]
        HRESULT ReadFileFragment(/* _Outptr_result_bytebuffer_(fragmentSize) */ out IntPtr fragmentStart, ulong fileOffset, ulong fragmentSize, /* _Out_ */ out IntPtr fragmentContext);
        
        [PreserveSig]
        void ReleaseFileFragment(IntPtr fragmentContext);
        
        [PreserveSig]
        HRESULT GetFileSize(/* _Out_ */ out ulong fileSize);
        
        [PreserveSig]
        HRESULT GetLastWriteTime(/* _Out_ */ out ulong lastWriteTime);
    }
}
