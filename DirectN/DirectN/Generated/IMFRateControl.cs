// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(8483,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("88ddcd21-03c3-4275-91ed-55ee3929328f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRateControl
    {
        [PreserveSig]
        HRESULT SetRate(/* [in] */ bool fThin, /* [in] */ float flRate);
        
        [PreserveSig]
        HRESULT GetRate(/* optional(BOOL) */ IntPtr pfThin, /* [unique][out][in] __RPC__inout_opt */ ref float pflRate);
    }
}
