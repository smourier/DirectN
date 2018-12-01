// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodecsdk.h(1111,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("aba958bf-c672-44d1-8d61-ce6df2e682c2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataHandlerInfo : IWICComponentInfo
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
        
        // IWICMetadataHandlerInfo
        [PreserveSig]
        HRESULT GetMetadataFormat(/* [out] __RPC__out */ out Guid pguidMetadataFormat);
        
        [PreserveSig]
        HRESULT GetContainerFormats(/* [in] */ uint cContainerFormats, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cContainerFormats) */ out Guid pguidContainerFormats, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        HRESULT GetDeviceManufacturer(/* [in] */ uint cchDeviceManufacturer, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceManufacturer) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzDeviceManufacturer, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        HRESULT GetDeviceModels(/* [in] */ uint cchDeviceModels, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceModels) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzDeviceModels, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        HRESULT DoesRequireFullStream(/* [out] __RPC__out */ out bool pfRequiresFullStream);
        
        [PreserveSig]
        HRESULT DoesSupportPadding(/* [out] __RPC__out */ out bool pfSupportsPadding);
        
        [PreserveSig]
        HRESULT DoesRequireFixedSize(/* [out] __RPC__out */ out bool pfFixedSize);
    }
}
