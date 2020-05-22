// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1453,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e8de1639-4331-4b26-bc5f-6a321d347a85"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionVisual2 : IDCompositionVisual
    {
        // IDCompositionVisual
        [PreserveSig]
        new HRESULT SetOffsetX(float offsetX);
        
        [PreserveSig]
        new HRESULT SetOffsetX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        new HRESULT SetOffsetY(float offsetY);
        
        [PreserveSig]
        new HRESULT SetOffsetY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        new HRESULT SetTransform(ref D2D_MATRIX_3X2_F matrix);
        
        [PreserveSig]
        new HRESULT SetTransform(/* THIS_ _In_opt_ */ IDCompositionTransform transform);
        
        [PreserveSig]
        new HRESULT SetTransformParent(/* THIS_ _In_opt_ */ IDCompositionVisual visual);
        
        [PreserveSig]
        new HRESULT SetEffect(/* THIS_ _In_opt_ */ IDCompositionEffect effect);
        
        [PreserveSig]
        new HRESULT SetBitmapInterpolationMode(/* THIS_ _In_ */ DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        new HRESULT SetBorderMode(/* THIS_ _In_ */ DCOMPOSITION_BORDER_MODE borderMode);
        
        [PreserveSig]
        new HRESULT SetClip(ref D2D_RECT_F rect);
        
        [PreserveSig]
        new HRESULT SetClip(/* THIS_ _In_opt_ */ IDCompositionClip clip);
        
        [PreserveSig]
        new HRESULT SetContent(/* THIS_ _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object content);
        
        [PreserveSig]
        new HRESULT AddVisual(/* THIS_ _In_ */ IDCompositionVisual visual, bool insertAbove, /* _In_opt_ */ IDCompositionVisual referenceVisual);
        
        [PreserveSig]
        new HRESULT RemoveVisual(/* THIS_ _In_ */ IDCompositionVisual visual);
        
        [PreserveSig]
        new HRESULT RemoveAllVisuals();
        
        [PreserveSig]
        new HRESULT SetCompositeMode(/* THIS_ _In_ */ DCOMPOSITION_COMPOSITE_MODE compositeMode);
        
        // IDCompositionVisual2
        [PreserveSig]
        HRESULT SetOpacityMode(/* THIS_ _In_ */ DCOMPOSITION_OPACITY_MODE mode);
        
        [PreserveSig]
        HRESULT SetBackFaceVisibility(/* THIS_ _In_ */ DCOMPOSITION_BACKFACE_VISIBILITY visibility);
    }
}
