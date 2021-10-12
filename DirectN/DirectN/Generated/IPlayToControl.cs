// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfsharingengine.h(1035,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("607574eb-f4b6-45c1-b08c-cb715122901d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPlayToControl
    {
        [PreserveSig]
        HRESULT Connect(/* [in] __RPC__in_opt */ IMFSharingEngineClassFactory pFactory);
        
        [PreserveSig]
        HRESULT Disconnect();
    }
}
