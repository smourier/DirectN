// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(799,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2a9e9ead-364b-4b15-a7c4-a1997f78b389"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionScaleTransform3D : IDCompositionTransform3D
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionScaleTransform3D
        [PreserveSig]
        HRESULT SetScaleX(float scaleX);
        
        [PreserveSig]
        HRESULT SetScaleX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetScaleY(float scaleY);
        
        [PreserveSig]
        HRESULT SetScaleY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetScaleZ(float scaleZ);
        
        [PreserveSig]
        HRESULT SetScaleZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterX(float centerX);
        
        [PreserveSig]
        HRESULT SetCenterX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterY(float centerY);
        
        [PreserveSig]
        HRESULT SetCenterY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterZ(float centerZ);
        
        [PreserveSig]
        HRESULT SetCenterZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
