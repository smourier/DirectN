// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2a9e9ead-364b-4b15-a7c4-a1997f78b389"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionScaleTransform3D : IDCompositionTransform3D
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionScaleTransform3D
        [PreserveSig]
        HRESULT SetScaleX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetScaleX(float scaleX);
        
        [PreserveSig]
        HRESULT SetScaleY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetScaleY(float scaleY);
        
        [PreserveSig]
        HRESULT SetScaleZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetScaleZ(float scaleZ);
        
        [PreserveSig]
        HRESULT SetCenterX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterX(float centerX);
        
        [PreserveSig]
        HRESULT SetCenterY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterY(float centerY);
        
        [PreserveSig]
        HRESULT SetCenterZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterZ(float centerZ);
    }
}
