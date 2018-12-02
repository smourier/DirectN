// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(2100,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS__union_0__struct_0 __field_0 => InteropRuntime.Get<_D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS__union_0__struct_0>(__bits, 0, 32);
        public uint Value => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
