using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICImagingFactory
    {
        [PreserveSig]
        HRESULT CreateDecoderFromFilename([MarshalAs(UnmanagedType.LPWStr)] string wzFilename, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, WICAccessRights dwDesiredAccess, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        HRESULT CreateDecoderFromStream(IStream pIStream, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        HRESULT CreateDecoderFromFileHandle(IntPtr hFile, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        HRESULT CreateComponentInfo([MarshalAs(UnmanagedType.LPStruct)] Guid clsidComponent, out IWICComponentInfo ppIInfo);

        [PreserveSig]
        HRESULT CreateDecoder([MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        HRESULT CreateEncoder([MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] Guid[] pguidVendor, out IWICBitmapEncoder ppIEncoder);

        [PreserveSig]
        HRESULT CreatePalette(out IWICPalette ppIPalette);

        [PreserveSig]
        HRESULT CreateFormatConverter(out IWICFormatConverter ppIFormatConverter);

        [PreserveSig]
        HRESULT CreateBitmapScaler(out IWICBitmapScaler ppIBitmapScaler);

        [PreserveSig]
        HRESULT CreateBitmapClipper(out IWICBitmapClipper ppIBitmapClipper);

        [PreserveSig]
        HRESULT CreateBitmapFlipRotator(out IWICBitmapFlipRotator ppIBitmapFlipRotator);

        [PreserveSig]
        HRESULT CreateStream(out IWICStream ppIWICStream);

        [PreserveSig]
        HRESULT CreateColorContext(out IWICColorContext ppIWICColorContext);

        [PreserveSig]
        HRESULT CreateColorTransformer(out IWICColorTransform ppIWICColorTransform);

        [PreserveSig]
        HRESULT CreateBitmap(int uiWidth, int uiHeight, [MarshalAs(UnmanagedType.LPStruct)] Guid pixelFormat, WICBitmapCreateCacheOption option, out IWICBitmap ppIBitmap);

        [PreserveSig]
        HRESULT CreateBitmapFromSource(IWICBitmapSource pIBitmapSource, WICBitmapCreateCacheOption option, out IWICBitmap ppIBitmap);

        [PreserveSig]
        HRESULT CreateBitmapFromSourceRect(
            IWICBitmapSource pIBitmapSource,
            int x,
            int y,
            int width,
            int height,
            out IWICBitmap ppIBitmap);

        [PreserveSig]
        HRESULT CreateBitmapFromMemory(
            int uiWidth,
            int uiHeight,
            [MarshalAs(UnmanagedType.LPStruct)] Guid pixelFormat,
            int cbStride,
            int cbBufferSize,
            IntPtr pbBuffer,
            out IWICBitmap ppIBitmap);

        [PreserveSig]
        HRESULT CreateBitmapFromHBITMAP(IntPtr hBitmap, IntPtr hPalette, WICBitmapAlphaChannelOption options, out IWICBitmap ppIBitmap);

        [PreserveSig]
        HRESULT CreateBitmapFromHICON(IntPtr hIcon, out IWICBitmap ppIBitmap);

        [PreserveSig]
        HRESULT CreateComponentEnumerator(WICComponentType componentTypes, WICComponentEnumerateOptions options, out IEnumUnknown ppIEnumUnknown);

        [PreserveSig]
        HRESULT CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder pIDecoder, out IWICFastMetadataEncoder ppIFastEncoder);

        [PreserveSig]
        HRESULT CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode pIFrameDecoder, out IWICFastMetadataEncoder ppIFastEncoder);

        [PreserveSig]
        HRESULT CreateQueryWriter([MarshalAs(UnmanagedType.LPStruct)] Guid guidMetadataFormat, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, out IWICMetadataQueryWriter ppIQueryWriter);

        [PreserveSig]
        HRESULT CreateQueryWriterFromReader(IWICMetadataQueryReader pIQueryReader, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, out IWICMetadataQueryWriter ppIQueryWriter);
    }
}
