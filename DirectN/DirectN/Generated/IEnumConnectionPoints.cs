// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(732,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b196b285-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumConnectionPoints
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint cConnections, /* [length_is][size_is][out] */ out IntPtr[] ppCP, /* [out] */ out uint pcFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cConnections);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IEnumConnectionPoints ppEnum);
    }
}
