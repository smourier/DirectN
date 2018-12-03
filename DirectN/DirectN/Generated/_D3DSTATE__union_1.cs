// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(1555,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSTATE__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint[] dwArg => InteropRuntime.GetArray<uint>(__bits, 0, 32);
        public D3DVALUE[] dvArg => InteropRuntime.GetArray<D3DVALUE>(__bits, 0, 32);
    }
}
