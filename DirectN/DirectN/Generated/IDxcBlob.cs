// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxcapi.h(99,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcBlob
    {
        [PreserveSig]
        IntPtr GetBufferPointer();
        
        [PreserveSig]
        ulong GetBufferSize();
    }
}
