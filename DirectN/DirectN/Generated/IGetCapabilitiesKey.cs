// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(16911,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a8809222-07bb-48ea-951c-33158100625b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGetCapabilitiesKey
    {
        [PreserveSig]
        HRESULT GetCapabilitiesKey(/* [annotation][out] _Out_ */ out IntPtr pHKey);
    }
}
