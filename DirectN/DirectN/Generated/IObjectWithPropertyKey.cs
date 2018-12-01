// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(785,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fc0ca0a7-c316-4fd2-9031-3e628e6d4f23"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IObjectWithPropertyKey
    {
        [PreserveSig]
        HRESULT SetPropertyKey(/* [in] __RPC__in */ ref _tagpropertykey key);
        
        [PreserveSig]
        HRESULT GetPropertyKey(/* [out] __RPC__out */ out _tagpropertykey pkey);
    }
}
