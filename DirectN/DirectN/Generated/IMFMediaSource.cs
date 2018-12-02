// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(1622,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("279a808d-aec7-40c8-9c6b-a6b492c78a66"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSource
    {
        [PreserveSig]
        HRESULT GetCharacteristics(/* [out] __RPC__out */ out uint pdwCharacteristics);
        
        [PreserveSig]
        HRESULT CreatePresentationDescriptor(/* [annotation][out] _Outptr_ */ out IMFPresentationDescriptor ppPresentationDescriptor);
        
        [PreserveSig]
        HRESULT Start(/* [in] __RPC__in_opt */ IMFPresentationDescriptor pPresentationDescriptor, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidTimeFormat, /* [unique][in] __RPC__in_opt */ PropVariant pvarStartPosition);
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
