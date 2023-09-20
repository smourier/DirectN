// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6e133b0-30ac-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMAnalogVideoEncoder
    {
        [PreserveSig]
        HRESULT get_AvailableTVFormats(/* [annotation][out] _Out_ */ out long lAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT put_TVFormat(/* [in] */ int lAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT get_TVFormat(/* [annotation][out] _Out_ */ out long plAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT put_CopyProtection(/* [in] */ int lVideoCopyProtection);
        
        [PreserveSig]
        HRESULT get_CopyProtection(/* [annotation][out] _Out_ */ out long lVideoCopyProtection);
        
        [PreserveSig]
        HRESULT put_CCEnable(/* [in] */ int lCCEnable);
        
        [PreserveSig]
        HRESULT get_CCEnable(/* [annotation][out] _Out_ */ out long lCCEnable);
    }
}
