// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(1815,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3c9b2eb9-86d5-4514-a394-f56664f9f0d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSourceEx : IMFMediaSource
    {
        // IMFMediaSource
        [PreserveSig]
        new HRESULT GetCharacteristics(/* [out] __RPC__out */ out uint pdwCharacteristics);
        
        [PreserveSig]
        new HRESULT CreatePresentationDescriptor(/* [annotation][out] _Outptr_ */ out IMFPresentationDescriptor ppPresentationDescriptor);
        
        [PreserveSig]
        new HRESULT Start(/* [in] __RPC__in_opt */ IMFPresentationDescriptor pPresentationDescriptor, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidTimeFormat, /* [unique][in] __RPC__in_opt */ PropVariant pvarStartPosition);
        
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Pause();
        
        [PreserveSig]
        new HRESULT Shutdown();
        
        // IMFMediaSourceEx
        [PreserveSig]
        HRESULT GetSourceAttributes(/* optional(IMFAttributes) */ out IntPtr ppAttributes);
        
        [PreserveSig]
        HRESULT GetStreamAttributes(/* [in] */ uint dwStreamIdentifier, /* optional(IMFAttributes) */ out IntPtr ppAttributes);
        
        [PreserveSig]
        HRESULT SetD3DManager(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pManager);
    }
}
