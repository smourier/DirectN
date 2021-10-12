// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dcommon.h(414,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Blob
    {
        [PreserveSig]
        IntPtr GetBufferPointer();
        
        [PreserveSig]
        IntPtr GetBufferSize();
    }
}
