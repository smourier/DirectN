using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8939F66E-C46A-4c21-A9D1-98B327CE1679"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICJpegFrameDecode
    {
        [PreserveSig]
        HRESULT DoesSupportIndexing(out bool pfIndexingSupported);

        [PreserveSig]
        HRESULT SetIndexing(WICJpegIndexingOptions options, int horizontalIntervalSize);

        [PreserveSig]
        HRESULT ClearIndexing();

        [PreserveSig]
        HRESULT GetAcHuffmanTable(int scanIndex, int tableIndex, ref DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);

        [PreserveSig]
        HRESULT GetDcHuffmanTable(int scanIndex, int tableIndex, ref DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);

        [PreserveSig]
        HRESULT GetQuantizationTable(int scanIndex, int tableIndex, ref DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);

        [PreserveSig]
        HRESULT GetFrameHeader(out WICJpegFrameHeader pFrameHeader);

        [PreserveSig]
        HRESULT GetScanHeader(int scanIndex, out WICJpegScanHeader pScanHeader);

        [PreserveSig]
        HRESULT CopyScan(int scanIndex, int scanOffset, int cbScanData, IntPtr pbScanData, out int pcbScanDataActual);

        [PreserveSig]
        HRESULT CopyMinimalStream(int streamOffset, int cbStreamData, IntPtr pbStreamData, out int pcbStreamDataActual);
    }
}
