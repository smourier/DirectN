// generated from <Windows SDK Path>\shared\dls1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _CONNECTION
    {
        public ushort usSource;
        public ushort usControl;
        public ushort usDestination;
        public ushort usTransform;
        public int lScale;
    }
}
