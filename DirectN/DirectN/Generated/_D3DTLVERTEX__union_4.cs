// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(374,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DTLVERTEX__union_4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint color => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dcColor => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
