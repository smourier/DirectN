// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9f0aa3b6-7267-4d89-88f2-ba915aa5c4c6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMImageInfo
    {
        [PreserveSig]
        HRESULT GetImageCount(/* [out] */ out uint pcImages);
        
        [PreserveSig]
        HRESULT GetImage(/* [in] */ uint wIndex, /* [out][in] */ ref ushort pcchMIMEType, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszMIMEType, /* [out][in] */ ref ushort pcchDescription, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription, /* [out] */ out ushort pImageType, /* [out][in] */ ref uint pcbImageData, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pbImageData);
    }
}
