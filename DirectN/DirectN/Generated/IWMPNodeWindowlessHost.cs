// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmprealestate.h(764,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("be7017c6-ce34-4901-8106-770381aa6e3e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeWindowlessHost
    {
        [PreserveSig]
        HRESULT InvalidateRect(/* [in] */ ref tagRECT prc, /* [in] */ bool fErase);
    }
}
