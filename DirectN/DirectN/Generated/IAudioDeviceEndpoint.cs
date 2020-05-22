// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioengineendpoint.h(630,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d4952f5a-a0b2-4cc4-8b82-9358488dd8ac"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
