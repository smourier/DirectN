// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(2433,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e7e9984f-f09f-4da4-903f-6e2e0efe56b5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMResamplerProps
    {
        [PreserveSig]
        HRESULT SetHalfFilterLength(/* [in] */ int lhalfFilterLen);
        
        [PreserveSig]
        HRESULT SetUserChannelMtx(/* [in] */ ref ChMtxType userChannelMtx);
    }
}
