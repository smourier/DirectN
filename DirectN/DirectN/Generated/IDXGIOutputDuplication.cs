// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_2.h(279,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("191cfac3-a341-470d-b26e-a864f428319c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIOutputDuplication : IDXGIObject
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [in] */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* optional(IUnknown) */ IntPtr pUnknown);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][out][in] _Inout_ */ ref uint pDataSize, /* [annotation][out] _Out_writes_bytes_(*pDataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT GetParent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);
        
        // IDXGIOutputDuplication
        [PreserveSig]
        void GetDesc(/* [annotation][out] _Out_ */ out DXGI_OUTDUPL_DESC pDesc);
        
        [PreserveSig]
        HRESULT AcquireNextFrame(/* [annotation][in] _In_ */ uint TimeoutInMilliseconds, /* [annotation][out] _Out_ */ out DXGI_OUTDUPL_FRAME_INFO pFrameInfo, /* [annotation][out] _COM_Outptr_ */ out IDXGIResource ppDesktopResource);
        
        [PreserveSig]
        HRESULT GetFrameDirtyRects(/* [annotation][in] _In_ */ uint DirtyRectsBufferSize, /* [annotation][out] _Out_writes_bytes_to_(DirtyRectsBufferSize, *pDirtyRectsBufferSizeRequired) */ out IntPtr pDirtyRectsBuffer, /* [annotation][out] _Out_ */ out uint pDirtyRectsBufferSizeRequired);
        
        [PreserveSig]
        HRESULT GetFrameMoveRects(/* [annotation][in] _In_ */ uint MoveRectsBufferSize, /* [annotation][out] _Out_writes_bytes_to_(MoveRectsBufferSize, *pMoveRectsBufferSizeRequired) */ out IntPtr pMoveRectBuffer, /* [annotation][out] _Out_ */ out uint pMoveRectsBufferSizeRequired);
        
        [PreserveSig]
        HRESULT GetFramePointerShape(/* [annotation][in] _In_ */ uint PointerShapeBufferSize, /* [annotation][out] _Out_writes_bytes_to_(PointerShapeBufferSize, *pPointerShapeBufferSizeRequired) */ IntPtr pPointerShapeBuffer, /* [annotation][out] _Out_ */ out uint pPointerShapeBufferSizeRequired, /* [annotation][out] _Out_ */ out DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo);
        
        [PreserveSig]
        HRESULT MapDesktopSurface(/* [annotation][out] _Out_ */ out DXGI_MAPPED_RECT pLockedRect);
        
        [PreserveSig]
        HRESULT UnMapDesktopSurface();
        
        [PreserveSig]
        HRESULT ReleaseFrame();
    }
}
