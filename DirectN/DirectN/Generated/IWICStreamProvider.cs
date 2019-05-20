// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wincodecsdk.h(870,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("449494bc-b468-4927-96d7-ba90d31ab505"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICStreamProvider
    {
        [PreserveSig]
        HRESULT GetStream(/* [out] __RPC__deref_out_opt */ out IStream ppIStream);
        
        [PreserveSig]
        HRESULT GetPersistOptions(/* [out] __RPC__out */ out uint pdwPersistOptions);
        
        [PreserveSig]
        HRESULT GetPreferredVendorGUID(/* [out] __RPC__out */ out Guid pguidPreferredVendor);
        
        [PreserveSig]
        HRESULT RefreshStream();
    }
}
