// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(3415,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bde633d3-e1dc-4a7f-a693-bbae399c4a20"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoProcessorControl2 : IMFVideoProcessorControl
    {
        // IMFVideoProcessorControl
        [PreserveSig]
        new HRESULT SetBorderColor(/* optional(_MFARGB) */ IntPtr pBorderColor);
        
        [PreserveSig]
        new HRESULT SetSourceRectangle(/* optional(tagRECT) */ IntPtr pSrcRect);
        
        [PreserveSig]
        new HRESULT SetDestinationRectangle(/* optional(tagRECT) */ IntPtr pDstRect);
        
        [PreserveSig]
        new HRESULT SetMirror(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_MIRROR eMirror);
        
        [PreserveSig]
        new HRESULT SetRotation(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_ROTATION eRotation);
        
        [PreserveSig]
        new HRESULT SetConstrictionSize(/* optional(tagSIZE) */ IntPtr pConstrictionSize);
        
        // IMFVideoProcessorControl2
        [PreserveSig]
        HRESULT SetRotationOverride(/* [annotation][in] _In_ */ uint uiRotation);
        
        [PreserveSig]
        HRESULT EnableHardwareEffects(/* [annotation][in] _In_ */ bool fEnabled);
        
        [PreserveSig]
        HRESULT GetSupportedHardwareEffects(/* [annotation][retval][out] _Out_ */ out uint puiSupport);
    }
}
