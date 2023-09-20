// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ede80b5c-bad6-4623-b537-65586c9f8dfd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRAspectRatioControl
    {
        [PreserveSig]
        HRESULT GetAspectRatioMode(/* [out] */ out uint lpdwARMode);
        
        [PreserveSig]
        HRESULT SetAspectRatioMode(/* [in] */ uint dwARMode);
    }
}
