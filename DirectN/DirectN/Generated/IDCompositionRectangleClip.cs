// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(1013,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9842ad7d-d9cf-4908-aed7-48b51da5e7c2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionRectangleClip : IDCompositionClip
    {
        // IDCompositionClip
        
        // IDCompositionRectangleClip
        [PreserveSig]
        HRESULT SetLeft(float left);
        
        [PreserveSig]
        HRESULT SetLeft(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTop(float top);
        
        [PreserveSig]
        HRESULT SetTop(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetRight(float right);
        
        [PreserveSig]
        HRESULT SetRight(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBottom(float bottom);
        
        [PreserveSig]
        HRESULT SetBottom(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTopLeftRadiusX(float radius);
        
        [PreserveSig]
        HRESULT SetTopLeftRadiusX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTopLeftRadiusY(float radius);
        
        [PreserveSig]
        HRESULT SetTopLeftRadiusY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTopRightRadiusX(float radius);
        
        [PreserveSig]
        HRESULT SetTopRightRadiusX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTopRightRadiusY(float radius);
        
        [PreserveSig]
        HRESULT SetTopRightRadiusY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBottomLeftRadiusX(float radius);
        
        [PreserveSig]
        HRESULT SetBottomLeftRadiusX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBottomLeftRadiusY(float radius);
        
        [PreserveSig]
        HRESULT SetBottomLeftRadiusY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBottomRightRadiusX(float radius);
        
        [PreserveSig]
        HRESULT SetBottomRightRadiusX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBottomRightRadiusY(float radius);
        
        [PreserveSig]
        HRESULT SetBottomRightRadiusY(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
