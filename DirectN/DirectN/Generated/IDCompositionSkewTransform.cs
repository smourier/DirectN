// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(633,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e57aa735-dcdb-4c72-9c61-0591f58889ee"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionSkewTransform : IDCompositionTransform
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTransform
        
        // IDCompositionSkewTransform
        [PreserveSig]
        HRESULT SetAngleX(float angleX);
        
        [PreserveSig]
        HRESULT SetAngleX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAngleY(float angleY);
        
        [PreserveSig]
        HRESULT SetAngleY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
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
