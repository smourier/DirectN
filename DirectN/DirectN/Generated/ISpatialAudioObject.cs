// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudioclient.h(433,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dde28967-521b-46e5-8f00-bd6f2bc8ab1d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObject : ISpatialAudioObjectBase
    {
        // ISpatialAudioObjectBase
        [PreserveSig]
        new HRESULT GetBuffer(/* [annotation][size_is][size_is][out] _Outptr_result_bytebuffer_(*bufferLength) */ out IntPtr buffer, /* [annotation][out] _Out_ */ out uint bufferLength);
        
        [PreserveSig]
        new HRESULT SetEndOfStream(/* [annotation][in] _In_ */ uint frameCount);
        
        [PreserveSig]
        new HRESULT IsActive(/* [annotation][out] _Out_ */ out bool isActive);
        
        [PreserveSig]
        new HRESULT GetAudioObjectType(/* [annotation][out] _Out_ */ out AudioObjectType audioObjectType);
        
        // ISpatialAudioObject
        [PreserveSig]
        HRESULT SetPosition(/* [annotation][in] _In_ */ float x, /* [annotation][in] _In_ */ float y, /* [annotation][in] _In_ */ float z);
        
        [PreserveSig]
        HRESULT SetVolume(/* [annotation][in] _In_ */ float volume);
    }
}
