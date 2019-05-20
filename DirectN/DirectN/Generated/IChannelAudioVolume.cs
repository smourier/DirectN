// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\audioclient.h(1982,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1c158861-b533-4b30-b1cf-e853e51c59b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IChannelAudioVolume
    {
        [PreserveSig]
        HRESULT GetChannelCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT SetChannelVolume(/* [annotation][in] _In_ */ uint dwIndex, /* [annotation][in] _In_ */ float fLevel, /* [unique][in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT GetChannelVolume(/* [annotation][in] _In_ */ uint dwIndex, /* [annotation][out] _Out_ */ out float pfLevel);
        
        [PreserveSig]
        HRESULT SetAllVolumes(/* [annotation][in] _In_ */ uint dwCount, /* [annotation][size_is][in] _In_reads_(dwCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] float[] pfVolumes, /* [unique][in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT GetAllVolumes(/* [annotation][in] _In_ */ uint dwCount, /* [annotation][size_is][out] _Out_writes_(dwCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] float[] pfVolumes);
    }
}
