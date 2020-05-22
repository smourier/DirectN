// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmprealestate.h(394,5)
using System;
using System.Runtime.InteropServices;
using OLE_HWND = System.Int64;

namespace DirectN
{
    [Guid("96740bfa-c56a-45d1-a3a4-762914d4ade9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeWindowed
    {
        [PreserveSig]
        HRESULT SetOwnerWindow(/* [in] */ long hwnd);
        
        [PreserveSig]
        HRESULT GetOwnerWindow(/* [out] */ out OLE_HWND phwnd);
    }
}
