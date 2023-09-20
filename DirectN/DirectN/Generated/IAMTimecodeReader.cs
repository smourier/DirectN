// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b496ce1-811b-11cf-8c77-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTimecodeReader
    {
        [PreserveSig]
        HRESULT GetTCRMode(/* [in] */ int Param, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT SetTCRMode(/* [in] */ int Param, /* [in] */ int Value);
        
        [PreserveSig]
        HRESULT put_VITCLine(/* [in] */ int Line);
        
        [PreserveSig]
        HRESULT get_VITCLine(/* [annotation][out] _Out_ */ out long pLine);
        
        [PreserveSig]
        HRESULT GetTimecode(/* [annotation][out] _Out_ */ out tagTIMECODE_SAMPLE pTimecodeSample);
    }
}
