// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ocidl.h(2673,5)
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
        HRESULT Load(/* optional(IPropertyBag) */ IntPtr pPropBag, /* optional(IErrorLog) */ IntPtr pErrorLog);
        
        [PreserveSig]
        HRESULT Save(/* optional(IPropertyBag) */ IntPtr pPropBag, /* [in] */ bool fClearDirty, /* [in] */ bool fSaveAllProperties);
    }
}
