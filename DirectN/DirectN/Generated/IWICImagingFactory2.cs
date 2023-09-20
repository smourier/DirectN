// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using REFWICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("7b816b45-1996-4476-b132-de9e247c8af0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICImagingFactory2 : IWICImagingFactory
    {
        // IWICImagingFactory
        [PreserveSig]
        new HRESULT CreateDecoderFromFilename(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzFilename, /* optional(GUID) */ IntPtr pguidVendor, /* [in] */ uint dwDesiredAccess, /* [in] */ WICDecodeOptions metadataOptions, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        new HRESULT CreateDecoderFromStream(/* [in] __RPC__in_opt */ IStream pIStream, /* optional(GUID) */ IntPtr pguidVendor, /* [in] */ WICDecodeOptions metadataOptions, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        new HRESULT CreateDecoderFromFileHandle(/* [in] */ IntPtr hFile, /* optional(GUID) */ IntPtr pguidVendor, /* [in] */ WICDecodeOptions metadataOptions, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        new HRESULT CreateComponentInfo(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsidComponent, /* [out] __RPC__deref_out_opt */ out IWICComponentInfo ppIInfo);
        
        [PreserveSig]
        new HRESULT CreateDecoder(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* optional(GUID) */ IntPtr pguidVendor, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        new HRESULT CreateEncoder(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* optional(GUID) */ IntPtr pguidVendor, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapEncoder ppIEncoder);
        
        [PreserveSig]
        new HRESULT CreatePalette(/* [out] __RPC__deref_out_opt */ out IWICPalette ppIPalette);
        
        [PreserveSig]
        new HRESULT CreateFormatConverter(/* [out] __RPC__deref_out_opt */ out IWICFormatConverter ppIFormatConverter);
        
        [PreserveSig]
        new HRESULT CreateBitmapScaler(/* [out] __RPC__deref_out_opt */ out IWICBitmapScaler ppIBitmapScaler);
        
        [PreserveSig]
        new HRESULT CreateBitmapClipper(/* [out] __RPC__deref_out_opt */ out IWICBitmapClipper ppIBitmapClipper);
        
        [PreserveSig]
        new HRESULT CreateBitmapFlipRotator(/* [out] __RPC__deref_out_opt */ out IWICBitmapFlipRotator ppIBitmapFlipRotator);
        
        [PreserveSig]
        new HRESULT CreateStream(/* [out] __RPC__deref_out_opt */ out IWICStream ppIWICStream);
        
        [PreserveSig]
        new HRESULT CreateColorContext(/* [out] __RPC__deref_out_opt */ out IWICColorContext ppIWICColorContext);
        
        [PreserveSig]
        new HRESULT CreateColorTransformer(/* [out] __RPC__deref_out_opt */ out IWICColorTransform ppIWICColorTransform);
        
        [PreserveSig]
        new HRESULT CreateBitmap(/* [in] */ uint uiWidth, /* [in] */ uint uiHeight, /* [in] __RPC__in */ ref REFWICPixelFormatGUID pixelFormat, /* [in] */ WICBitmapCreateCacheOption option, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        new HRESULT CreateBitmapFromSource(/* [in] __RPC__in_opt */ IWICBitmapSource pIBitmapSource, /* [in] */ WICBitmapCreateCacheOption option, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        new HRESULT CreateBitmapFromSourceRect(/* [in] __RPC__in_opt */ IWICBitmapSource pIBitmapSource, /* [in] */ uint x, /* [in] */ uint y, /* [in] */ uint width, /* [in] */ uint height, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        new HRESULT CreateBitmapFromMemory(/* [in] */ uint uiWidth, /* [in] */ uint uiHeight, /* [in] __RPC__in */ ref REFWICPixelFormatGUID pixelFormat, /* [in] */ uint cbStride, /* [in] */ int cbBufferSize, /* [size_is][in] __RPC__in_ecount_full(cbBufferSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] pbBuffer, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        new HRESULT CreateBitmapFromHBITMAP(/* [in] __RPC__in */ IntPtr hBitmap, /* optional(HPALETTE__) */ IntPtr hPalette, /* [in] */ WICBitmapAlphaChannelOption options, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        new HRESULT CreateBitmapFromHICON(/* [in] __RPC__in */ IntPtr hIcon, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        new HRESULT CreateComponentEnumerator(/* [in] */ uint componentTypes, /* [in] */ uint options, /* [out] __RPC__deref_out_opt */ out IntPtr ppIEnumUnknown);
        
        [PreserveSig]
        new HRESULT CreateFastMetadataEncoderFromDecoder(/* [in] __RPC__in_opt */ IWICBitmapDecoder pIDecoder, /* [out] __RPC__deref_out_opt */ out IWICFastMetadataEncoder ppIFastEncoder);
        
        [PreserveSig]
        new HRESULT CreateFastMetadataEncoderFromFrameDecode(/* [in] __RPC__in_opt */ IWICBitmapFrameDecode pIFrameDecoder, /* [out] __RPC__deref_out_opt */ out IWICFastMetadataEncoder ppIFastEncoder);
        
        [PreserveSig]
        new HRESULT CreateQueryWriter(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMetadataFormat, /* optional(GUID) */ IntPtr pguidVendor, /* [out] __RPC__deref_out_opt */ out IWICMetadataQueryWriter ppIQueryWriter);
        
        [PreserveSig]
        new HRESULT CreateQueryWriterFromReader(/* [in] __RPC__in_opt */ IWICMetadataQueryReader pIQueryReader, /* optional(GUID) */ IntPtr pguidVendor, /* [out] __RPC__deref_out_opt */ out IWICMetadataQueryWriter ppIQueryWriter);
        
        // IWICImagingFactory2
        [PreserveSig]
        HRESULT CreateImageEncoder(/* [in] */ ID2D1Device pD2DDevice, /* [out] */ out IWICImageEncoder ppWICImageEncoder);
    }
}
