// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_TRIMNOTIFICATION
    {
        public IntPtr Context;
        public D3DDDI_TRIMRESIDENCYSET_FLAGS Flags;
        public ulong NumBytesToTrim;
    }
}
