// generated from <Windows SDK Path>\um\spatialaudioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("caabe452-a66a-4bee-a93e-e320463f6a53"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioClient2 : ISpatialAudioClient
    {
        // ISpatialAudioClient
        [PreserveSig]
        new HRESULT GetStaticObjectPosition(/* [annotation][in] _In_ */ AudioObjectType type, /* [annotation][out] _Out_ */ out float x, /* [annotation][out] _Out_ */ out float y, /* [annotation][out] _Out_ */ out float z);
        
        [PreserveSig]
        new HRESULT GetNativeStaticObjectTypeMask(/* [annotation][out] _Out_ */ out AudioObjectType mask);
        
        [PreserveSig]
        new HRESULT GetMaxDynamicObjectCount(/* [annotation][out] _Out_ */ out uint value);
        
        [PreserveSig]
        new HRESULT GetSupportedAudioObjectFormatEnumerator(/* [annotation][out] _COM_Outptr_ */ out IAudioFormatEnumerator enumerator);
        
        [PreserveSig]
        new HRESULT GetMaxFrameCount(/* [annotation][in] _In_ */ ref tWAVEFORMATEX objectFormat, /* [annotation][out] _Out_ */ out uint frameCountPerBuffer);
        
        [PreserveSig]
        new HRESULT IsAudioObjectFormatSupported(/* [annotation][in] _In_ */ ref tWAVEFORMATEX objectFormat);
        
        [PreserveSig]
        new HRESULT IsSpatialAudioStreamAvailable(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid streamUuid, /* [annotation][in] _In_opt_ */ [In, Out] PropVariant auxiliaryInfo);
        
        [PreserveSig]
        new HRESULT ActivateSpatialAudioStream(/* [annotation][in] _In_ */ [In, Out] PropVariant activationParams, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object stream);
        
        // ISpatialAudioClient2
        [PreserveSig]
        HRESULT IsOffloadCapable(/* [in] */ _AUDIO_STREAM_CATEGORY category, /* [annotation][out] _Out_ */ out bool isOffloadCapable);
        
        [PreserveSig]
        HRESULT GetMaxFrameCountForCategory(/* [in] */ _AUDIO_STREAM_CATEGORY category, /* [in] */ bool offloadEnabled, /* [annotation][in] _In_ */ ref tWAVEFORMATEX objectFormat, /* [annotation][out] _Out_ */ out uint frameCountPerBuffer);
    }
}
