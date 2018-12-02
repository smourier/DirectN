// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(6099,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56c03d9c-9dbb-45f5-ab4b-d80f47c05938"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFStreamDescriptor
    {
        [PreserveSig]
        HRESULT GetStreamIdentifier(/* [out] __RPC__out */ out uint pdwStreamIdentifier);
        
        [PreserveSig]
        HRESULT GetMediaTypeHandler(/* [out] __RPC__deref_out_opt */ out IMFMediaTypeHandler ppMediaTypeHandler);
    }
}
