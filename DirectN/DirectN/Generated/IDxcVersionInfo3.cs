// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(589,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5e13e843-9d25-473c-9ad2-03b2d0b44b1e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcVersionInfo3
    {
        [PreserveSig]
        HRESULT GetCustomVersionString(/* _Outptr_result_z_ */ out IntPtr pVersionString);
    }
}
