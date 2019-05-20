// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\devicetopology.h(3346,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a09513ed-c709-4d21-bd7b-5f34c47f3947"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IControlChangeNotify
    {
        [PreserveSig]
        HRESULT OnNotify(/* [annotation][in] _In_ */ uint dwSenderProcessId, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}
