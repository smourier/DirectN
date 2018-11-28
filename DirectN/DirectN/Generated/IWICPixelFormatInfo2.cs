using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    [Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICPixelFormatInfo2 : IWICPixelFormatInfo
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

        // IWICPixelFormatInfo
        [PreserveSig]
        new HRESULT GetFormatGUID(out Guid pFormat);

        [PreserveSig]
        new HRESULT GetColorContext(out IWICColorContext ppIColorContext);

        [PreserveSig]
        new HRESULT GetBitsPerPixel(out int puiBitsPerPixel);

        [PreserveSig]
        new HRESULT GetChannelCount(out int puiChannelCount);

        [PreserveSig]
        new HRESULT GetChannelMask(int uiChannelIndex, int cbMaskBuffer, IntPtr pbMaskBuffer, out int pcbActual);

        // IWICPixelFormatInfo2
        [PreserveSig]
        HRESULT SupportsTransparency(out bool pfSupportsTransparency);

        [PreserveSig]
        HRESULT GetNumericRepresentation(out WICPixelFormatNumericRepresentation pNumericRepresentation);
    }
}
