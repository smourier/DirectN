// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite.h(752,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFileStream
    {
        [PreserveSig]
        HRESULT ReadFileFragment(/* _Outptr_result_bytebuffer_(fragmentSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object fragmentStart, ulong fileOffset, ulong fragmentSize, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object fragmentContext);
        
        [PreserveSig]
        void ReleaseFileFragment([MarshalAs(UnmanagedType.IUnknown)] object fragmentContext);
        
        [PreserveSig]
        HRESULT GetFileSize(/* _Out_ */ out ulong fileSize);
        
        [PreserveSig]
        HRESULT GetLastWriteTime(/* _Out_ */ out ulong lastWriteTime);
    }
}
