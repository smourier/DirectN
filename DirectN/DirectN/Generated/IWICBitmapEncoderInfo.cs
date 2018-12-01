// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(5342,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("94c9b4ee-a09f-4f92-8a1e-4a9bce7e76fb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        new HRESULT GetAuthor(/* [in] */ uint cchAuthor, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchAuthor) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzAuthor, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetVendorGUID(/* [out] __RPC__out */ out Guid pguidVendor);
        
        [PreserveSig]
        new HRESULT GetVersion(/* [in] */ uint cchVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchVersion) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetSpecVersion(/* [in] */ uint cchSpecVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchSpecVersion) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzSpecVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetFriendlyName(/* [in] */ uint cchFriendlyName, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchFriendlyName) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzFriendlyName, /* [out] __RPC__out */ out uint pcchActual);
        
        // IWICBitmapCodecInfo
        [PreserveSig]
        new HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        new HRESULT GetPixelFormats(/* [in] */ uint cFormats, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cFormats) */ out Guid pguidPixelFormats, /* [out] __RPC__out */ out uint pcActual);
        
        [PreserveSig]
        new HRESULT GetColorManagementVersion(/* [in] */ uint cchColorManagementVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchColorManagementVersion) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzColorManagementVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceManufacturer(/* [in] */ uint cchDeviceManufacturer, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceManufacturer) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzDeviceManufacturer, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceModels(/* [in] */ uint cchDeviceModels, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceModels) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzDeviceModels, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetMimeTypes(/* [in] */ uint cchMimeTypes, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchMimeTypes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzMimeTypes, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetFileExtensions(/* [in] */ uint cchFileExtensions, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchFileExtensions) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzFileExtensions, /* [out] __RPC__out */ out uint pcchActual);
        
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
