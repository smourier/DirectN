// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(3187,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("30989668-e1c9-4597-b395-458eedb808df"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataQueryReader
    {
        [PreserveSig]
        HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        HRESULT GetLocation(/* [in] */ uint cchMaxLength, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchMaxLength) */ [MarshalAs(UnmanagedType.LPWStr)] string wzNamespace, /* [out] __RPC__out */ out uint pcchActualLength);
        
        [PreserveSig]
        HRESULT GetMetadataByName(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzName, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PropVariant pvarValue);
        
        [PreserveSig]
        HRESULT GetEnumerator(/* [out] __RPC__deref_out_opt */ out IEnumString ppIEnumString);
    }
}
