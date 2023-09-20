// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("28724c91-df35-4856-9f76-d6a26413f3df"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioAmbisonicsControl
    {
        [PreserveSig]
        HRESULT SetData(/* [size_is][in] __RPC__in_ecount_full(cbAmbisonicsParams) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] AMBISONICS_PARAMS[] pAmbisonicsParams, /* [in] */ int cbAmbisonicsParams);
        
        [PreserveSig]
        HRESULT SetHeadTracking(/* [in] */ bool bEnableHeadTracking);
        
        [PreserveSig]
        HRESULT GetHeadTracking(/* [out] __RPC__out */ out bool pbEnableHeadTracking);
        
        [PreserveSig]
        HRESULT SetRotation(/* [in] */ float X, /* [in] */ float Y, /* [in] */ float Z, /* [in] */ float W);
    }
}
