// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("91636d4b-9ba1-4532-aaf7-e3344994d788"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTranslateTransform3D : IDCompositionTransform3D
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTranslateTransform3D
        [PreserveSig]
        HRESULT SetOffsetX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetX(float offsetX);
        
        [PreserveSig]
        HRESULT SetOffsetY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetY(float offsetY);
        
        [PreserveSig]
        HRESULT SetOffsetZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetZ(float offsetZ);
    }
}
