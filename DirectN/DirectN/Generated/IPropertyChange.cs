// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(891,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f917bc8a-1bba-4478-a245-1bde03eb9431"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyChange : IObjectWithPropertyKey
    {
        // IObjectWithPropertyKey
        [PreserveSig]
        new HRESULT SetPropertyKey(/* [in] __RPC__in */ ref _tagpropertykey key);
        
        [PreserveSig]
        new HRESULT GetPropertyKey(/* [out] __RPC__out */ out _tagpropertykey pkey);
        
        // IPropertyChange
        [PreserveSig]
        HRESULT ApplyToPropVariant(/* [in] __RPC__in */ PropVariant propvarIn, /* [out] __RPC__out */ out PropVariant ppropvarOut);
    }
}
