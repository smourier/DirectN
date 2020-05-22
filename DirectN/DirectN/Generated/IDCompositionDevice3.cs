// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1570,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0987cb06-f916-48bf-8d35-ce7641781bd9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionDevice3 : IDCompositionDevice2
    {
        // IDCompositionDevice2
        [PreserveSig]
        new HRESULT Commit();
        
        [PreserveSig]
        new HRESULT WaitForCommitCompletion();
        
        [PreserveSig]
        new HRESULT GetFrameStatistics(/* THIS_ _Out_ */ out DCOMPOSITION_FRAME_STATISTICS statistics);
        
        [PreserveSig]
        new HRESULT CreateVisual(/* THIS_ _Outptr_ */ out IDCompositionVisual2 visual);
        
        [PreserveSig]
        new HRESULT CreateSurfaceFactory(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object renderingDevice, /* _Outptr_ */ out IDCompositionSurfaceFactory surfaceFactory);
        
        [PreserveSig]
        new HRESULT CreateSurface(/* THIS_ _In_ */ uint width, /* _In_ */ uint height, /* _In_ */ DXGI_FORMAT pixelFormat, /* _In_ */ DXGI_ALPHA_MODE alphaMode, /* _Outptr_ */ out IDCompositionSurface surface);
        
        [PreserveSig]
        new HRESULT CreateVirtualSurface(/* THIS_ _In_ */ uint initialWidth, /* _In_ */ uint initialHeight, /* _In_ */ DXGI_FORMAT pixelFormat, /* _In_ */ DXGI_ALPHA_MODE alphaMode, /* _Outptr_ */ out IDCompositionVirtualSurface virtualSurface);
        
        [PreserveSig]
        new HRESULT CreateTranslateTransform(/* THIS_ _Outptr_ */ out IDCompositionTranslateTransform translateTransform);
        
        [PreserveSig]
        new HRESULT CreateScaleTransform(/* THIS_ _Outptr_ */ out IDCompositionScaleTransform scaleTransform);
        
        [PreserveSig]
        new HRESULT CreateRotateTransform(/* THIS_ _Outptr_ */ out IDCompositionRotateTransform rotateTransform);
        
        [PreserveSig]
        new HRESULT CreateSkewTransform(/* THIS_ _Outptr_ */ out IDCompositionSkewTransform skewTransform);
        
        [PreserveSig]
        new HRESULT CreateMatrixTransform(/* THIS_ _Outptr_ */ out IDCompositionMatrixTransform matrixTransform);
        
        [PreserveSig]
        new HRESULT CreateTransformGroup(/* THIS_ _In_reads_(elements) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IDCompositionTransform[] transforms, int elements, /* _Outptr_ */ out IDCompositionTransform transformGroup);
        
        [PreserveSig]
        new HRESULT CreateTranslateTransform3D(/* THIS_ _Outptr_ */ out IDCompositionTranslateTransform3D translateTransform3D);
        
        [PreserveSig]
        new HRESULT CreateScaleTransform3D(/* THIS_ _Outptr_ */ out IDCompositionScaleTransform3D scaleTransform3D);
        
        [PreserveSig]
        new HRESULT CreateRotateTransform3D(/* THIS_ _Outptr_ */ out IDCompositionRotateTransform3D rotateTransform3D);
        
        [PreserveSig]
        new HRESULT CreateMatrixTransform3D(/* THIS_ _Outptr_ */ out IDCompositionMatrixTransform3D matrixTransform3D);
        
        [PreserveSig]
        new HRESULT CreateTransform3DGroup(/* THIS_ _In_reads_(elements) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IDCompositionTransform3D[] transforms3D, int elements, /* _Outptr_ */ out IDCompositionTransform3D transform3DGroup);
        
        [PreserveSig]
        new HRESULT CreateEffectGroup(/* THIS_ _Outptr_ */ out IDCompositionEffectGroup effectGroup);
        
        [PreserveSig]
        new HRESULT CreateRectangleClip(/* THIS_ _Outptr_ */ out IDCompositionRectangleClip clip);
        
        [PreserveSig]
        new HRESULT CreateAnimation(/* THIS_ _Outptr_ */ out IDCompositionAnimation animation);
        
        // IDCompositionDevice3
        [PreserveSig]
        HRESULT CreateGaussianBlurEffect(/* THIS_ _Outptr_ */ out IDCompositionGaussianBlurEffect gaussianBlurEffect);
        
        [PreserveSig]
        HRESULT CreateBrightnessEffect(/* THIS_ _Outptr_ */ out IDCompositionBrightnessEffect brightnessEffect);
        
        [PreserveSig]
        HRESULT CreateColorMatrixEffect(/* THIS_ _Outptr_ */ out IDCompositionColorMatrixEffect colorMatrixEffect);
        
        [PreserveSig]
        HRESULT CreateShadowEffect(/* THIS_ _Outptr_ */ out IDCompositionShadowEffect shadowEffect);
        
        [PreserveSig]
        HRESULT CreateHueRotationEffect(/* THIS_ _Outptr_ */ out IDCompositionHueRotationEffect hueRotationEffect);
        
        [PreserveSig]
        HRESULT CreateSaturationEffect(/* THIS_ _Outptr_ */ out IDCompositionSaturationEffect saturationEffect);
        
        [PreserveSig]
        HRESULT CreateTurbulenceEffect(/* THIS_ _Outptr_ */ out IDCompositionTurbulenceEffect turbulenceEffect);
        
        [PreserveSig]
        HRESULT CreateLinearTransferEffect(/* THIS_ _Outptr_ */ out IDCompositionLinearTransferEffect linearTransferEffect);
        
        [PreserveSig]
        HRESULT CreateTableTransferEffect(/* THIS_ _Outptr_ */ out IDCompositionTableTransferEffect tableTransferEffect);
        
        [PreserveSig]
        HRESULT CreateCompositeEffect(/* THIS_ _Outptr_ */ out IDCompositionCompositeEffect compositeEffect);
        
        [PreserveSig]
        HRESULT CreateBlendEffect(/* THIS_ _Outptr_ */ out IDCompositionBlendEffect blendEffect);
        
        [PreserveSig]
        HRESULT CreateArithmeticCompositeEffect(/* THIS_ _Outptr_ */ out IDCompositionArithmeticCompositeEffect arithmeticCompositeEffect);
        
        [PreserveSig]
        HRESULT CreateAffineTransform2DEffect(/* THIS_ _Outptr_ */ out IDCompositionAffineTransform2DEffect affineTransform2dEffect);
    }
}
