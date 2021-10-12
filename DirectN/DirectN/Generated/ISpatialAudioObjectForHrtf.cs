// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudiohrtf.h(194,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d7436ade-1978-4e14-aba0-555bd8eb83b4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectForHrtf : ISpatialAudioObjectBase
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
        
        // ISpatialAudioObjectForHrtf
        [PreserveSig]
        HRESULT SetPosition(/* [annotation][in] _In_ */ float x, /* [annotation][in] _In_ */ float y, /* [annotation][in] _In_ */ float z);
        
        [PreserveSig]
        HRESULT SetGain(/* [annotation][in] _In_ */ float gain);
        
        [PreserveSig]
        HRESULT SetOrientation(/* [annotation][in] _In_ */ ref SpatialAudioHrtfOrientation orientation);
        
        [PreserveSig]
        HRESULT SetEnvironment(/* [annotation][in] _In_ */ SpatialAudioHrtfEnvironmentType environment);
        
        [PreserveSig]
        HRESULT SetDistanceDecay(/* [annotation][in] _In_ */ ref SpatialAudioHrtfDistanceDecay distanceDecay);
        
        [PreserveSig]
        HRESULT SetDirectivity(/* [annotation][in] _In_ */ ref SpatialAudioHrtfDirectivityUnion directivity);
    }
}
