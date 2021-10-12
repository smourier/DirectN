// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(627,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENTHISTORYTOKEN
    {
        public _D3DKMT_PRESENT_MODEL Model;
        public uint TokenSize;
        public ulong CompositionBindingId;
        public _D3DKMT_PRESENTHISTORYTOKEN__union_0 Token;
    }
}
