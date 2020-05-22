// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcapi.h(116,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7241d424-2646-4191-97c0-98e96e42fc68"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlobEncoding : IDxcBlob
    {
        // IDxcBlob
        [PreserveSig]
        new IntPtr GetBufferPointer();
        
        [PreserveSig]
        new IntPtr GetBufferSize();
        
        // IDxcBlobEncoding
        [PreserveSig]
        HRESULT GetEncoding(/* _Out_ */ out bool pKnown, /* _Out_ */ out uint pCodePage);
    }
}
