using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DirectN
{
    [Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapDecoderInfo : IWICBitmapCodecInfo
    {
        // IWICComponentInfo
        [PreserveSig]
        new HRESULT GetComponentType(out WICComponentType pType);

        [PreserveSig]
        new HRESULT GetCLSID(out Guid pclsid);

        [PreserveSig]
        new HRESULT GetSigningStatus(out WICComponentSigning pStatus);

        [PreserveSig]
        new HRESULT GetAuthor(int cchAuthor, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzAuthor, out int pcchActual);

        [PreserveSig]
        new HRESULT GetVendorGUID(out Guid pguidVendor);

        [PreserveSig]
        new HRESULT GetVersion(int cchVersion, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzVersion, out int pcchActual);

        [PreserveSig]
        new HRESULT GetSpecVersion(int cchSpecVersion, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzSpecVersion, out int pcchActual);

        [PreserveSig]
        new HRESULT GetFriendlyName(int cchFriendlyName, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzFriendlyName, out int pcchActual);

        // IWICBitmapCodecInfo
        [PreserveSig]
        new HRESULT GetContainerFormat(out Guid pguidContainerFormat);

        [PreserveSig]
        new HRESULT GetPixelFormats(int cFormats, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] Guid[] pguidPixelFormats, out int pcActual);

        [PreserveSig]
        new HRESULT GetColorManagementVersion(int cchColorManagementVersion, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzColorManagementVersion, out int pcchActual);

        [PreserveSig]
        new HRESULT GetDeviceManufacturer(int cchDeviceManufacturer, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzDeviceManufacturer, out int pcchActual);

        [PreserveSig]
        new HRESULT GetDeviceModels(int cchDeviceModels, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzDeviceModels, out int pcchActual);

        [PreserveSig]
        new HRESULT GetMimeTypes(int cchMimeTypes, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzMimeTypes, out int pcchActual);

        [PreserveSig]
        new HRESULT GetFileExtensions(int cchFileExtensions, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzFileExtensions, out int pcchActual);

        [PreserveSig]
        new HRESULT DoesSupportAnimation(out bool pfSupportAnimation);

        [PreserveSig]
        new HRESULT DoesSupportChromakey(out bool pfSupportChromakey);

        [PreserveSig]
        new HRESULT DoesSupportLossless(out bool pfSupportLossless);

        [PreserveSig]
        new HRESULT DoesSupportMultiframe(out bool pfSupportMultiframe);

        [PreserveSig]
        new HRESULT MatchesMimeType([MarshalAs(UnmanagedType.LPWStr)] string wzMimeType, out bool pfMatches);

        // IWICBitmapDecoderInfo
        [PreserveSig]
        HRESULT GetPatterns(
            int cbSizePatterns,
            /* WICBitmapPattern[] */ IntPtr pPatterns,
            out int pcPatterns,
            out int pcbPatternsActual);

        [PreserveSig]
        HRESULT MatchesPattern(IStream pIStream, out bool pfMatches);

        [PreserveSig]
        HRESULT CreateInstance(out IWICBitmapDecoder ppIBitmapDecoder);
    }
}
