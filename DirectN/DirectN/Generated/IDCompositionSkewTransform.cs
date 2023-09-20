// generated from <Windows SDK Path>\um\dcomp.h
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
        HRESULT SetAngleX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAngleX(float angleX);
        
        [PreserveSig]
        HRESULT SetAngleY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAngleY(float angleY);
        
        [PreserveSig]
        HRESULT SetCenterX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterX(float centerX);
        
        [PreserveSig]
        HRESULT SetCenterY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterY(float centerY);
    }
}
