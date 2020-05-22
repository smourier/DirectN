// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(13661,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b496ce0-811b-11cf-8c77-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTimecodeGenerator
    {
        [PreserveSig]
        HRESULT GetTCGMode(/* [in] */ int Param, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT SetTCGMode(/* [in] */ int Param, /* [in] */ int Value);
        
        [PreserveSig]
        HRESULT put_VITCLine(/* [in] */ int Line);
        
        [PreserveSig]
        HRESULT get_VITCLine(/* [annotation][out] _Out_ */ out long pLine);
        
        [PreserveSig]
        HRESULT SetTimecode(/* [in] */ ref tagTIMECODE_SAMPLE pTimecodeSample);
        
        [PreserveSig]
        HRESULT GetTimecode(/* [annotation][out] _Out_ */ out tagTIMECODE_SAMPLE pTimecodeSample);
    }
}
