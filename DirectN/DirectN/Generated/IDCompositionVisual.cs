// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(346,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4d93059d-097b-4651-9a60-f0f25116e2f3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionVisual
    {
        [PreserveSig]
        HRESULT SetOffsetX(float offsetX);
        
        [PreserveSig]
        HRESULT SetOffsetX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetY(float offsetY);
        
        [PreserveSig]
        HRESULT SetOffsetY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTransform(ref D2D_MATRIX_3X2_F matrix);
        
        [PreserveSig]
        HRESULT SetTransform(/* THIS_ _In_opt_ */ IDCompositionTransform transform);
        
        [PreserveSig]
        HRESULT SetTransformParent(/* THIS_ _In_opt_ */ IDCompositionVisual visual);
        
        [PreserveSig]
        HRESULT SetEffect(/* THIS_ _In_opt_ */ IDCompositionEffect effect);
        
        [PreserveSig]
        HRESULT SetBitmapInterpolationMode(/* THIS_ _In_ */ DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        HRESULT SetBorderMode(/* THIS_ _In_ */ DCOMPOSITION_BORDER_MODE borderMode);
        
        [PreserveSig]
        HRESULT SetClip(ref D2D_RECT_F rect);
        
        [PreserveSig]
        HRESULT SetClip(/* THIS_ _In_opt_ */ IDCompositionClip clip);
        
        [PreserveSig]
        HRESULT SetContent(/* THIS_ _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object content);
        
        [PreserveSig]
        HRESULT AddVisual(/* THIS_ _In_ */ IDCompositionVisual visual, bool insertAbove, /* _In_opt_ */ IDCompositionVisual referenceVisual);
        
        [PreserveSig]
        HRESULT RemoveVisual(/* THIS_ _In_ */ IDCompositionVisual visual);
        
        [PreserveSig]
        HRESULT RemoveAllVisuals();
        
        [PreserveSig]
        HRESULT SetCompositeMode(/* THIS_ _In_ */ DCOMPOSITION_COMPOSITE_MODE compositeMode);
    }
}
