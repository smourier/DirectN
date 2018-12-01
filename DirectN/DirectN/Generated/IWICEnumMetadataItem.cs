// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(2916,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dc2bb46d-3f07-481e-8625-220c4aedbb33"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICEnumMetadataItem
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint celt, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(celt) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] PropVariant[] rgeltSchema, /* [size_is][out][in] __RPC__inout_ecount_full(celt) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] PropVariant[] rgeltId, /* [size_is][optional][out][in] __RPC__inout_ecount_full(celt) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] PropVariant[] rgeltValue, /* [optional][out] __RPC__out */ out uint pceltFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint celt);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IWICEnumMetadataItem ppIEnumMetadataItem);
    }
}
