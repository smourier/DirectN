// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfspatialaudio.h(259,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("abf28a9b-3393-4290-ba79-5ffc46d986b2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSpatialAudioSample
    {
        [PreserveSig]
        HRESULT GetObjectCount(/* [annotation][out] _Out_ */ out uint pdwObjectCount);
        
        [PreserveSig]
        HRESULT AddSpatialAudioObject(/* [annotation][in] _In_ */ IMFSpatialAudioObjectBuffer pAudioObjBuffer);
        
        [PreserveSig]
        HRESULT GetSpatialAudioObjectByIndex(/* [annotation][in] _In_ */ uint dwIndex, /* [annotation][out] _COM_Outptr_ */ out IMFSpatialAudioObjectBuffer ppAudioObjBuffer);
    }
}
