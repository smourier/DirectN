// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(5355,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("94c9b4ee-a09f-4f92-8a1e-4a9bce7e76fb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapEncoderInfo : IWICBitmapCodecInfo
    {
        // IWICComponentInfo
        [PreserveSig]
        new HRESULT GetComponentType(/* [out] __RPC__out */ out WICComponentType pType);
        
        [PreserveSig]
        new HRESULT GetCLSID(/* [out] __RPC__out */ out Guid pclsid);
        
        [PreserveSig]
        new HRESULT GetSigningStatus(/* [out] __RPC__out */ out uint pStatus);
        
        [PreserveSig]
        new HRESULT GetAuthor(/* [in] */ uint cchAuthor, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchAuthor) */ [MarshalAs(UnmanagedType.LPWStr)] string wzAuthor, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetVendorGUID(/* [out] __RPC__out */ out Guid pguidVendor);
        
        [PreserveSig]
        new HRESULT GetVersion(/* [in] */ uint cchVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchVersion) */ [MarshalAs(UnmanagedType.LPWStr)] string wzVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetSpecVersion(/* [in] */ uint cchSpecVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchSpecVersion) */ [MarshalAs(UnmanagedType.LPWStr)] string wzSpecVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetFriendlyName(/* [in] */ uint cchFriendlyName, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchFriendlyName) */ [MarshalAs(UnmanagedType.LPWStr)] string wzFriendlyName, /* [out] __RPC__out */ out uint pcchActual);
        
        // IWICBitmapCodecInfo
        [PreserveSig]
        new HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        new HRESULT GetPixelFormats(/* [in] */ int cFormats, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cFormats) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pguidPixelFormats, /* [out] __RPC__out */ out uint pcActual);
        
        [PreserveSig]
        new HRESULT GetColorManagementVersion(/* [in] */ uint cchColorManagementVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchColorManagementVersion) */ [MarshalAs(UnmanagedType.LPWStr)] string wzColorManagementVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceManufacturer(/* [in] */ uint cchDeviceManufacturer, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceManufacturer) */ [MarshalAs(UnmanagedType.LPWStr)] string wzDeviceManufacturer, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceModels(/* [in] */ uint cchDeviceModels, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceModels) */ [MarshalAs(UnmanagedType.LPWStr)] string wzDeviceModels, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetMimeTypes(/* [in] */ uint cchMimeTypes, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchMimeTypes) */ [MarshalAs(UnmanagedType.LPWStr)] string wzMimeTypes, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetFileExtensions(/* [in] */ uint cchFileExtensions, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchFileExtensions) */ [MarshalAs(UnmanagedType.LPWStr)] string wzFileExtensions, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT DoesSupportAnimation(/* [out] __RPC__out */ out bool pfSupportAnimation);
        
        [PreserveSig]
        new HRESULT DoesSupportChromakey(/* [out] __RPC__out */ out bool pfSupportChromakey);
        
        [PreserveSig]
        new HRESULT DoesSupportLossless(/* [out] __RPC__out */ out bool pfSupportLossless);
        
        [PreserveSig]
        new HRESULT DoesSupportMultiframe(/* [out] __RPC__out */ out bool pfSupportMultiframe);
        
        [PreserveSig]
        new HRESULT MatchesMimeType(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzMimeType, /* [out] __RPC__out */ out bool pfMatches);
        
        // IWICBitmapEncoderInfo
        [PreserveSig]
        HRESULT CreateInstance(/* [out] __RPC__deref_out_opt */ out IWICBitmapEncoder ppIBitmapEncoder);
    }
}
