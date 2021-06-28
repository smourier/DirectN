// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mftransform.h(1123,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d5cb646-29ec-41fb-8179-8c4c6d750811"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDeviceTransformCallback
    {
        [PreserveSig]
        HRESULT OnBufferSent(/* [annotation][in] _In_ */ IMFAttributes pCallbackAttributes, /* [annotation][in] _In_ */ uint pinId);
    }
}
