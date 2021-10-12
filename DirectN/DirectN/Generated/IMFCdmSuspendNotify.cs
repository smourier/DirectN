// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(5225,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7a5645d2-43bd-47fd-87b7-dcd24cc7d692"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCdmSuspendNotify
    {
        [PreserveSig]
        HRESULT Begin();
        
        [PreserveSig]
        HRESULT End();
    }
}
