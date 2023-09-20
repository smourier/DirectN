// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b496ce2-811b-11cf-8c77-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTimecodeDisplay
    {
        [PreserveSig]
        HRESULT GetTCDisplayEnable(/* [annotation][out] _Out_ */ out long pState);
        
        [PreserveSig]
        HRESULT SetTCDisplayEnable(/* [in] */ int State);
        
        [PreserveSig]
        HRESULT GetTCDisplay(/* [in] */ int Param, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT SetTCDisplay(/* [in] */ int Param, /* [in] */ int Value);
    }
}
