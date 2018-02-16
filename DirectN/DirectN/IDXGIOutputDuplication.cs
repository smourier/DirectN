using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("191cfac3-a341-470d-b26e-a864f428319c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutputDuplication : IDXGIObject
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIOutputDuplication
        [PreserveSig]
        void GetDesc(out DXGI_OUTDUPL_DESC pDesc);

        [PreserveSig]
        HRESULT AcquireNextFrame(int TimeoutInMilliseconds, out DXGI_OUTDUPL_FRAME_INFO pFrameInfo, out IDXGIResource ppDesktopResource);

        [PreserveSig]
        HRESULT GetFrameDirtyRects(int DirtyRectsBufferSize, IntPtr pDirtyRectsBuffer, out int pDirtyRectsBufferSizeRequired);

        [PreserveSig]
        HRESULT GetFrameMoveRects(int MoveRectsBufferSize, IntPtr pMoveRectBuffer, out int pMoveRectsBufferSizeRequired);

        [PreserveSig]
        HRESULT GetFramePointerShape(int PointerShapeBufferSize, IntPtr pPointerShapeBuffer, out int pPointerShapeBufferSizeRequired, out DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo);

        [PreserveSig]
        HRESULT MapDesktopSurface(out DXGI_MAPPED_RECT pLockedRect);

        [PreserveSig]
        HRESULT UnMapDesktopSurface();

        [PreserveSig]
        HRESULT ReleaseFrame();
    }
}
