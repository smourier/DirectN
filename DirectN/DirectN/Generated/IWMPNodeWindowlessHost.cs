// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmprealestate.h(805,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("be7017c6-ce34-4901-8106-770381aa6e3e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeWindowlessHost
    {
        [PreserveSig]
        HRESULT InvalidateRect(/* [in] */ ref tagRECT prc, /* [in] */ bool fErase);
    }
}
