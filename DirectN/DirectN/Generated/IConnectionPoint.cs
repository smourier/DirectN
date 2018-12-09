// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(606,5)
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    [Guid("b196b286-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IConnectionPoint
    {
        [PreserveSig]
        HRESULT GetConnectionInterface(/* [out] __RPC__out */ out Guid pIID);
        
        [PreserveSig]
        HRESULT GetConnectionPointContainer(/* [out] __RPC__deref_out_opt */ out IConnectionPointContainer ppCPC);
        
        [PreserveSig]
        HRESULT Advise(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkSink, /* [out] __RPC__out */ out uint pdwCookie);
        
        [PreserveSig]
        HRESULT Unadvise(/* [in] */ uint dwCookie);
        
        [PreserveSig]
        HRESULT EnumConnections(/* [out] __RPC__deref_out_opt */ out IEnumConnections ppEnum);
    }
}
