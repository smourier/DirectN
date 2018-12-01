// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(6190,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("22f55881-280b-11d0-a8a9-00a0c90c2004"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPersistPropertyBag2
    {
        [PreserveSig]
        HRESULT InitNew();
        
        [PreserveSig]
        HRESULT Load(/* [in] __RPC__in_opt */ IPropertyBag2 pPropBag, /* optional(IErrorLog) */ IntPtr pErrLog);
        
        [PreserveSig]
        HRESULT Save(/* [in] __RPC__in_opt */ IPropertyBag2 pPropBag, /* [in] */ bool fClearDirty, /* [in] */ bool fSaveAllProperties);
        
        [PreserveSig]
        HRESULT IsDirty();
    }
}
