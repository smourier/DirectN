// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(2673,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("37d84f60-42cb-11ce-8135-00aa004bb851"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPersistPropertyBag
    {
        [PreserveSig]
        HRESULT InitNew();
        
        [PreserveSig]
        HRESULT Load(/* [in] __RPC__in_opt */ ref IPropertyBag pPropBag, /* [unique][in] __RPC__in_opt */ ref IErrorLog pErrorLog);
        
        [PreserveSig]
        HRESULT Save(/* [in] __RPC__in_opt */ ref IPropertyBag pPropBag, /* [in] */ bool fClearDirty, /* [in] */ bool fSaveAllProperties);
    }
}
