// generated from <Windows SDK Path>\um\wmprealestate.h
using System;
using System.Runtime.InteropServices;
using OLE_HWND = System.Int64;

namespace DirectN
{
    [ComImport, Guid("96740bfa-c56a-45d1-a3a4-762914d4ade9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeWindowed
    {
        [PreserveSig]
        HRESULT SetOwnerWindow(/* [in] */ long hwnd);
        
        [PreserveSig]
        HRESULT GetOwnerWindow(/* [out] */ out OLE_HWND phwnd);
    }
}
