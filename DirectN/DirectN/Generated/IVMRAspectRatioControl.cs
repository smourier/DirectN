// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(19744,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ede80b5c-bad6-4623-b537-65586c9f8dfd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRAspectRatioControl
    {
        [PreserveSig]
        HRESULT GetAspectRatioMode(/* [out] */ out uint lpdwARMode);
        
        [PreserveSig]
        HRESULT SetAspectRatioMode(/* [in] */ uint dwARMode);
    }
}
