// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(378,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DTLVERTEX__union_5
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint specular => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dcSpecular => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
