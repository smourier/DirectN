// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(3064,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dc2bb46d-3f07-481e-8625-220c4aedbb33"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICEnumMetadataItem
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint celt, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(celt) */ [In, Out] PropVariant rgeltSchema, /* [size_is][out][in] __RPC__inout_ecount_full(celt) */ [In, Out] PropVariant rgeltId, /* [size_is][optional][out][in] __RPC__inout_ecount_full(celt) */ [In, Out] PropVariant rgeltValue, /* [optional][out] __RPC__out */ out uint pceltFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint celt);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IWICEnumMetadataItem ppIEnumMetadataItem);
    }
}
