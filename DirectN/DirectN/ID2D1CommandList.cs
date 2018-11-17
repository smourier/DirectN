using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b4f34a19-2383-4d76-94f6-ec343657c3dc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1CommandList : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Image

        // ID2D1CommandList
        [PreserveSig]
        HRESULT Stream(ID2D1CommandSink sink);

        [PreserveSig]
        HRESULT Close();
    }
}
