// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3DA636C9-BA71-4024-A301-30CBF125305B"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlobUtf8 : IDxcBlobEncoding
    {
        // IDxcBlob
        [PreserveSig]
        new IntPtr GetBufferPointer();
        
        [PreserveSig]
        new IntPtr GetBufferSize();
        
        // IDxcBlobEncoding
        [PreserveSig]
        new HRESULT GetEncoding(/* _Out_ */ out bool pKnown, /* _Out_ */ out uint pCodePage);
        
        // IDxcBlobUtf8
        [PreserveSig]
        string GetStringPointer();
        
        [PreserveSig]
        IntPtr GetStringLength();
    }
}
