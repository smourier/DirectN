// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c37ea93a-e7aa-450d-b16f-9746cb0407f3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionDevice
    {
        [PreserveSig]
        HRESULT Commit();
        
        [PreserveSig]
        HRESULT WaitForCommitCompletion();
        
        [PreserveSig]
        HRESULT GetFrameStatistics(/* THIS_ _Out_ */ out DCOMPOSITION_FRAME_STATISTICS statistics);
        
        [PreserveSig]
        HRESULT CreateTargetForHwnd(/* THIS_ _In_ */ IntPtr hwnd, bool topmost, /* _Outptr_ */ out IDCompositionTarget target);
        
        [PreserveSig]
        HRESULT CreateVisual(/* THIS_ _Outptr_ */ out IDCompositionVisual visual);
        
        [PreserveSig]
        HRESULT CreateSurface(/* THIS_ _In_ */ uint width, /* _In_ */ uint height, /* _In_ */ DXGI_FORMAT pixelFormat, /* _In_ */ DXGI_ALPHA_MODE alphaMode, /* _Outptr_ */ out IDCompositionSurface surface);
        
        [PreserveSig]
        HRESULT CreateVirtualSurface(/* THIS_ _In_ */ uint initialWidth, /* _In_ */ uint initialHeight, /* _In_ */ DXGI_FORMAT pixelFormat, /* _In_ */ DXGI_ALPHA_MODE alphaMode, /* _Outptr_ */ out IDCompositionVirtualSurface virtualSurface);
        
        [PreserveSig]
        HRESULT CreateSurfaceFromHandle(/* THIS_ _In_ */ IntPtr handle, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object surface);
        
        [PreserveSig]
        HRESULT CreateSurfaceFromHwnd(/* THIS_ _In_ */ IntPtr hwnd, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object surface);
        
        [PreserveSig]
        HRESULT CreateTranslateTransform(/* THIS_ _Outptr_ */ out IDCompositionTranslateTransform translateTransform);
        
        [PreserveSig]
        HRESULT CreateScaleTransform(/* THIS_ _Outptr_ */ out IDCompositionScaleTransform scaleTransform);
        
        [PreserveSig]
        HRESULT CreateRotateTransform(/* THIS_ _Outptr_ */ out IDCompositionRotateTransform rotateTransform);
        
        [PreserveSig]
        HRESULT CreateSkewTransform(/* THIS_ _Outptr_ */ out IDCompositionSkewTransform skewTransform);
        
        [PreserveSig]
        HRESULT CreateMatrixTransform(/* THIS_ _Outptr_ */ out IDCompositionMatrixTransform matrixTransform);
        
        [PreserveSig]
        HRESULT CreateTransformGroup(/* THIS_ _In_reads_(elements) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IDCompositionTransform[] transforms, int elements, /* _Outptr_ */ out IDCompositionTransform transformGroup);
        
        [PreserveSig]
        HRESULT CreateTranslateTransform3D(/* THIS_ _Outptr_ */ out IDCompositionTranslateTransform3D translateTransform3D);
        
        [PreserveSig]
        HRESULT CreateScaleTransform3D(/* THIS_ _Outptr_ */ out IDCompositionScaleTransform3D scaleTransform3D);
        
        [PreserveSig]
        HRESULT CreateRotateTransform3D(/* THIS_ _Outptr_ */ out IDCompositionRotateTransform3D rotateTransform3D);
        
        [PreserveSig]
        HRESULT CreateMatrixTransform3D(/* THIS_ _Outptr_ */ out IDCompositionMatrixTransform3D matrixTransform3D);
        
        [PreserveSig]
        HRESULT CreateTransform3DGroup(/* THIS_ _In_reads_(elements) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IDCompositionTransform3D[] transforms3D, int elements, /* _Outptr_ */ out IDCompositionTransform3D transform3DGroup);
        
        [PreserveSig]
        HRESULT CreateEffectGroup(/* THIS_ _Outptr_ */ out IDCompositionEffectGroup effectGroup);
        
        [PreserveSig]
        HRESULT CreateRectangleClip(/* THIS_ _Outptr_ */ out IDCompositionRectangleClip clip);
        
        [PreserveSig]
        HRESULT CreateAnimation(/* THIS_ _Outptr_ */ out IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT CheckDeviceState(/* THIS_ _Out_ */ out bool pfValid);
    }
}
