// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioclient.h(1614,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("93014887-242d-4068-8a15-cf5e93b90fe3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioStreamVolume
    {
        [PreserveSig]
        HRESULT GetChannelCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT SetChannelVolume(/* [annotation][in] _In_ */ uint dwIndex, /* [annotation][in] _In_ */ float fLevel);
        
        [PreserveSig]
        HRESULT GetChannelVolume(/* [annotation][in] _In_ */ uint dwIndex, /* [annotation][out] _Out_ */ out float pfLevel);
        
        [PreserveSig]
        HRESULT SetAllVolumes(/* [annotation][in] _In_ */ uint dwCount, /* [annotation][size_is][in] _In_reads_(dwCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] float[] pfVolumes);
        
        [PreserveSig]
        HRESULT GetAllVolumes(/* [annotation][in] _In_ */ uint dwCount, /* [annotation][size_is][out] _Out_writes_(dwCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] float[] pfVolumes);
    }
}
