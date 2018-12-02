// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(2102,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint ProtectionEnabled => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint OverlayOrFullscreenRequired => InteropRuntime.GetUInt32(__bits, 1, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 2, 30);
    }
}
