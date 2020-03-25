// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wincodecsdk.h(1347,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("eebf1f5b-07c1-4447-a3ab-22acaf78a804"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataReaderInfo : IWICMetadataHandlerInfo
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
        
        // IWICMetadataHandlerInfo
        [PreserveSig]
        new HRESULT GetMetadataFormat(/* [out] __RPC__out */ out Guid pguidMetadataFormat);
        
        [PreserveSig]
        new HRESULT GetContainerFormats(/* [in] */ int cContainerFormats, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cContainerFormats) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pguidContainerFormats, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceManufacturer(/* [in] */ uint cchDeviceManufacturer, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceManufacturer) */ [MarshalAs(UnmanagedType.LPWStr)] string wzDeviceManufacturer, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceModels(/* [in] */ uint cchDeviceModels, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceModels) */ [MarshalAs(UnmanagedType.LPWStr)] string wzDeviceModels, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT DoesRequireFullStream(/* [out] __RPC__out */ out bool pfRequiresFullStream);
        
        [PreserveSig]
        new HRESULT DoesSupportPadding(/* [out] __RPC__out */ out bool pfSupportsPadding);
        
        [PreserveSig]
        new HRESULT DoesRequireFixedSize(/* [out] __RPC__out */ out bool pfFixedSize);
        
        // IWICMetadataReaderInfo
        [PreserveSig]
        HRESULT GetPatterns(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* [in] */ uint cbSize, /* optional(WICMetadataPattern) */ IntPtr pPattern, /* optional(UINT) */ IntPtr pcCount, /* optional(UINT) */ IntPtr pcbActual);
        
        [PreserveSig]
        HRESULT MatchesPattern(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* [in] __RPC__in_opt */ IStream pIStream, /* [out] __RPC__out */ out bool pfMatches);
        
        [PreserveSig]
        HRESULT CreateInstance(/* [out] __RPC__deref_out_opt */ out IWICMetadataReader ppIReader);
    }
}
