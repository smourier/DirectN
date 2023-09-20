// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("632105fa-072e-11d3-8af9-00c04fb6bd3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
