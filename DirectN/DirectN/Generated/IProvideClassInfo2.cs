// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(1221,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a6bc3ac0-dbaa-11ce-9de3-00aa004bb851"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IProvideClassInfo2 : IProvideClassInfo
    {
        // IProvideClassInfo
        [PreserveSig]
        new HRESULT GetClassInfoA(/* [out] __RPC__deref_out_opt */ out ITypeInfo ppTI);
        
        // IProvideClassInfo2
        [PreserveSig]
        HRESULT GetGUID(/* [in] */ uint dwGuidKind, /* [out] __RPC__out */ out Guid pGUID);
    }
}
