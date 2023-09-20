// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3d4c0c61-18a4-41e4-bd80-481a4fc9f464"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICDdsFrameDecode
    {
        [PreserveSig]
        HRESULT GetSizeInBlocks(/* [out] __RPC__out */ out uint pWidthInBlocks, /* [out] __RPC__out */ out uint pHeightInBlocks);
        
        [PreserveSig]
        HRESULT GetFormatInfo(/* [out] __RPC__out */ out WICDdsFormatInfo pFormatInfo);
        
        [PreserveSig]
        HRESULT CopyBlocks(/* optional(WICRect) */ IntPtr prcBoundsInBlocks, /* [in] */ uint cbStride, /* [in] */ int cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbBuffer);
    }
}
