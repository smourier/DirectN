// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineendpoint.h(1003,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e1546dce-9dd1-418b-9ab2-348ced161c86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointOffloadStreamMeter
    {
        [PreserveSig]
        HRESULT GetMeterChannelCount(/* [out] */ out uint pu32ChannelCount);
        
        [PreserveSig]
        HRESULT GetMeteringData(/* [in] */ uint u32ChannelCount, /* [out] */ out float pf32PeakValues);
    }
}
