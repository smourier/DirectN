// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(5424,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c56156c6-ea5b-48a5-9df8-fbe035d0929e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory
    {
        // IMFMediaEngineClassFactory
        [PreserveSig]
        new HRESULT CreateInstance(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ IMFAttributes pAttr, /* [annotation][out] _Outptr_ */ out IMFMediaEngine ppPlayer);
        
        [PreserveSig]
        new HRESULT CreateTimeRange(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppTimeRange);
        
        [PreserveSig]
        new HRESULT CreateError(/* [annotation][out] _Outptr_ */ out IMFMediaError ppError);
        
        // IMFMediaEngineClassFactoryEx
        [PreserveSig]
        HRESULT CreateMediaSourceExtension(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ IMFAttributes pAttr, /* [annotation][out] _COM_Outptr_ */ out IMFMediaSourceExtension ppMSE);
        
        [PreserveSig]
        HRESULT CreateMediaKeys(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string cdmStorePath, /* [annotation] _COM_Outptr_ */ out IMFMediaKeys ppKeys);
        
        [PreserveSig]
        HRESULT IsTypeSupported(/* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string type, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem, /* [annotation] _Out_ */ out bool isSupported);
    }
}
