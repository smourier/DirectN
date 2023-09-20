// generated from <Windows SDK Path>\um\dcomp.h
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
        HRESULT SetAngle(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAngle(float angle);
        
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
