using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    [Guid("E87A44C4-B76E-4c47-8B09-298EB12A2714"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapCodecInfo : IWICComponentInfo
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
        HRESULT GetContainerFormat(out Guid pguidContainerFormat);

        [PreserveSig]
        HRESULT GetPixelFormats(int cFormats, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] Guid[] pguidPixelFormats, out int pcActual);

        [PreserveSig]
        HRESULT GetColorManagementVersion(int cchColorManagementVersion, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzColorManagementVersion, out int pcchActual);

        [PreserveSig]
        HRESULT GetDeviceManufacturer(int cchDeviceManufacturer, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzDeviceManufacturer, out int pcchActual);

        [PreserveSig]
        HRESULT GetDeviceModels(int cchDeviceModels, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzDeviceModels, out int pcchActual);

        [PreserveSig]
        HRESULT GetMimeTypes(int cchMimeTypes, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzMimeTypes, out int pcchActual);

        [PreserveSig]
        HRESULT GetFileExtensions(int cchFileExtensions, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzFileExtensions, out int pcchActual);

        [PreserveSig]
        HRESULT DoesSupportAnimation(out bool pfSupportAnimation);

        [PreserveSig]
        HRESULT DoesSupportChromakey(out bool pfSupportChromakey);

        [PreserveSig]
        HRESULT DoesSupportLossless(out bool pfSupportLossless);

        [PreserveSig]
        HRESULT DoesSupportMultiframe(out bool pfSupportMultiframe);

        [PreserveSig]
        HRESULT MatchesMimeType([MarshalAs(UnmanagedType.LPWStr)] string wzMimeType, out bool pfMatches);
    }
}