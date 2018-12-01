// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodecsdk.h(976,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("00675040-6908-45f8-86a3-49c7dfd6d9ad"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICPersistStream
    {
        [PreserveSig]
        HRESULT LoadEx(/* [unique][in] __RPC__in_opt */ ref IStream pIStream, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidPreferredVendor, /* [in] */ uint dwPersistOptions);
        
        [PreserveSig]
        HRESULT SaveEx(/* [in] __RPC__in_opt */ ref IStream pIStream, /* [in] */ uint dwPersistOptions, /* [in] */ bool fClearDirty);
    }
}
