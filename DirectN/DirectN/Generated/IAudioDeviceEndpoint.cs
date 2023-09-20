// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d4952f5a-a0b2-4cc4-8b82-9358488dd8ac"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioDeviceEndpoint
    {
        [PreserveSig]
        HRESULT SetBuffer(/* [in] */ long MaxPeriod, /* [in] */ uint u32LatencyCoefficient);
        
        [PreserveSig]
        HRESULT GetRTCaps(/* [out] */ out bool pbIsRTCapable);
        
        [PreserveSig]
        HRESULT GetEventDrivenCapable(/* [out] */ out bool pbisEventCapable);
        
        [PreserveSig]
        HRESULT WriteExclusiveModeParametersToSharedMemory(/* [in] */ IntPtr hTargetProcess, /* [in] */ long hnsPeriod, /* [in] */ long hnsBufferDuration, /* [in] */ uint u32LatencyCoefficient, /* [out] */ out uint pu32SharedMemorySize, /* [out] */ out IntPtr phSharedMemory);
    }
}
