// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(753,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("91636d4b-9ba1-4532-aaf7-e3344994d788"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTranslateTransform3D : IDCompositionTransform3D
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTranslateTransform3D
        [PreserveSig]
        HRESULT SetOffsetX(float offsetX);
        
        [PreserveSig]
        HRESULT SetOffsetX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetY(float offsetY);
        
        [PreserveSig]
        HRESULT SetOffsetY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetZ(float offsetZ);
        
        [PreserveSig]
        HRESULT SetOffsetZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
