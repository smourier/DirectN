// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(851,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The commandList interface.
    /// </summary>
    [ComImport, Guid("b4f34a19-2383-4d76-94f6-ec343657c3dc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandList : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1CommandList
        [PreserveSig]
        HRESULT Stream(/* _In_ */ ID2D1CommandSink sink);
        
        [PreserveSig]
        HRESULT Close();
    }
}
