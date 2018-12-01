// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfreadwrite.h(342,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("70ae66f2-c809-4e4f-8915-bdcb406b7993"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceReader
    {
        [PreserveSig]
        HRESULT GetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out bool pfSelected);
        
        [PreserveSig]
        HRESULT SetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ bool fSelected);
        
        [PreserveSig]
        HRESULT GetNativeMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwMediaTypeIndex, /* [annotation][out] _Out_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT GetCurrentMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT SetCurrentMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out][in] _Reserved_ */ ref uint pdwReserved, /* [annotation][in] _In_ */ IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT SetCurrentPosition(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidTimeFormat, /* [annotation][in] _In_ */ PropVariant varPosition);
        
        [PreserveSig]
        HRESULT ReadSample(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwControlFlags, /* [annotation][out] _Out_opt_ */ out uint pdwActualStreamIndex, /* [annotation][out] _Out_opt_ */ out uint pdwStreamFlags, /* [annotation][out] _Out_opt_ */ out long pllTimestamp, /* [annotation][out] _Out_opt_ */ out IMFSample ppSample);
        
        [PreserveSig]
        HRESULT Flush(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        HRESULT GetServiceForStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT GetPresentationAttribute(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidAttribute, /* [annotation][out] _Out_ */ PropVariant pvarAttribute);
    }
}
