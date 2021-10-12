// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(165,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("A3F84EAB-0FAA-497E-A39C-EE6ED60B2D84"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlobUtf16 : IDxcBlobEncoding
    {
        // IDxcBlob
        [PreserveSig]
        new IntPtr GetBufferPointer();
        
        [PreserveSig]
        new IntPtr GetBufferSize();
        
        // IDxcBlobEncoding
        [PreserveSig]
        new HRESULT GetEncoding(/* _Out_ */ out bool pKnown, /* _Out_ */ out uint pCodePage);
        
        // IDxcBlobUtf16
        [PreserveSig]
        string GetStringPointer();
        
        [PreserveSig]
        IntPtr GetStringLength();
    }
}
