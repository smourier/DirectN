// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a09513ed-c709-4d21-bd7b-5f34c47f3947"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IControlChangeNotify
    {
        [PreserveSig]
        HRESULT OnNotify(/* [annotation][in] _In_ */ uint dwSenderProcessId, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}
