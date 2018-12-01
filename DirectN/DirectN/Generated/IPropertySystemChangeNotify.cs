// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(3998,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fa955fd9-38be-4879-a6ce-824cf52d609f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertySystemChangeNotify
    {
        [PreserveSig]
        HRESULT SchemaRefreshed();
    }
}
