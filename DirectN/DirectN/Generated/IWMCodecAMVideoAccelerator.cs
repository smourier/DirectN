// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmdxva.h(185,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d98ee251-34e0-4a2d-9312-9b4c788d9fa1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecAMVideoAccelerator
    {
        [PreserveSig]
        HRESULT SetAcceleratorInterface(/* [in] */ IAMVideoAccelerator pIAMVA);
        
        [PreserveSig]
        HRESULT NegotiateConnection(/* [in] */ ref _DMOMediaType pMediaType);
        
        [PreserveSig]
        HRESULT SetPlayerNotify(/* [in] */ IWMPlayerTimestampHook pHook);
    }
}
