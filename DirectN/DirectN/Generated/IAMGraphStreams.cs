// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(15934,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("632105fa-072e-11d3-8af9-00c04fb6bd3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMGraphStreams
    {
        [PreserveSig]
        HRESULT FindUpstreamInterface(/* [in] */ IPin pPin, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvInterface, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT SyncUsingStreamOffset(/* [in] */ bool bUseStreamOffset);
        
        [PreserveSig]
        HRESULT SetMaxGraphLatency(/* [in] */ long rtMaxGraphLatency);
    }
}
