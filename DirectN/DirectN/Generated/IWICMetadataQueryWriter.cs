// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(3148,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a721791a-0def-4d06-bd91-2118bf1db10b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataQueryWriter : IWICMetadataQueryReader
    {
        // IWICMetadataQueryReader
        [PreserveSig]
        new HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        new HRESULT GetLocation(/* [in] */ uint cchMaxLength, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchMaxLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] char[] wzNamespace, /* [out] __RPC__out */ out uint pcchActualLength);
        
        [PreserveSig]
        new HRESULT GetMetadataByName(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzName, /* [unique][out][in] __RPC__inout_opt */ PropVariant pvarValue);
        
        [PreserveSig]
        new HRESULT GetEnumerator(/* optional(IEnumString) */ out IntPtr ppIEnumString);
        
        // IWICMetadataQueryWriter
        [PreserveSig]
        HRESULT SetMetadataByName(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzName, /* [in] __RPC__in */ PropVariant pvarValue);
        
        [PreserveSig]
        HRESULT RemoveMetadataByName(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzName);
    }
}
