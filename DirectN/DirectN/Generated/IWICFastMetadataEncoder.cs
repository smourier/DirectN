// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(2621,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b84e2c09-78c9-4ac4-8bd3-524ae1663a2f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICFastMetadataEncoder
    {
        [PreserveSig]
        HRESULT Commit();
        
        [PreserveSig]
        HRESULT GetMetadataQueryWriter(/* [out] __RPC__deref_out_opt */ out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}
