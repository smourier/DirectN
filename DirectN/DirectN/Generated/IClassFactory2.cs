// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(1012,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b196b28f-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IClassFactory2
    {
        [PreserveSig]
        HRESULT GetLicInfo(/* [out][in] __RPC__inout */ ref tagLICINFO pLicInfo);
        
        [PreserveSig]
        HRESULT RequestLicKey(/* [in] */ uint dwReserved, /* [out] __RPC__deref_out_opt */ out IntPtr pBstrKey);
        
        [PreserveSig]
        HRESULT CreateInstanceLic(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, /* [annotation][in] _Reserved_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkReserved, /* [annotation][in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][in] __RPC__in */ [MarshalAs(UnmanagedType.BStr)] string bstrKey, /* [annotation][iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);
    }
}
