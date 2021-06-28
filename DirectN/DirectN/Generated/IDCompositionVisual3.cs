// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1515,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2775f462-b6c1-4015-b0be-b3e7d6a4976d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionVisual3 : IDCompositionVisualDebug
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
        new HRESULT SetOpacityMode(/* THIS_ _In_ */ DCOMPOSITION_OPACITY_MODE mode);
        
        [PreserveSig]
        new HRESULT SetBackFaceVisibility(/* THIS_ _In_ */ DCOMPOSITION_BACKFACE_VISIBILITY visibility);
        
        // IDCompositionVisualDebug
        [PreserveSig]
        new HRESULT EnableHeatMap(/* THIS_ _In_ */ ref _D3DCOLORVALUE color);
        
        [PreserveSig]
        new HRESULT DisableHeatMap();
        
        [PreserveSig]
        new HRESULT EnableRedrawRegions();
        
        [PreserveSig]
        new HRESULT DisableRedrawRegions();
        
        // IDCompositionVisual3
        [PreserveSig]
        HRESULT SetDepthMode(/* THIS_ _In_ */ DCOMPOSITION_DEPTH_MODE mode);
        
        [PreserveSig]
        HRESULT SetOffsetZ(float offsetZ);
        
        [PreserveSig]
        HRESULT SetOffsetZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOpacity(float opacity);
        
        [PreserveSig]
        HRESULT SetOpacity(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTransform(ref D2D_MATRIX_4X4_F matrix);
        
        [PreserveSig]
        HRESULT SetTransform(/* THIS_ _In_opt_ */ IDCompositionTransform3D transform);
        
        [PreserveSig]
        HRESULT SetVisible(bool visible);
    }
}
