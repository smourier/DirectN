using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    [Guid("E8EDA601-3D48-431a-AB44-69059BE88BBE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICPixelFormatInfo : IWICComponentInfo
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
        HRESULT GetFormatGUID(out Guid pFormat);

        [PreserveSig]
        HRESULT GetColorContext(out IWICColorContext ppIColorContext);

        [PreserveSig]
        HRESULT GetBitsPerPixel(out int puiBitsPerPixel);

        [PreserveSig]
        HRESULT GetChannelCount(out int puiChannelCount);

        [PreserveSig]
        HRESULT GetChannelMask(int uiChannelIndex, int cbMaskBuffer, IntPtr pbMaskBuffer, out int pcbActual);
    }
}
