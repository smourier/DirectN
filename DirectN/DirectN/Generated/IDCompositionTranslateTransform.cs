// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("06791122-c6f0-417d-8323-269e987f5954"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTranslateTransform : IDCompositionTransform
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTransform
        
        // IDCompositionTranslateTransform
        [PreserveSig]
        HRESULT SetOffsetX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetX(float offsetX);
        
        [PreserveSig]
        HRESULT SetOffsetY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetY(float offsetY);
    }
}
