// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(6066,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a9db33a2-af5f-43c7-b679-74f5984b5aa4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICPixelFormatInfo2 : IWICPixelFormatInfo
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
        
        // IWICPixelFormatInfo
        [PreserveSig]
        new HRESULT GetFormatGUID(/* [out] __RPC__out */ out Guid pFormat);
        
        [PreserveSig]
        new HRESULT GetColorContext(/* [out] __RPC__deref_out_opt */ out IWICColorContext ppIColorContext);
        
        [PreserveSig]
        new HRESULT GetBitsPerPixel(/* [out] __RPC__out */ out uint puiBitsPerPixel);
        
        [PreserveSig]
        new HRESULT GetChannelCount(/* [out] __RPC__out */ out uint puiChannelCount);
        
        [PreserveSig]
        new HRESULT GetChannelMask(/* [in] */ uint uiChannelIndex, /* [in] */ uint cbMaskBuffer, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cbMaskBuffer) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbMaskBuffer, /* [out] __RPC__out */ out uint pcbActual);
        
        // IWICPixelFormatInfo2
        [PreserveSig]
        HRESULT SupportsTransparency(/* [out] __RPC__out */ out bool pfSupportsTransparency);
        
        [PreserveSig]
        HRESULT GetNumericRepresentation(/* [out] __RPC__out */ out WICPixelFormatNumericRepresentation pNumericRepresentation);
    }
}
