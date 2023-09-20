// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2f0c601f-d2c6-468c-abfa-49495d983ed1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICJpegFrameEncode
    {
        [PreserveSig]
        HRESULT GetAcHuffmanTable(uint scanIndex, /* [range] __RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) */ uint tableIndex, /* [out] __RPC__out */ out DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);
        
        [PreserveSig]
        HRESULT GetDcHuffmanTable(uint scanIndex, /* [range] __RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) */ uint tableIndex, /* [out] __RPC__out */ out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);
        
        [PreserveSig]
        HRESULT GetQuantizationTable(uint scanIndex, /* [range] __RPC__in_range(0,WIC_JPEG_MAX_TABLE_INDEX) */ uint tableIndex, /* [out] __RPC__out */ out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);
        
        [PreserveSig]
        HRESULT WriteScan(/* [in] */ int cbScanData, /* [size_is][in] __RPC__in_ecount_full(cbScanData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbScanData);
    }
}
