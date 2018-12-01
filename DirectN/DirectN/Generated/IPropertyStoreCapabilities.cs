// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1134,5)
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;

namespace DirectN
{
    [Guid("c8e2d566-186e-4d49-bf41-6909ead56acc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyStoreCapabilities
    {
        [PreserveSig]
        HRESULT IsPropertyWritable(/* [in] __RPC__in */ ref PROPERTYKEY key);
    }
}
