// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3c5f3e8a-90c0-464e-8136-898d2975f847"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextBouten
    {
        [PreserveSig]
        HRESULT GetBoutenType(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_BOUTEN_TYPE value);
        
        [PreserveSig]
        HRESULT GetBoutenColor(/* [annotation][out] _Out_ */ out _MFARGB value);
        
        [PreserveSig]
        HRESULT GetBoutenPosition(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_BOUTEN_POSITION value);
    }
}
