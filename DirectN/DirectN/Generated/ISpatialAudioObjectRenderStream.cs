// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\spatialaudioclient.h(669,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bab5f473-b423-477b-85f5-b5a332a04153"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectRenderStream : ISpatialAudioObjectRenderStreamBase
    {
        // ISpatialAudioObjectRenderStreamBase
        [PreserveSig]
        new HRESULT GetAvailableDynamicObjectCount(/* [annotation][out] _Out_ */ out uint value);
        
        [PreserveSig]
        new HRESULT GetService(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object service);
        
        [PreserveSig]
        new HRESULT Start();
        
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Reset();
        
        [PreserveSig]
        new HRESULT BeginUpdatingAudioObjects(/* [annotation][out] _Out_ */ out uint availableDynamicObjectCount, /* [annotation][out] _Out_ */ out uint frameCountPerBuffer);
        
        [PreserveSig]
        new HRESULT EndUpdatingAudioObjects();
        
        // ISpatialAudioObjectRenderStream
        [PreserveSig]
        HRESULT ActivateSpatialAudioObject(/* [annotation][in] _In_ */ AudioObjectType type, /* [annotation][out] _COM_Outptr_ */ out ISpatialAudioObject audioObject);
    }
}
