// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("23ff334c-442c-445f-bccc-edc438aa11e2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
