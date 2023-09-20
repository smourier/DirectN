// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("058d1f11-2a54-4bef-bd54-df706626b727"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRVideoStreamControl
    {
        [PreserveSig]
        HRESULT SetColorKey(/* [in] */ ref _DDCOLORKEY lpClrKey);
        
        [PreserveSig]
        HRESULT GetColorKey(/* [out] */ out _DDCOLORKEY lpClrKey);
        
        [PreserveSig]
        HRESULT SetStreamActiveState(/* [in] */ bool fActive);
        
        [PreserveSig]
        HRESULT GetStreamActiveState(/* [out] */ out bool lpfActive);
    }
}
