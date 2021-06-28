// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(16256,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("436eee9c-264f-4242-90e1-4e330c107512"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMpeg2Demultiplexer
    {
        [PreserveSig]
        HRESULT CreateOutputPin(/* [in] */ ref _AMMediaType pMediaType, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPinName, /* [annotation][out] _Out_ */ out IPin ppIPin);
        
        [PreserveSig]
        HRESULT SetOutputPinMediaType(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPinName, /* [annotation][in] _In_ */ ref _AMMediaType pMediaType);
        
        [PreserveSig]
        HRESULT DeleteOutputPin(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPinName);
    }
}
