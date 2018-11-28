using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    [Guid("23BC3F0A-698B-4357-886B-F24D50671334"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICComponentInfo
    {
        [PreserveSig]
        HRESULT GetComponentType(out WICComponentType pType);

        [PreserveSig]
        HRESULT GetCLSID(out Guid pclsid);

        [PreserveSig]
        HRESULT GetSigningStatus(out WICComponentSigning pStatus);

        [PreserveSig]
        HRESULT GetAuthor(int cchAuthor, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzAuthor, out int pcchActual);

        [PreserveSig]
        HRESULT GetVendorGUID(out Guid pguidVendor);

        [PreserveSig]
        HRESULT GetVersion(int cchVersion, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzVersion, out int pcchActual);

        [PreserveSig]
        HRESULT GetSpecVersion(int cchSpecVersion, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzSpecVersion, out int pcchActual);

        [PreserveSig]
        HRESULT GetFriendlyName(int cchFriendlyName, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzFriendlyName, out int pcchActual);
    }
}
