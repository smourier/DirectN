// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(18185,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fbb03414-d13b-4786-8319-5ac51fc0a136"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSource2 : IMFMediaSourceEx
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
        new HRESULT GetSourceAttributes(/* optional(IMFAttributes) */ out IntPtr ppAttributes);
        
        [PreserveSig]
        new HRESULT GetStreamAttributes(/* [in] */ uint dwStreamIdentifier, /* optional(IMFAttributes) */ out IntPtr ppAttributes);
        
        [PreserveSig]
        new HRESULT SetD3DManager(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pManager);
        
        // IMFMediaSource2
        [PreserveSig]
        HRESULT SetMediaType(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][in] _In_ */ ref IMFMediaType pMediaType);
    }
}
