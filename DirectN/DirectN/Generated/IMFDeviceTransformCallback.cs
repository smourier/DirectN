// generated from <Windows SDK Path>\um\mftransform.h
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
