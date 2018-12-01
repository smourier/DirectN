// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(9161,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c6e13343-30ac-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoCompression
    {
        [PreserveSig]
        HRESULT put_KeyFrameRate(/* [in] */ int KeyFrameRate);
        
        [PreserveSig]
        HRESULT get_KeyFrameRate(/* [annotation][out] _Out_ */ out long pKeyFrameRate);
        
        [PreserveSig]
        HRESULT put_PFramesPerKeyFrame(/* [in] */ int PFramesPerKeyFrame);
        
        [PreserveSig]
        HRESULT get_PFramesPerKeyFrame(/* [annotation][out] _Out_ */ out long pPFramesPerKeyFrame);
        
        [PreserveSig]
        HRESULT put_Quality(/* [in] */ double Quality);
        
        [PreserveSig]
        HRESULT get_Quality(/* [annotation][out] _Out_ */ out double pQuality);
        
        [PreserveSig]
        HRESULT put_WindowSize(/* [in] */ ulong WindowSize);
        
        [PreserveSig]
        HRESULT get_WindowSize(/* [annotation][out] _Out_ */ out ulong pWindowSize);
        
        [PreserveSig]
        HRESULT GetInfo(/* [annotation][size_is][out] _Out_writes_bytes_opt_(*pcbVersion) */ [MarshalAs(UnmanagedType.LPWStr)] string pszVersion, /* [annotation][out][in] _Inout_opt_ */ ref int pcbVersion, /* [annotation][size_is][out] _Out_writes_bytes_opt_(*pcbDescription) */ [MarshalAs(UnmanagedType.LPWStr)] string pszDescription, /* [annotation][out][in] _Inout_opt_ */ ref int pcbDescription, /* [annotation][out] _Out_opt_ */ out long pDefaultKeyFrameRate, /* [annotation][out] _Out_opt_ */ out long pDefaultPFramesPerKey, /* [annotation][out] _Out_opt_ */ out double pDefaultQuality, /* [annotation][out] _Out_opt_ */ out long pCapabilities);
        
        [PreserveSig]
        HRESULT OverrideKeyFrame(/* [in] */ int FrameNumber);
        
        [PreserveSig]
        HRESULT OverrideFrameSize(/* [in] */ int FrameNumber, /* [in] */ int Size);
    }
}
