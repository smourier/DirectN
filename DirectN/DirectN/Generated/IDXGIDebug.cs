// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgidebug.h(794,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("119e7452-de9e-40fe-8806-88f90c12b441"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDebug
    {
        [PreserveSig]
        HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags);
    }
}
