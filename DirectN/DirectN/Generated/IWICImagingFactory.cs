// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(6273,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using REFWICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICImagingFactory
    {
        [PreserveSig]
        HRESULT CreateDecoderFromFilename(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzFilename, /* optional(GUID) */ IntPtr pguidVendor, /* [in] */ uint dwDesiredAccess, /* [in] */ WICDecodeOptions metadataOptions, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        HRESULT CreateDecoderFromStream(/* [in] __RPC__in_opt */ IStream pIStream, /* optional(GUID) */ IntPtr pguidVendor, /* [in] */ WICDecodeOptions metadataOptions, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        HRESULT CreateDecoderFromFileHandle(/* [in] */ IntPtr hFile, /* optional(GUID) */ IntPtr pguidVendor, /* [in] */ WICDecodeOptions metadataOptions, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        HRESULT CreateComponentInfo(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsidComponent, /* [out] __RPC__deref_out_opt */ out IWICComponentInfo ppIInfo);
        
        [PreserveSig]
        HRESULT CreateDecoder(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* optional(GUID) */ IntPtr pguidVendor, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapDecoder ppIDecoder);
        
        [PreserveSig]
        HRESULT CreateEncoder(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* optional(GUID) */ IntPtr pguidVendor, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapEncoder ppIEncoder);
        
        [PreserveSig]
        HRESULT CreatePalette(/* [out] __RPC__deref_out_opt */ out IWICPalette ppIPalette);
        
        [PreserveSig]
        HRESULT CreateFormatConverter(/* [out] __RPC__deref_out_opt */ out IWICFormatConverter ppIFormatConverter);
        
        [PreserveSig]
        HRESULT CreateBitmapScaler(/* [out] __RPC__deref_out_opt */ out IWICBitmapScaler ppIBitmapScaler);
        
        [PreserveSig]
        HRESULT CreateBitmapClipper(/* [out] __RPC__deref_out_opt */ out IWICBitmapClipper ppIBitmapClipper);
        
        [PreserveSig]
        HRESULT CreateBitmapFlipRotator(/* [out] __RPC__deref_out_opt */ out IWICBitmapFlipRotator ppIBitmapFlipRotator);
        
        [PreserveSig]
        HRESULT CreateStream(/* [out] __RPC__deref_out_opt */ out IWICStream ppIWICStream);
        
        [PreserveSig]
        HRESULT CreateColorContext(/* [out] __RPC__deref_out_opt */ out IWICColorContext ppIWICColorContext);
        
        [PreserveSig]
        HRESULT CreateColorTransformer(/* [out] __RPC__deref_out_opt */ out IWICColorTransform ppIWICColorTransform);
        
        [PreserveSig]
        HRESULT CreateBitmap(/* [in] */ uint uiWidth, /* [in] */ uint uiHeight, /* [in] __RPC__in */ ref REFWICPixelFormatGUID pixelFormat, /* [in] */ WICBitmapCreateCacheOption option, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        HRESULT CreateBitmapFromSource(/* [in] __RPC__in_opt */ IWICBitmapSource pIBitmapSource, /* [in] */ WICBitmapCreateCacheOption option, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        HRESULT CreateBitmapFromSourceRect(/* [in] __RPC__in_opt */ IWICBitmapSource pIBitmapSource, /* [in] */ uint x, /* [in] */ uint y, /* [in] */ uint width, /* [in] */ uint height, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        HRESULT CreateBitmapFromMemory(/* [in] */ uint uiWidth, /* [in] */ uint uiHeight, /* [in] __RPC__in */ ref REFWICPixelFormatGUID pixelFormat, /* [in] */ uint cbStride, /* [in] */ int cbBufferSize, /* [size_is][in] __RPC__in_ecount_full(cbBufferSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] pbBuffer, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        HRESULT CreateBitmapFromHBITMAP(/* [in] __RPC__in */ IntPtr hBitmap, /* optional(HPALETTE__) */ IntPtr hPalette, /* [in] */ WICBitmapAlphaChannelOption options, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        HRESULT CreateBitmapFromHICON(/* [in] __RPC__in */ IntPtr hIcon, /* [out] __RPC__deref_out_opt */ out IWICBitmap ppIBitmap);
        
        [PreserveSig]
        HRESULT CreateComponentEnumerator(/* [in] */ uint componentTypes, /* [in] */ uint options, /* [out] __RPC__deref_out_opt */ out IntPtr ppIEnumUnknown);
        
        [PreserveSig]
        HRESULT CreateFastMetadataEncoderFromDecoder(/* [in] __RPC__in_opt */ IWICBitmapDecoder pIDecoder, /* [out] __RPC__deref_out_opt */ out IWICFastMetadataEncoder ppIFastEncoder);
        
        [PreserveSig]
        HRESULT CreateFastMetadataEncoderFromFrameDecode(/* [in] __RPC__in_opt */ IWICBitmapFrameDecode pIFrameDecoder, /* [out] __RPC__deref_out_opt */ out IWICFastMetadataEncoder ppIFastEncoder);
        
        [PreserveSig]
        HRESULT CreateQueryWriter(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMetadataFormat, /* optional(GUID) */ IntPtr pguidVendor, /* [out] __RPC__deref_out_opt */ out IWICMetadataQueryWriter ppIQueryWriter);
        
        [PreserveSig]
        HRESULT CreateQueryWriterFromReader(/* [in] __RPC__in_opt */ IWICMetadataQueryReader pIQueryReader, /* optional(GUID) */ IntPtr pguidVendor, /* [out] __RPC__deref_out_opt */ out IWICMetadataQueryWriter ppIQueryWriter);
    }
}
