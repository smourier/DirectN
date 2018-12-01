// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(8340,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("76b1bbdb-4ec8-4f36-b106-70a9316df593"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFAudioStreamVolume
    {
        [PreserveSig]
        HRESULT GetChannelCount(/* [out] __RPC__out */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT SetChannelVolume(/* [in] */ uint dwIndex, /* [in] */ float fLevel);
        
        [PreserveSig]
        HRESULT GetChannelVolume(/* [in] */ uint dwIndex, /* [out] __RPC__out */ out float pfLevel);
        
        [PreserveSig]
        HRESULT SetAllVolumes(/* [in] */ uint dwCount, /* [size_is][in] __RPC__in_ecount_full(dwCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] float[] pfVolumes);
        
        [PreserveSig]
        HRESULT GetAllVolumes(/* [in] */ uint dwCount, /* [size_is][out] __RPC__out_ecount_full(dwCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] float[] pfVolumes);
    }
}
