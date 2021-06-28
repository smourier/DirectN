// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ocidl.h(6032,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("22f55882-280b-11d0-a8a9-00a0c90c2004"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyBag2
    {
        [PreserveSig]
        HRESULT Read(/* [in] */ int cProperties, /* [size_is][in] __RPC__in_ecount_full(cProperties) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagPROPBAG2[] pPropBag, /* optional(IErrorLog) */ IntPtr pErrLog, /* [size_is][out] __RPC__out_ecount_full(cProperties) */ out IntPtr pvarValue, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cProperties) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] HRESULT[] phrError);
        
        [PreserveSig]
        HRESULT Write(/* [in] */ int cProperties, /* [size_is][in] __RPC__in_ecount_full(cProperties) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagPROPBAG2[] pPropBag, /* [size_is][in] __RPC__in_ecount_full(cProperties) */ IntPtr pvarValue);
        
        [PreserveSig]
        HRESULT CountProperties(/* [out] __RPC__out */ out uint pcProperties);
        
        [PreserveSig]
        HRESULT GetPropertyInfo(/* [in] */ uint iProperty, /* [in] */ int cProperties, /* [size_is][out] __RPC__out_ecount_full(cProperties) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagPROPBAG2[] pPropBag, /* [out] __RPC__out */ out uint pcProperties);
        
        [PreserveSig]
        HRESULT LoadObject(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pstrName, /* [in] */ uint dwHint, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkObject, /* optional(IErrorLog) */ IntPtr pErrLog);
    }
}
