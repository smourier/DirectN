// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dcommon.h(471,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DDestructionNotifier
    {
        [PreserveSig]
        HRESULT RegisterDestructionCallback(/* [annotation] _In_ */ IntPtr callbackFn, /* [annotation] _In_ */ IntPtr pData, /* [annotation] _Out_ */ out uint pCallbackID);
        
        [PreserveSig]
        HRESULT UnregisterDestructionCallback(/* [annotation] _In_ */ uint callbackID);
    }
}
