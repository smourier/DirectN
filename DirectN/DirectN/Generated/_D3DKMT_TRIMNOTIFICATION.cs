﻿// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(5185,9)
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
