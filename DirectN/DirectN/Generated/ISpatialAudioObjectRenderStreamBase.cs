// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\spatialaudioclient.h(523,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("feaaf403-c1d8-450d-aa05-e0ccee7502a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectRenderStreamBase
    {
        [PreserveSig]
        HRESULT GetAvailableDynamicObjectCount(/* [annotation][out] _Out_ */ out uint value);
        
        [PreserveSig]
        HRESULT GetService(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object service);
        
        [PreserveSig]
        HRESULT Start();
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT BeginUpdatingAudioObjects(/* [annotation][out] _Out_ */ out uint availableDynamicObjectCount, /* [annotation][out] _Out_ */ out uint frameCountPerBuffer);
        
        [PreserveSig]
        HRESULT EndUpdatingAudioObjects();
    }
}
