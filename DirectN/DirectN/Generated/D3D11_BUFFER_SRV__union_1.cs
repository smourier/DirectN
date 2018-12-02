// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(3307,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_BUFFER_SRV__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint NumElements => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint ElementWidth => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
