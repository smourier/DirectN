// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\spatialaudioclient.h(264,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("cce0b8f2-8d4d-4efb-a8cf-3d6ecf1c30e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectBase
    {
        [PreserveSig]
        HRESULT GetBuffer(/* [annotation][size_is][size_is][out] _Outptr_result_bytebuffer_(*bufferLength) */ out byte[] buffer, /* [annotation][out] _Out_ */ out uint bufferLength);
        
        [PreserveSig]
        HRESULT SetEndOfStream(/* [annotation][in] _In_ */ uint frameCount);
        
        [PreserveSig]
        HRESULT IsActive(/* [annotation][out] _Out_ */ out bool isActive);
        
        [PreserveSig]
        HRESULT GetAudioObjectType(/* [annotation][out] _Out_ */ out AudioObjectType audioObjectType);
    }
}
