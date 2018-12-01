// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(6765,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("23ff334c-442c-445f-bccc-edc438aa11e2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextTrackList
    {
        [PreserveSig]
        uint GetLength();
        
        [PreserveSig]
        HRESULT GetTrack(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _COM_Outptr_ */ out IMFTimedTextTrack track);
        
        [PreserveSig]
        HRESULT GetTrackById(/* [annotation][in] _In_ */ uint trackId, /* [annotation][out] _COM_Outptr_ */ out IMFTimedTextTrack track);
    }
}
