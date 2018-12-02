// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfreadwrite.h(1648,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("17c3779e-3cde-4ede-8c60-3899f5f53ad6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSinkWriterEncoderConfig
    {
        [PreserveSig]
        HRESULT SetTargetMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ ref IMFMediaType pTargetMediaType, /* optional(IMFAttributes) */ IntPtr pEncodingParameters);
        
        [PreserveSig]
        HRESULT PlaceEncodingParameters(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ ref IMFAttributes pEncodingParameters);
    }
}
