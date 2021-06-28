// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(1994,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dd79923c-0599-45e0-b8b6-c8df7db6e796"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioPeakMeter
    {
        [PreserveSig]
        HRESULT GetChannelCount(/* [annotation][out] _Out_ */ out uint pcChannels);
        
        [PreserveSig]
        HRESULT GetLevel(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][out] _Out_ */ out float pfLevel);
    }
}
