// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\spatialaudioclient.h(898,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bbf8e066-aaaa-49be-9a4d-fd2a858ea27f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioClient
    {
        [PreserveSig]
        HRESULT GetStaticObjectPosition(/* [annotation][in] _In_ */ AudioObjectType type, /* [annotation][out] _Out_ */ out float x, /* [annotation][out] _Out_ */ out float y, /* [annotation][out] _Out_ */ out float z);
        
        [PreserveSig]
        HRESULT GetNativeStaticObjectTypeMask(/* [annotation][out] _Out_ */ out AudioObjectType mask);
        
        [PreserveSig]
        HRESULT GetMaxDynamicObjectCount(/* [annotation][out] _Out_ */ out uint value);
        
        [PreserveSig]
        HRESULT GetSupportedAudioObjectFormatEnumerator(/* [annotation][out] _COM_Outptr_ */ out IAudioFormatEnumerator enumerator);
        
        [PreserveSig]
        HRESULT GetMaxFrameCount(/* [annotation][in] _In_ */ ref tWAVEFORMATEX objectFormat, /* [annotation][out] _Out_ */ out uint frameCountPerBuffer);
        
        [PreserveSig]
        HRESULT IsAudioObjectFormatSupported(/* [annotation][in] _In_ */ ref tWAVEFORMATEX objectFormat);
        
        [PreserveSig]
        HRESULT IsSpatialAudioStreamAvailable(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid streamUuid, /* [annotation][in] _In_opt_ */ [In, Out] PropVariant auxiliaryInfo);
        
        [PreserveSig]
        HRESULT ActivateSpatialAudioStream(/* [annotation][in] _In_ */ [In, Out] PropVariant activationParams, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object stream);
    }
}
