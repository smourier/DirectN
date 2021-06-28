// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11_1.h(2612,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA
    {
        public uint HWProtectionFunctionID;
        public IntPtr pInputData;
        public IntPtr pOutputData;
        public HRESULT Status;
    }
}
