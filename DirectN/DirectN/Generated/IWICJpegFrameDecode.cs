// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8939f66e-c46a-4c21-a9d1-98b327ce1679"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICJpegFrameDecode
    {
        [PreserveSig]
        HRESULT DoesSupportIndexing(/* [out] __RPC__out */ out bool pfIndexingSupported);
        
        [PreserveSig]
        HRESULT SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize);
        
        [PreserveSig]
        HRESULT ClearIndexing();
        
        [PreserveSig]
        HRESULT GetAcHuffmanTable(uint scanIndex, /* [range] __RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) */ uint tableIndex, /* [out] __RPC__out */ out DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);
        
        [PreserveSig]
        HRESULT GetDcHuffmanTable(uint scanIndex, /* [range] __RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) */ uint tableIndex, /* [out] __RPC__out */ out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);
        
        [PreserveSig]
        HRESULT GetQuantizationTable(uint scanIndex, /* [range] __RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) */ uint tableIndex, /* [out] __RPC__out */ out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);
        
        [PreserveSig]
        HRESULT GetFrameHeader(/* [out] __RPC__out */ out WICJpegFrameHeader pFrameHeader);
        
        [PreserveSig]
        HRESULT GetScanHeader(uint scanIndex, /* [out] __RPC__out */ out WICJpegScanHeader pScanHeader);
        
        [PreserveSig]
        HRESULT CopyScan(uint scanIndex, uint scanOffset, /* [in] */ int cbScanData, /* [length_is][size_is][out] __RPC__out_ecount_part(cbScanData, *pcbScanDataActual) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbScanData, /* [out] __RPC__out */ out uint pcbScanDataActual);
        
        [PreserveSig]
        HRESULT CopyMinimalStream(uint streamOffset, /* [in] */ int cbStreamData, /* [length_is][size_is][out] __RPC__out_ecount_part(cbStreamData, *pcbStreamDataActual) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbStreamData, /* [out] __RPC__out */ out uint pcbStreamDataActual);
    }
}
