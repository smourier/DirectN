// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfspatialaudio.h(87,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d396ec8c-605e-4249-978d-72ad1c312872"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSpatialAudioObjectBuffer : IMFMediaBuffer
    {
        // IMFMediaBuffer
        [PreserveSig]
        new HRESULT Lock(/* [annotation][out] _Outptr_result_bytebuffer_to_(*pcbMaxLength, *pcbCurrentLength) */ out IntPtr ppbBuffer, /* [annotation][out] _Out_opt_ */ out uint pcbMaxLength, /* [annotation][out] _Out_opt_ */ out uint pcbCurrentLength);
        
        [PreserveSig]
        new HRESULT Unlock();
        
        [PreserveSig]
        new HRESULT GetCurrentLength(/* [annotation][out] _Out_ */ out uint pcbCurrentLength);
        
        [PreserveSig]
        new HRESULT SetCurrentLength(/* [in] */ uint cbCurrentLength);
        
        [PreserveSig]
        new HRESULT GetMaxLength(/* [annotation][out] _Out_ */ out uint pcbMaxLength);
        
        // IMFSpatialAudioObjectBuffer
        [PreserveSig]
        HRESULT SetID(/* [annotation][in] _In_ */ uint u32ID);
        
        [PreserveSig]
        HRESULT GetID(/* [annotation][out] _Out_ */ out uint pu32ID);
        
        [PreserveSig]
        HRESULT SetType(/* [annotation][in] _In_ */ AudioObjectType type);
        
        [PreserveSig]
        HRESULT GetType(/* [annotation][out] _Out_ */ out AudioObjectType pType);
        
        [PreserveSig]
        HRESULT GetMetadataItems(/* [annotation][out] _Outptr_result_nullonfailure_ */ out ISpatialAudioMetadataItems ppMetadataItems);
    }
}
