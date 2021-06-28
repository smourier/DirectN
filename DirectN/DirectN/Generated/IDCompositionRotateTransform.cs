// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(587,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("641ed83c-ae96-46c5-90dc-32774cc5c6d5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionRotateTransform : IDCompositionTransform
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTransform
        
        // IDCompositionRotateTransform
        [PreserveSig]
        HRESULT SetAngle(float angle);
        
        [PreserveSig]
        HRESULT SetAngle(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterX(float centerX);
        
        [PreserveSig]
        HRESULT SetCenterX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterY(float centerY);
        
        [PreserveSig]
        HRESULT SetCenterY(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
