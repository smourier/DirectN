using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICJpegFrameEncode
    {
        [PreserveSig]
        HRESULT GetAcHuffmanTable(int scanIndex, int tableIndex, ref DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);

        [PreserveSig]
        HRESULT GetDcHuffmanTable(int scanIndex, int tableIndex, out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);

        [PreserveSig]
        HRESULT GetQuantizationTable(int scanIndex, int tableIndex, out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);

        [PreserveSig]
        HRESULT WriteScan(int cbScanData, IntPtr pbScanData);
    }
}
