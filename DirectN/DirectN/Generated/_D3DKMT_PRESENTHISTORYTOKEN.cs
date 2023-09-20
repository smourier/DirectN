// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
