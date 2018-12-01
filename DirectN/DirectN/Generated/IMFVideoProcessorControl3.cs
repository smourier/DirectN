// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(3596,5)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [Guid("2424b3f2-eb23-40f1-91aa-74bddeea0883"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoProcessorControl3 : IMFVideoProcessorControl2
    {
        // IMFVideoProcessorControl
        [PreserveSig]
        new HRESULT SetBorderColor(/* optional(_MFARGB) */ IntPtr pBorderColor);
        
        [PreserveSig]
        new HRESULT SetSourceRectangle(/* optional(RECT) */ IntPtr pSrcRect);
        
        [PreserveSig]
        new HRESULT SetDestinationRectangle(/* optional(RECT) */ IntPtr pDstRect);
        
        [PreserveSig]
        new HRESULT SetMirror(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_MIRROR eMirror);
        
        [PreserveSig]
        new HRESULT SetRotation(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_ROTATION eRotation);
        
        [PreserveSig]
        new HRESULT SetConstrictionSize(/* optional(SIZE) */ IntPtr pConstrictionSize);
        
        // IMFVideoProcessorControl2
        [PreserveSig]
        new HRESULT SetRotationOverride(/* [annotation][in] _In_ */ uint uiRotation);
        
        [PreserveSig]
        new HRESULT EnableHardwareEffects(/* [annotation][in] _In_ */ bool fEnabled);
        
        [PreserveSig]
        new HRESULT GetSupportedHardwareEffects(/* [annotation][retval][out] _Out_ */ out uint puiSupport);
        
        // IMFVideoProcessorControl3
        [PreserveSig]
        HRESULT GetNaturalOutputType(/* [annotation][out] _Outptr_ */ out IMFMediaType ppType);
        
        [PreserveSig]
        HRESULT EnableSphericalVideoProcessing(/* [annotation][in] _In_ */ bool fEnable, /* [annotation][in] _In_ */ _MFVideoSphericalFormat eFormat, /* [annotation][in] _In_ */ MFVideoSphericalProjectionMode eProjectionMode);
        
        [PreserveSig]
        HRESULT SetSphericalVideoProperties(/* [annotation][in] _In_ */ float X, /* [annotation][in] _In_ */ float Y, /* [annotation][in] _In_ */ float Z, /* [annotation][in] _In_ */ float W, /* [annotation][in] _In_ */ float fieldOfView);
        
        [PreserveSig]
        HRESULT SetOutputDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pOutputDevice);
    }
}
