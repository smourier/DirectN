using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("7B816B45-1996-4476-B132-DE9E247C8AF0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICImagingFactory2 : IWICImagingFactory
    {
        // IWICImagingFactory
        [PreserveSig]
        new HRESULT CreateDecoderFromFilename([MarshalAs(UnmanagedType.LPWStr)] string wzFilename, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, WICAccessRights dwDesiredAccess, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        new HRESULT CreateDecoderFromStream(IStream pIStream, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        new HRESULT CreateDecoderFromFileHandle(IntPtr hFile, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        new HRESULT CreateComponentInfo([MarshalAs(UnmanagedType.LPStruct)] Guid clsidComponent, out IWICComponentInfo ppIInfo);

        [PreserveSig]
        new HRESULT CreateDecoder([MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        new HRESULT CreateEncoder([MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] Guid[] pguidVendor, out IWICBitmapEncoder ppIEncoder);

        [PreserveSig]
        new HRESULT CreatePalette(out IWICPalette ppIPalette);

        [PreserveSig]
        new HRESULT CreateFormatConverter(out IWICFormatConverter ppIFormatConverter);

        [PreserveSig]
        new HRESULT CreateBitmapScaler(out IWICBitmapScaler ppIBitmapScaler);

        [PreserveSig]
        new HRESULT CreateBitmapClipper(out IWICBitmapClipper ppIBitmapClipper);

        [PreserveSig]
        new HRESULT CreateBitmapFlipRotator(out IWICBitmapFlipRotator ppIBitmapFlipRotator);

        [PreserveSig]
        new HRESULT CreateStream(out IWICStream ppIWICStream);

        [PreserveSig]
        new HRESULT CreateColorContext(out IWICColorContext ppIWICColorContext);

        [PreserveSig]
        new HRESULT CreateColorTransformer(out IWICColorTransform ppIWICColorTransform);

        [PreserveSig]
        new HRESULT CreateBitmap(int uiWidth, int uiHeight, [MarshalAs(UnmanagedType.LPStruct)] Guid pixelFormat, WICBitmapCreateCacheOption option, out IWICBitmap ppIBitmap);

        [PreserveSig]
        new HRESULT CreateBitmapFromSource(IWICBitmapSource pIBitmapSource, WICBitmapCreateCacheOption option, out IWICBitmap ppIBitmap);

        [PreserveSig]
        new HRESULT CreateBitmapFromSourceRect(
            IWICBitmapSource pIBitmapSource,
            int x,
            int y,
            int width,
            int height,
            out IWICBitmap ppIBitmap);

        [PreserveSig]
        new HRESULT CreateBitmapFromMemory(
            int uiWidth,
            int uiHeight,
            [MarshalAs(UnmanagedType.LPStruct)] Guid pixelFormat,
            int cbStride,
            int cbBufferSize,
            IntPtr pbBuffer,
            out IWICBitmap ppIBitmap);

        [PreserveSig]
        new HRESULT CreateBitmapFromHBITMAP(IntPtr hBitmap, IntPtr hPalette, WICBitmapAlphaChannelOption options, out IWICBitmap ppIBitmap);

        [PreserveSig]
        new HRESULT CreateBitmapFromHICON(IntPtr hIcon, out IWICBitmap ppIBitmap);

        [PreserveSig]
        new HRESULT CreateComponentEnumerator(WICComponentType componentTypes, WICComponentEnumerateOptions options, out IEnumUnknown ppIEnumUnknown);

        [PreserveSig]
        new HRESULT CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder pIDecoder, out IWICFastMetadataEncoder ppIFastEncoder);

        [PreserveSig]
        new HRESULT CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode pIFrameDecoder, out IWICFastMetadataEncoder ppIFastEncoder);

        [PreserveSig]
        new HRESULT CreateQueryWriter([MarshalAs(UnmanagedType.LPStruct)] Guid guidMetadataFormat, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, out IWICMetadataQueryWriter ppIQueryWriter);

        [PreserveSig]
        new HRESULT CreateQueryWriterFromReader(IWICMetadataQueryReader pIQueryReader, [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, out IWICMetadataQueryWriter ppIQueryWriter);

        // IWICImagingFactory2
        [PreserveSig]
        HRESULT CreateImageEncoder(ID2D1Device pD2DDevice, out IWICImageEncoder ppWICImageEncoder);
    }
}
