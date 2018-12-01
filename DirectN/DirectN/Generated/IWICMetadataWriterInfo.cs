// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodecsdk.h(1614,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b22e3fba-3925-4323-b5c1-9ebfc430f236"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataWriterInfo : IWICMetadataHandlerInfo
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
        new HRESULT GetMetadataFormat(/* [out] __RPC__out */ out Guid pguidMetadataFormat);
        
        [PreserveSig]
        new HRESULT GetContainerFormats(/* [in] */ uint cContainerFormats, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cContainerFormats) */ out Guid pguidContainerFormats, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceManufacturer(/* [in] */ uint cchDeviceManufacturer, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceManufacturer) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzDeviceManufacturer, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT GetDeviceModels(/* [in] */ uint cchDeviceModels, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchDeviceModels) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzDeviceModels, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        new HRESULT DoesRequireFullStream(/* [out] __RPC__out */ out bool pfRequiresFullStream);
        
        [PreserveSig]
        new HRESULT DoesSupportPadding(/* [out] __RPC__out */ out bool pfSupportsPadding);
        
        [PreserveSig]
        new HRESULT DoesRequireFixedSize(/* [out] __RPC__out */ out bool pfFixedSize);
        
        // IWICMetadataWriterInfo
        [PreserveSig]
        HRESULT GetHeader(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* [in] */ uint cbSize, /* [annotation][unique][out][in] _Out_writes_bytes_opt_(cbSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] WICMetadataHeader[] pHeader, /* [annotation][unique][out][in] _Out_opt_ */ ref uint pcbActual);
        
        [PreserveSig]
        HRESULT CreateInstance(/* [out] __RPC__deref_out_opt */ out IWICMetadataWriter ppIWriter);
    }
}
