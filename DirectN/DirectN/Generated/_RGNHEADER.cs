// generated from <Windows SDK Path>\shared\dls1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _RGNHEADER
    {
        public _RGNRANGE RangeKey;
        public _RGNRANGE RangeVelocity;
        public ushort fusOptions;
        public ushort usKeyGroup;
    }
}
