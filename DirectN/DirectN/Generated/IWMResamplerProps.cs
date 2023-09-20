// generated from <Windows SDK Path>\um\wmcodecdsp.h
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
